// <copyright file="ProxyLoader.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Assemblies
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using SilverlightUnitTestAdapter.Utils;

    internal class ProxyLoader : MarshalByRefObject, IDisposable
    {
        private readonly AssemblyAnalyzer assemblyAnalyzer;

        private readonly VsShell shell;

        private string sourcePath;

        public ProxyLoader()
        {
            this.shell = new VsShell();
            this.assemblyAnalyzer = new AssemblyAnalyzer(this.shell);
            AppDomain.CurrentDomain.AssemblyResolve += this.CurrentDomain_AssemblyResolve;
        }

        public void Initialize(string source)
        {
            this.sourcePath = Path.GetDirectoryName(source);
            this.shell.Initialize();
        }

        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            this.shell.Trace(string.Concat("Resolving reference: ", args.Name));
            AssemblyName assemblyName = new AssemblyName(args.Name);
            string fileName = $"{assemblyName.Name}.dll";

            string filePath = Path.Combine(this.sourcePath, fileName);
            if (!File.Exists(filePath))
            {
                filePath = Path.Combine(FrameworkHelper.Instance.Silverlight5AssemblyPath, fileName);
            }

            Assembly assembly = Assembly.LoadFile(filePath);
            return assembly;
        }

        public void Dispose()
        {
            AppDomain.CurrentDomain.AssemblyResolve -= this.CurrentDomain_AssemblyResolve;
        }

        public List<DiscoveryInfo> Load(string assemblyPath)
        {
            List<DiscoveryInfo> discoveryInfos = null;
            try
            {
                Assembly assembly = Assembly.LoadFrom(assemblyPath);
                discoveryInfos = this.assemblyAnalyzer.AnalyzeAssembly(assemblyPath, assembly);
                return discoveryInfos;
            }
            catch (Exception ex)
            {
                this.shell.Trace(ex.ToString());
                return discoveryInfos;
            }
        }

        internal Assembly LoadAlternative(string name)
        {
            Assembly assembly;
            try
            {
                AssemblyName assemblyName;
                try
                {
                    assemblyName = AssemblyName.GetAssemblyName(name);
                }
                catch (ArgumentException)
                {
                    assemblyName = new AssemblyName
                    {
                        CodeBase = name
                    };
                }

                assembly = Assembly.Load(assemblyName);
            }
            catch (Exception)
            {
                try
                {
                    string assembly4Path = string.Empty;
                    string assembly5Path = Path.Combine(FrameworkHelper.Instance.Silverlight5AssemblyPath, string.Concat(new AssemblyName(name).Name, ".dll"));
                    if (File.Exists(assembly4Path))
                    {
                        assembly = Assembly.LoadFrom(assembly4Path);
                        return assembly;
                    }

                    if (File.Exists(assembly5Path))
                    {
                        assembly = Assembly.LoadFrom(assembly5Path);
                        return assembly;
                    }

                    return null;
                }
                catch (Exception exception)
                {
                    this.shell.Trace(exception.ToString());
                }

                return null;
            }

            return assembly;
        }

        public Assembly LoadReference(string assemblyPath)
        {
            Assembly assembly;
            try
            {
                assembly = !File.Exists(assemblyPath) ? Assembly.Load(assemblyPath) : Assembly.LoadFrom(assemblyPath);
            }
            catch (Exception)
            {
                assembly = this.LoadAlternative(assemblyPath);
            }

            return assembly;
        }
    }
}