// <copyright file="ProxyLoader.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Assemblies
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using SilverlightUnitTestAdapter.Helpers;

    /// <summary>
    /// Proxy Loader.
    /// </summary>
    /// <seealso cref="System.MarshalByRefObject" />
    /// <seealso cref="System.IDisposable" />
    internal class ProxyLoader : MarshalByRefObject, IDisposable
    {
        private AssemblyAnalyzer assemblyAnalyzer;

        private string sourcePath;
        private HashSet<string> probingPaths;
        private List<string> resolvingAssemblies = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyLoader"/> class.
        /// </summary>
        public ProxyLoader()
        {
            AppDomain.CurrentDomain.AssemblyResolve += this.OnAssemblyResolve;
        }

        /// <summary>
        /// Initializes the private fields of this instance.
        /// </summary>
        /// <param name="source">The source.</param>
        public void Initialize(string source)
        {
            this.sourcePath = Path.GetDirectoryName(source);
            this.probingPaths = new HashSet<string>
            {
                this.sourcePath,
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                FrameworkHelper.Silverlight5AssemblyPath
            };

            Assembly entryAssembly = Assembly.GetEntryAssembly();
            if (entryAssembly != null)
            {
                this.probingPaths.Add(Path.GetDirectoryName(entryAssembly.Location));
            }

            Assembly callingAssembly = Assembly.GetCallingAssembly();
            if (callingAssembly != null)
            {
                this.probingPaths.Add(Path.GetDirectoryName(callingAssembly.Location));
            }

            string applicationConfigurationFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            this.probingPaths.Add(Path.GetDirectoryName(applicationConfigurationFile));

            this.assemblyAnalyzer = new AssemblyAnalyzer();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.assemblyAnalyzer?.Dispose();

            AppDomain.CurrentDomain.AssemblyResolve -= this.OnAssemblyResolve;
        }

        /// <summary>
        /// Loads the specified assembly path.
        /// </summary>
        /// <param name="assemblyPath">The assembly path.</param>
        /// <returns>The discovery information.</returns>
        public List<DiscoveryInfo> Load(string assemblyPath)
        {
            List<DiscoveryInfo> discoveryInfos = new List<DiscoveryInfo>();

            try
            {
                Assembly assembly = Assembly.LoadFrom(assemblyPath);

                discoveryInfos = this.assemblyAnalyzer.AnalyzeAssembly(assemblyPath, assembly);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }

            return discoveryInfos;
        }

        private Assembly OnAssemblyResolve(object sender, ResolveEventArgs args)
        {
            if (this.resolvingAssemblies.Contains(args.Name))
            {
                // do not recursively try to resolve the assembly
                return null;
            }

            Trace.WriteLine(string.Concat("Resolving reference: ", args.Name));

            this.resolvingAssemblies.Add(args.Name);

            AssemblyName assemblyName = new AssemblyName(args.Name);
            string fileName = $"{assemblyName.Name}.dll";

            foreach (string probingPath in this.probingPaths)
            {
                string filePath = Path.Combine(probingPath, fileName);

                if (!File.Exists(filePath))
                {
                    continue;
                }

                try
                {
                    return Assembly.LoadFile(filePath);
                }
                catch (Exception ex)
                {
                    Trace.WriteLine($"Failed to load file '{filePath}'.{Environment.NewLine}{ex}");
                }
            }

            return null;
        }
    }
}