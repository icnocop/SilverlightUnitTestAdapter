// <copyright file="TestDiscoverer.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
    using SilverlightUnitTestAdapter.Assemblies;
    using SilverlightUnitTestAdapter.Helpers;

    /// <summary>
    /// Test Discoverer.
    /// </summary>
    /// <seealso cref="Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.ITestDiscoverer" />
    [DefaultExecutorUri(Constants.ExecutorUri)]
    [FileExtension(".dll")]
    public class TestDiscoverer : ITestDiscoverer
    {
        /// <summary>
        /// Discovers the tests.
        /// </summary>
        /// <param name="sources">The sources.</param>
        /// <param name="discoveryContext">The discovery context.</param>
        /// <param name="logger">The logger.</param>
        /// <param name="discoverySink">The discovery sink.</param>
        public void DiscoverTests(IEnumerable<string> sources, IDiscoveryContext discoveryContext, IMessageLogger logger, ITestCaseDiscoverySink discoverySink)
        {
            if (sources == null)
            {
                throw new ArgumentNullException(nameof(sources));
            }

            if (discoverySink == null)
            {
                throw new ArgumentNullException(nameof(discoverySink));
            }

            VsShell shell = new VsShell(logger);

            try
            {
                // Register the IOleMessageFilter to handle any threading errors.
                MessageFilter.Register();

                shell.Initialize(true);

                foreach (string source in sources)
                {
                    List<DiscoveryInfo> discoveryResult;

                    using (AssemblyLoader loader = new AssemblyLoader())
                    {
                        try
                        {
                            loader.Initialize(source);
                            shell.Trace(string.Concat(Localized.LoadingAndAnalyzingAssembly, source));
                            discoveryResult = loader.Load(source);
                        }
                        catch (Exception ex)
                        {
                            shell.Trace(ex.ToString());
                            continue;
                        }
                    }

                    shell.Trace(string.Concat(Localized.ProcessingAssembly, discoveryResult.Count));
                    foreach (DiscoveryInfo discoveryResultItem in discoveryResult)
                    {
                        TestCase testCase = new TestCase(
                            discoveryResultItem.GetFullMethodPath(),
                            new Uri(Constants.ExecutorUri),
                            source)
                        {
                            DisplayName = discoveryResultItem.GetFullMethodPath(),
                            CodeFilePath = discoveryResultItem.ClassFilePath,
                            LineNumber = discoveryResultItem.LineOfCode
                        };
                        discoverySink.SendTestCase(testCase);
                    }
                }
            }
            catch (Exception ex)
            {
                shell.Trace($"Message: {ex.Message}");
                shell.Trace(ex.ToString());
            }
            finally
            {
                // and turn off the IOleMessageFilter.
                MessageFilter.Revoke();
            }
        }
    }
}