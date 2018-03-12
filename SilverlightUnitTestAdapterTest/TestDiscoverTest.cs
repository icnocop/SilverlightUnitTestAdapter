// <copyright file="TestDiscoverTest.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapterTest
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using SilverlightUnitTestAdapter;

    /// <summary>
    /// Test Discover tests.
    /// </summary>
    [TestClass]
    public class TestDiscoverTest
    {
#if DEBUG
        private const string ConfigurationName = "Debug";
#else
        private const string ConfigurationName = "Release";
#endif

        /// <summary>
        /// Discovers the tests in the silverlight unit test DLL.
        /// </summary>
        [TestMethod]
        public void DiscoverTests_UsingSilverlightUnitTestDll_FindsTests()
        {
            TestDiscoverer discoverer = new TestDiscoverer();

            string thisAssemblyFilePath = Assembly.GetExecutingAssembly().Location;
            string thisAssemblyPath = Path.GetDirectoryName(thisAssemblyFilePath);
            string thisProjectBinPath = Path.GetDirectoryName(thisAssemblyPath);
            string thisProjectPath = Path.GetDirectoryName(thisProjectBinPath);
            string thisSolutionPath = Path.GetDirectoryName(thisProjectPath);
            Assert.IsNotNull(thisSolutionPath);

            string silverlightUnitTestProjectPath = Path.Combine(thisSolutionPath, "SilverlightUnitTest");
            string silverlightUnitTestDllFilePath = Path.Combine(silverlightUnitTestProjectPath, "bin", ConfigurationName, "SilverlightUnitTest.dll");

            Assert.IsTrue(File.Exists(silverlightUnitTestDllFilePath), $"File doesn't exist: {silverlightUnitTestDllFilePath}");

            List<string> testAssemblies = new List<string>
            {
                silverlightUnitTestDllFilePath
            };

            Mock<IDiscoveryContext> mockDiscoveryContext = new Mock<IDiscoveryContext>();
            ConsoleMessageLogger consoleMessageLogger = new ConsoleMessageLogger();

            Mock<ITestCaseDiscoverySink> mockTestCaseDiscoverySink = new Mock<ITestCaseDiscoverySink>();

            List<TestCase> discoveredTestCases = new List<TestCase>();

            mockTestCaseDiscoverySink.Setup(x => x.SendTestCase(It.IsAny<TestCase>())).Callback<TestCase>((testCase) =>
            {
                discoveredTestCases.Add(testCase);
            });

            discoverer.DiscoverTests(
                testAssemblies,
                mockDiscoveryContext.Object,
                consoleMessageLogger,
                mockTestCaseDiscoverySink.Object);

            List<string> expectedTestCaseDisplayNames = new List<string>
            {
                "SilverlightUnitTest.AsyncTest.EnqueueTestComplete_ShouldPass",
                "SilverlightUnitTest.AsyncTest.Assert_Fail_ShouldFail",
                "SilverlightUnitTest.AsyncTest.ReturnTask_ShouldPass",
                "SilverlightUnitTest.AsyncTest.ReturnTask_WithAssertFail_ShouldFail",
                "SilverlightUnitTest.AsyncTest.AwaitTask_ShouldPass",
                "SilverlightUnitTest.AsyncTest.AwaitTask_WithAssertFail_ShouldFail",
                "SilverlightUnitTest.UnitTest1.TestMethod1"
            };

            List<string> discoveredTestCaseNames = discoveredTestCases.Select(x => x.FullyQualifiedName).ToList();
            string message = string.Join(Environment.NewLine, discoveredTestCaseNames);

            CollectionAssert.AreEqual(expectedTestCaseDisplayNames, discoveredTestCaseNames, message);
        }
    }
}
