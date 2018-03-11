// <copyright file="AssemblyAnalyzer.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Assemblies
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using Microsoft.Silverlight.Testing;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;

    /// <summary>
    /// Assembly Analyzer.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    internal class AssemblyAnalyzer : IDisposable
    {
        private const string SilverlightTestAssemblyName = "Microsoft.VisualStudio.QualityTools.UnitTesting.Silverlight, Version=5.0.5.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
        private static readonly string SilverlightTestClassAttributeName = $"Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute, {SilverlightTestAssemblyName}";

        private string pathUnderInvestigation;

        private DiaSession diaSession;

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.diaSession?.Dispose();
        }

        /// <summary>
        /// Adds the tags.
        /// </summary>
        /// <param name="info">The information.</param>
        /// <param name="classAttributes">The class attributes.</param>
        /// <param name="methodAttributes">The method attributes.</param>
        internal static void AddTags(DiscoveryInfo info, IEnumerable<TagAttribute> classAttributes, IEnumerable<TagAttribute> methodAttributes)
        {
            if (info == null)
            {
                return;
            }

            if (classAttributes != null)
            {
                foreach (TagAttribute tag in classAttributes)
                {
                    if (!info.Tags.Contains(tag.Tag))
                    {
                        info.Tags.Add(tag.Tag);
                    }
                }
            }

            if (methodAttributes == null)
            {
                return;
            }

            foreach (TagAttribute methodAttribute in methodAttributes)
            {
                if (!info.Tags.Contains(methodAttribute.Tag))
                {
                    info.Tags.Add(methodAttribute.Tag);
                }
            }
        }

        /// <summary>
        /// Determines whether the specified method is a test.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <returns><c>true</c> if the specified method is a test; otherwise, <c>false</c>.</returns>
        internal static bool IsTestMethod(MethodInfo method)
        {
            List<Attribute> testMethodAttributes = method.GetCustomAttributes().ToList();
            if (!testMethodAttributes.Any())
            {
                return false;
            }

            return (
                from e in testMethodAttributes
                where e.GetType().AssemblyQualifiedName == "Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute, Microsoft.VisualStudio.QualityTools.UnitTesting.Silverlight, Version=5.0.5.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
                select e).Any();
        }

        /// <summary>
        /// Analyzes the assembly.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="assembly">The assembly.</param>
        /// <returns>The discovery information.</returns>
        internal List<DiscoveryInfo> AnalyzeAssembly(string path, Assembly assembly)
        {
            List<DiscoveryInfo> discoveredItems = new List<DiscoveryInfo>();
            if (!File.Exists(path))
            {
                return discoveredItems;
            }

            Trace.WriteLine($"Analyzing assembly: {path}");

            if (IsAssemblyReferencingTestAssemblies(assembly))
            {
                this.CreateDiaSession(path);
                this.pathUnderInvestigation = path;
                if (assembly != null)
                {
                    Trace.WriteLine($"Analyzing test assembly: {path}");

                    Type[] types;

                    try
                    {
                        types = assembly.GetTypes();
                    }
                    catch (ReflectionTypeLoadException ex)
                    {
                        string message = null;
                        if (ex.LoaderExceptions != null)
                        {
                            foreach (Exception loaderException in ex.LoaderExceptions)
                            {
                                message += loaderException.Message + Environment.NewLine;
                            }
                        }

                        Trace.WriteLine(ex + Environment.NewLine + message);

                        // continue to the next assembly
                        return discoveredItems;
                    }

                    foreach (Type type in types)
                    {
                        if (IsTestClass(type))
                        {
                            discoveredItems.AddRange(this.AnalyzeType(type));
                        }
                    }
                }
            }

            int num = discoveredItems.Count;
            Trace.WriteLine(string.Concat("----- Finished assembly analyzing. ", num.ToString(), " tests found. -----"));
            return discoveredItems;
        }

        /// <summary>
        /// Analyzes the debug information access data.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="method">The method.</param>
        /// <returns>The debug information navigation data.</returns>
        internal DiaNavigationData AnalyzeDiaData(string type, string method)
        {
            return this.diaSession.GetNavigationData(type, method);
        }

        /// <summary>
        /// Analyzes the method.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="method">The method.</param>
        /// <returns>The discovery information.</returns>
        internal DiscoveryInfo AnalyzeMethod(Type type, MethodInfo method)
        {
            if (!method.IsPublic)
            {
                return null;
            }

            return !IsTestMethod(method) ? null : this.ExtractData(type, method);
        }

        /// <summary>
        /// Analyzes the type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The discovery information.</returns>
        internal List<DiscoveryInfo> AnalyzeType(Type type)
        {
            List<DiscoveryInfo> result = new List<DiscoveryInfo>();

            // only analyze public instance methods that aren't inherited
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (MethodInfo methodInfo in methods)
            {
                DiscoveryInfo resultItem = this.AnalyzeMethod(type, methodInfo);
                if (resultItem != null)
                {
                    result.Add(resultItem);
                }
            }

            return result;
        }

        /// <summary>
        /// Creates the discovery information access session.
        /// </summary>
        /// <param name="assemblyPath">The assembly path.</param>
        internal void CreateDiaSession(string assemblyPath)
        {
            this.diaSession = new DiaSession(assemblyPath);
        }

        /// <summary>
        /// Extracts the data.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="method">The method.</param>
        /// <returns>The discovery information.</returns>
        internal DiscoveryInfo ExtractData(Type type, MethodInfo method)
        {
            if (method == null)
            {
                throw new ArgumentNullException(nameof(method));
            }

            if (method.DeclaringType == null)
            {
                return null;
            }

            DiscoveryInfo info = new DiscoveryInfo
            {
                AssemblyQualifiedName = method.DeclaringType.AssemblyQualifiedName,
                AssemblyPath = this.pathUnderInvestigation,
                AssemblyName = method.Module.Name,
                Namespace = method.DeclaringType.Namespace,
                ClassName = type.Name,
                MethodName = method.Name
            };
            IEnumerable<TagAttribute> tagAttributesClass = type.GetCustomAttributes<TagAttribute>(false);
            IEnumerable<TagAttribute> tagAttributesMethod = method.GetCustomAttributes<TagAttribute>(false);
            AddTags(info, tagAttributesClass as TagAttribute[], tagAttributesMethod as TagAttribute[]);
            DiaNavigationData data = this.AnalyzeDiaData(string.Concat(info.Namespace, ".", type.Name), method.Name);
            if (data == null)
            {
                return info;
            }

            info.LineOfCode = data.MinLineNumber;
            info.ClassFilePath = data.FileName;

            return info;
        }

        private static bool IsAssemblyReferencingTestAssemblies(Assembly assembly)
        {
            return assembly.GetReferencedAssemblies()
                .Any(x => string.Equals(x.FullName, SilverlightTestAssemblyName, StringComparison.CurrentCultureIgnoreCase));
        }

        private static bool IsTestClass(MemberInfo type)
        {
            return type.GetCustomAttributes()
                .Any(x => string.Equals(x.GetType().AssemblyQualifiedName, SilverlightTestClassAttributeName, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}