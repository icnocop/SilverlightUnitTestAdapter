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

    /// <summary>
    /// Assembly Loader.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    internal class AssemblyLoader : IDisposable
    {
        private AppDomain appDomain;

        private ProxyLoader proxyDomain;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyLoader"/> class.
        /// </summary>
        public AssemblyLoader()
        {
            this.appDomain = this.CreateChildDomain();
            this.proxyDomain = this.appDomain.CreateInstanceAndUnwrap(
                Assembly.GetAssembly(typeof(ProxyLoader)).FullName,
                typeof(ProxyLoader).ToString()) as ProxyLoader;
        }

        /// <summary>
        /// Initializes the proxy domain loader.
        /// </summary>
        /// <param name="source">The source.</param>
        public void Initialize(string source)
        {
            this.proxyDomain.Initialize(source);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
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

        /// <summary>
        /// Loads the specified file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>The discovery information.</returns>
        public List<DiscoveryInfo> Load(string filePath)
        {
            List<DiscoveryInfo> discoveryInfos = new List<DiscoveryInfo>();
            FileInfo fi = new FileInfo(filePath);
            if (fi.Exists)
            {
                discoveryInfos = this.proxyDomain.Load(fi.FullName);
            }

            return discoveryInfos;
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