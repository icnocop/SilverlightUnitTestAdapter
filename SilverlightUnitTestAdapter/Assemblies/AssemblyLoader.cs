// <copyright file="AssemblyLoader.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Assemblies
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using Helpers;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
    using StatLight;

    /// <summary>
    /// Assembly Loader.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    internal class AssemblyLoader : IDisposable
    {
        private readonly TextWriterLogger textWriter;

        private readonly DelegateTraceListener delegateTraceListener;

        private AppDomainHelper appDomainHelper;

        private ProxyLoader proxyDomain;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyLoader" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public AssemblyLoader(IMessageLogger logger)
        {
            this.textWriter = new TextWriterLogger(logger);

            this.appDomainHelper = new AppDomainHelper();

            this.delegateTraceListener = new DelegateTraceListener(
                    message => logger.SendMessage(TestMessageLevel.Informational, message));

            this.proxyDomain = this.appDomainHelper.CreateInstance<ProxyLoader>();
        }

        /// <summary>
        /// Initializes the proxy domain loader.
        /// </summary>
        /// <param name="source">The source.</param>
        public void Initialize(string source)
        {
            this.proxyDomain.Initialize(source);

            Trace.Listeners.Add(this.delegateTraceListener);

            CrossDomainTraceHelper.StartListening(this.appDomainHelper.AppDomain, this.textWriter);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (this.textWriter != null)
            {
                this.textWriter.Flush();
                this.textWriter.Dispose();
            }

            if (this.proxyDomain != null)
            {
                this.proxyDomain.Dispose();
                this.proxyDomain = null;
            }

            if (this.delegateTraceListener != null)
            {
                if (Trace.Listeners.Contains(this.delegateTraceListener))
                {
                    Trace.Listeners.Remove(this.delegateTraceListener);
                }
            }

            if (this.appDomainHelper != null)
            {
                this.appDomainHelper.Dispose();
                this.appDomainHelper = null;
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
    }
}