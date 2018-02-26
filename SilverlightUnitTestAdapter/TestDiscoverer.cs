// <copyright file="TestDiscoverer.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
    using SilverlightUnitTestAdapter.Assemblies;
    using SilverlightUnitTestAdapter.Utils;

    [DefaultExecutorUri("executor://statlighttestadapter/v1")]
    [FileExtension(".dll")]
    public class TestDiscoverer : ITestDiscoverer
    {
        public void DiscoverTests(IEnumerable<string> sources, IDiscoveryContext discoveryContext, IMessageLogger logger, ITestCaseDiscoverySink discoverySink)
        {
            VsShell shell = new VsShell(logger);
            shell.Initialize();

            try
            {
                foreach (string source in sources)
                {
                    List<DiscoveryInfo> discoveryResult = new List<DiscoveryInfo>();
                    AssemblyLoader loader = new AssemblyLoader(shell);
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
                    finally
                    {
                        if (loader != null)
                        {
                            ((IDisposable)loader).Dispose();
                        }
                    }

                    if (discoveryResult == null)
                    {
                        discoveryResult = new List<DiscoveryInfo>();
                    }

                    shell.Trace(string.Concat(Localized.ProcessingAssembly, discoveryResult.Count));
                    foreach (DiscoveryInfo discoveryResultItem in discoveryResult)
                    {
                        TestCase testCase = new TestCase(discoveryResultItem.GetFullMethodPath(), new Uri("executor://statlighttestadapter/v1"), source);
                        testCase.DisplayName = discoveryResultItem.GetFullMethodPath();
                        testCase.CodeFilePath = discoveryResultItem.ClassFilePath;
                        testCase.LineNumber = discoveryResultItem.LineOfCode;
                        discoverySink.SendTestCase(testCase);
                    }
                }
            }
            catch (Exception ex)
            {
                shell.Trace(ex.ToString());
            }
        }
    }
}