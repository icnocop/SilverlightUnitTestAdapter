// <copyright file="TrxSchemaReader.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.TrxSchema
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
    using SilverlightUnitTestAdapter.VSTS;

    /// <summary>
    /// TRX Schema Reader.
    /// </summary>
    internal class TrxSchemaReader
    {
        private readonly IMessageLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="TrxSchemaReader" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="testCases">The test cases.</param>
        public TrxSchemaReader(IMessageLogger logger, IEnumerable<TestCase> testCases)
        {
            this.logger = logger;
            this.TestCases = testCases;
        }

        /// <summary>
        /// Gets or sets the test cases.
        /// </summary>
        /// <value>The test cases.</value>
        internal IEnumerable<TestCase> TestCases { get; set; }

        /// <summary>
        /// Gets the definitions.
        /// </summary>
        /// <param name="testRun">The test run.</param>
        /// <returns>The test definitions.</returns>
        internal static TestDefinitionType GetDefinitions(TestRunType testRun)
        {
            if (testRun == null)
            {
                return null;
            }

            return (
                from e in testRun.Items
                where e is TestDefinitionType
                select e).First() as TestDefinitionType;
        }

        /// <summary>
        /// Gets the test results.
        /// </summary>
        /// <param name="testRun">The test run.</param>
        /// <returns>The test results.</returns>
        internal static ResultsType GetResults(TestRunType testRun)
        {
            if (testRun == null)
            {
                return null;
            }

            return (
                from e in testRun.Items
                where e is ResultsType
                select e).First() as ResultsType;
        }

        /// <summary>
        /// Processes the StatLight result.
        /// </summary>
        /// <param name="testRun">The test run.</param>
        /// <returns>The test results.</returns>
        internal IEnumerable<TrxResult> ProcessStatLightResult(TestRunType testRun)
        {
            IEnumerable<TrxResult> trxResults = new List<TrxResult>();
            TestDefinitionType definition = GetDefinitions(testRun);
            ResultsType results = GetResults(testRun);
            if (definition == null || results == null)
            {
                return trxResults;
            }

            if (definition.Items == null || results.Items == null)
            {
                return trxResults;
            }

            IEnumerable<UnitTestType> unitTestDefinitions = definition.Items.OfType<UnitTestType>();
            IEnumerable<UnitTestResultType> items = results.Items.OfType<UnitTestResultType>();
            trxResults =
                from e in unitTestDefinitions
                from f in items
                from g in this.TestCases
                where e.id == f.testId && g.FullyQualifiedName == string.Concat(e.TestMethod.className, ".", e.TestMethod.name)
                select new TrxResult
                {
                    UnitTest = e,
                    UnitTestResult = f,
                    TestCase = g
                };

            return trxResults;
        }

        /// <summary>
        /// Reads the specified TRX file path.
        /// </summary>
        /// <param name="trxFilePath">The TRX file path.</param>
        /// <returns>The test run.</returns>
        internal TestRunType Read(string trxFilePath)
        {
            TestRunType testRunType;
            TestRunType testRun = null;
            if (File.Exists(trxFilePath))
            {
                try
                {
                    StreamReader fileStreamReader = new StreamReader(trxFilePath);
                    try
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(TestRunType));
                        testRun = (TestRunType)serializer.Deserialize(fileStreamReader);
                    }
                    finally
                    {
                        fileStreamReader.Dispose();
                    }
                }
                catch (Exception exception)
                {
                    this.logger.SendMessage(TestMessageLevel.Error, string.Concat(Localized.ErrorOnDeserializeTrxFile, trxFilePath));
                    this.logger.SendMessage(TestMessageLevel.Error, exception.ToString());
                    testRunType = testRun;
                    return testRunType;
                }
            }

            testRunType = testRun;
            return testRunType;
        }
    }
}