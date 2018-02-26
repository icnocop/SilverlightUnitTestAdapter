// <copyright file="AssemblyLoader.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Assemblies
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Security.Policy;
    using SilverlightUnitTestAdapter.Utils;

    internal class AssemblyLoader : IDisposable
    {
        private AppDomain appDomain;

        private ProxyLoader proxyDomain;

        private VsShell shell;

        public AssemblyLoader(VsShell shell)
        {
            this.shell = shell;
            this.appDomain = this.CreateChildDomain();
            this.proxyDomain = this.appDomain.CreateInstanceAndUnwrap(
                Assembly.GetAssembly(typeof(ProxyLoader)).FullName,
                typeof(ProxyLoader).ToString()) as ProxyLoader;
        }

        public void Initialize(string source)
        {
            this.proxyDomain.Initialize(source);
        }

        public void Dispose()
        {
            if (this.proxyDomain != null)
            {
                this.proxyDomain.Dispose();
                this.proxyDomain = null;
            }

            if (this.appDomain != null)
            {
                AppDomain.Unload(this.appDomain);
            }
        }

        public List<DiscoveryInfo> Load(string path)
        {
            List<DiscoveryInfo> discoveryInfos = null;
            FileInfo fi = new FileInfo(path);
            if (fi.Exists)
            {
                discoveryInfos = this.proxyDomain.Load(fi.FullName);
            }

            return discoveryInfos;
        }

        public Assembly LoadReference(string path)
        {
            Assembly assembly = null;
            FileInfo fi = new FileInfo(path);
            if (fi.Exists)
            {
                assembly = this.proxyDomain.LoadReference(fi.FullName);
            }

            return assembly;
        }

        private AppDomain CreateChildDomain()
        {
            Evidence evidence = new Evidence(AppDomain.CurrentDomain.Evidence);
            AppDomainSetup setup = new AppDomainSetup
            {
                ApplicationBase = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
            };

            this.appDomain = AppDomain.CreateDomain("SomeAppDomain", evidence, setup);
            return this.appDomain;
        }
    }
}