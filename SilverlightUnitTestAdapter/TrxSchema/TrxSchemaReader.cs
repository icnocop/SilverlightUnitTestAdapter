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
    using SilverlightUnitTestAdapter.Utils;

    internal class TrxSchemaReader
    {
        internal IEnumerable<TestCase> TestCases
        {
            get;
            set;
        }

        private readonly VsShell shell;

        public TrxSchemaReader(VsShell shell, IEnumerable<TestCase> testCases)
        {
            this.shell = shell;
            this.TestCases = testCases;
        }

        internal TestDefinitionType GetDefinitions(TestRunType testRun)
        {
            TestDefinitionType testDefinitionType;
            if (testRun != null)
            {
                TestDefinitionType definition = (
                    from e in (IEnumerable<object>)testRun.Items
                    where e is TestDefinitionType
                    select e).First() as TestDefinitionType;
                if (definition != null)
                {
                    testDefinitionType = definition;
                    return testDefinitionType;
                }
            }

            testDefinitionType = null;
            return testDefinitionType;
        }

        internal ResultsType GetResults(TestRunType testRun)
        {
            ResultsType resultsType;
            if (testRun != null)
            {
                ResultsType result = (
                    from e in (IEnumerable<object>)testRun.Items
                    where e is ResultsType
                    select e).First() as ResultsType;
                if (result != null)
                {
                    resultsType = result;
                    return resultsType;
                }
            }

            resultsType = null;
            return resultsType;
        }

        internal IEnumerable<TrxResult> ProcessStatLightResult(TestRunType testRun)
        {
            IEnumerable<TrxResult> trxResults = new List<TrxResult>();
            TestDefinitionType definition = this.GetDefinitions(testRun);
            ResultsType results = this.GetResults(testRun);
            if (definition == null ? false : results != null)
            {
                if (definition.Items == null ? false : results.Items != null)
                {
                    IEnumerable<UnitTestType> unitTestDefinitions = 
                        from e in (IEnumerable<object>)definition.Items
                        where e is UnitTestType
                        select e as UnitTestType;
                    IEnumerable<UnitTestResultType> items = 
                        from e in (IEnumerable<object>)results.Items
                        where e is UnitTestResultType
                        select e as UnitTestResultType;
                    trxResults = 
                        from e in unitTestDefinitions
                        from f in items
                        from g in this.TestCases
                        where e.id != f.testId ? false : g.FullyQualifiedName == string.Concat(e.TestMethod.className, ".", e.TestMethod.name)
                        select new TrxResult
                        {
                            UnitTest = e,
                            UnitTestResult = f,
                            TestCase = g
                        };
                }
            }

            return trxResults;
        }

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
                        if (fileStreamReader == null ? false : serializer != null)
                        {
                            testRun = (TestRunType)serializer.Deserialize(fileStreamReader);
                        }
                    }
                    finally
                    {
                        if (fileStreamReader != null)
                        {
                            ((IDisposable)fileStreamReader).Dispose();
                        }
                    }
                }
                catch (Exception exception)
                {
                    this.shell.Trace(string.Concat(Localized.ErrorOnDeserializeTrxFile, trxFilePath));
                    testRunType = testRun;
                    return testRunType;
                }
            }

            testRunType = testRun;
            return testRunType;
        }
    }
}