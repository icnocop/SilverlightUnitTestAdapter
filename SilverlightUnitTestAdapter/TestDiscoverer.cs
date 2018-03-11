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

            try
            {
                foreach (string source in sources)
                {
                    List<DiscoveryInfo> discoveryResult;

                    using (AssemblyLoader loader = new AssemblyLoader(logger))
                    {
                        try
                        {
                            loader.Initialize(source);
                            logger.SendMessage(TestMessageLevel.Informational, string.Concat(Localized.LoadingAndAnalyzingAssembly, source));
                            discoveryResult = loader.Load(source);
                        }
                        catch (Exception ex)
                        {
                            logger.SendMessage(TestMessageLevel.Error, ex.ToString());
                            continue;
                        }
                    }

                    logger.SendMessage(TestMessageLevel.Informational, string.Concat(Localized.ProcessingAssembly, discoveryResult.Count));
                    foreach (DiscoveryInfo discoveryResultItem in discoveryResult)
                    {
                        TestCase testCase = new TestCase(
                            discoveryResultItem.GetFullMethodPath(),
                            new Uri(Constants.ExecutorUri),
                            source)
                        {
                            DisplayName = discoveryResultItem.MethodName,
                            CodeFilePath = discoveryResultItem.ClassFilePath,
                            LineNumber = discoveryResultItem.LineOfCode
                        };
                        discoverySink.SendTestCase(testCase);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.SendMessage(TestMessageLevel.Error, $"Message: {ex.Message}");
                logger.SendMessage(TestMessageLevel.Error, ex.ToString());
            }
        }
    }
}