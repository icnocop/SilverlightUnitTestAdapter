// <copyright file="AssemblyAnalyzer.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Assemblies
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using Microsoft.Silverlight.Testing;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using SilverlightUnitTestAdapter.Utils;

    internal class AssemblyAnalyzer : IDisposable
    {
        private readonly VsShell shell;

        private string pathUnderInvestigation;

        private DiaSession diaSession;

        public AssemblyAnalyzer(VsShell shell)
        {
            this.shell = shell;
        }

        internal void AddTags(DiscoveryInfo info, IEnumerable<TagAttribute> classAttributes, IEnumerable<TagAttribute> methodAttributes)
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

        internal List<DiscoveryInfo> AnalyzeAssembly(string path, Assembly assembly)
        {
            this.shell.Trace($"Analyzing assembly: {path}");

            List<DiscoveryInfo> discoveredItems = new List<DiscoveryInfo>();
            if (File.Exists(path))
            {
                if (this.IsAssemblyReferencingTestAssemblies(assembly))
                {
                    this.CreateDiaSession(path);
                    this.pathUnderInvestigation = path;
                    if (assembly != null)
                    {
                        this.shell.Trace(string.Concat("Analyzing assembly: ", path));
                        Type[] types = assembly.GetTypes();
                        foreach (Type type in types)
                        {
                            if (this.IsTestClass(type))
                            {
                                discoveredItems.AddRange(this.AnalyzeType(type));
                            }
                        }
                    }
                }
            }

            int num = discoveredItems.Count;
            this.shell.Trace(string.Concat("----- Finished assembly analyzing. ", num.ToString(), " tests found. -----"));
            return discoveredItems;
        }

        internal DiaNavigationData AnalyzeDiaData(string assemblyPath, string type, string method)
        {
            return this.diaSession.GetNavigationData(type, method);
        }

        internal DiscoveryInfo AnalyzeMethod(Type type, MethodInfo method)
        {
            if (!method.IsPublic)
            {
                return null;
            }

            return !this.IsTestMethod(method) ? null : this.ExtractData(type, method);
        }

        internal List<DiscoveryInfo> AnalyzeType(Type type)
        {
            List<DiscoveryInfo> result = new List<DiscoveryInfo>();
            MethodInfo[] methods = type.GetMethods();
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

        internal void CreateDiaSession(string assemblyPath)
        {
            this.diaSession = new DiaSession(assemblyPath);
        }

        internal DiscoveryInfo ExtractData(Type type, MethodInfo method)
        {
            DiscoveryInfo info = new DiscoveryInfo
            {
                AssemblyFQDN = method.DeclaringType.AssemblyQualifiedName,
                AssemblyPath = this.pathUnderInvestigation,
                AssemblyName = method.Module.Name,
                Namespace = method.DeclaringType.Namespace,
                ClassName = type.Name,
                MethodName = method.Name
            };
            IEnumerable<TagAttribute> tagAttributesClass = type.GetCustomAttributes<TagAttribute>(false);
            IEnumerable<TagAttribute> tagAttributesMethod = method.GetCustomAttributes<TagAttribute>(false);
            this.AddTags(info, tagAttributesClass as TagAttribute[], tagAttributesMethod as TagAttribute[]);
            DiaNavigationData data = this.AnalyzeDiaData(this.pathUnderInvestigation, string.Concat(info.Namespace, ".", type.Name), method.Name);
            if (data == null)
            {
                return info;
            }

            info.LineOfCode = data.MinLineNumber;
            info.ClassFilePath = data.FileName;

            return info;
        }

        private bool IsAssemblyReferencingTestAssemblies(Assembly assembly)
        {
            AssemblyName[] referecedAssemblies = assembly.GetReferencedAssemblies();
            if (referecedAssemblies.Length <= 0)
            {
                return false;
            }

            AssemblyName[] assemblyNameArray = referecedAssemblies;
            int num = 0;
            while (num < assemblyNameArray.Length)
            {
                if (!string.Equals(assemblyNameArray[num].FullName, "Microsoft.VisualStudio.QualityTools.UnitTesting.Silverlight, Version=5.0.5.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", StringComparison.CurrentCultureIgnoreCase))
                {
                    num++;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsTestClass(Type type)
        {
            List<Attribute> classAttributes = type.GetCustomAttributes().ToList();
            if (classAttributes.Any())
            {
                if ((
                    from e in classAttributes
                    where e.GetType().AssemblyQualifiedName == "Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute, Microsoft.VisualStudio.QualityTools.UnitTesting.Silverlight, Version=5.0.5.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
                    select e).Any())
                {
                    return true;
                }
            }

            return false;
        }

        internal bool IsTestMethod(MethodInfo method)
        {
            List<Attribute> testMethodAttributes = method.GetCustomAttributes().ToList();
            if (testMethodAttributes.Any())
            {
                if ((
                    from e in testMethodAttributes
                    where e.GetType().AssemblyQualifiedName == "Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute, Microsoft.VisualStudio.QualityTools.UnitTesting.Silverlight, Version=5.0.5.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
                    select e).Any())
                {
                    return true;
                }
            }

            return false;
        }

        void IDisposable.Dispose()
        {
            this.diaSession?.Dispose();
        }
    }
}