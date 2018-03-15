// <copyright file="StatLightWrapper.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.StatLight
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web;
    using Configuration;
    using global::StatLight.Core;
    using global::StatLight.Core.Common;
    using global::StatLight.Core.Configuration;
    using global::StatLight.Core.Reporting;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
    using SilverlightUnitTestAdapter.TrxSchema;
    using VSTS;

    /// <summary>
    /// StatLight Wrapper.
    /// </summary>
    internal class StatLightWrapper
    {
        private readonly IMessageLogger logger;
        private readonly bool isBeingDebugged;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatLightWrapper" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="isBeingDebugged">if set to <c>true</c> is being debugged.</param>
        public StatLightWrapper(IMessageLogger logger, bool isBeingDebugged)
        {
            this.logger = logger;
            this.isBeingDebugged = isBeingDebugged;
        }

        /// <summary>
        /// Gets the test methods by assembly.
        /// </summary>
        /// <param name="testCases">The test cases.</param>
        /// <returns>Dictionary&lt;System.String, List&lt;TestCase&gt;&gt;.</returns>
        internal static Dictionary<string, List<TestCase>> GetTestMethodsByAssembly(IEnumerable<TestCase> testCases)
        {
            Dictionary<string, List<TestCase>> testMethodsInAssemblies = new Dictionary<string, List<TestCase>>();
            foreach (TestCase testCase in testCases)
            {
                if (!testMethodsInAssemblies.ContainsKey(testCase.Source))
                {
                    testMethodsInAssemblies.Add(
                        testCase.Source,
                        new List<TestCase> { testCase });
                }
                else
                {
                    testMethodsInAssemblies[testCase.Source].Add(testCase);
                }
            }

            return testMethodsInAssemblies;
        }

        /// <summary>
        /// Records the start tests.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="frameworkHandle">The framework handle.</param>
        internal static void RecordStartTests(TestCaseArgument argument, IFrameworkHandle frameworkHandle)
        {
            foreach (TestCase testCase in argument.TestCases)
            {
                frameworkHandle.RecordStart(testCase);
            }
        }

        /// <summary>
        /// Gets the StatLight arguments.
        /// </summary>
        /// <param name="testCases">The test cases.</param>
        /// <returns>List&lt;TestCaseArgument&gt;.</returns>
        internal static List<TestCaseArgument> GetArguments(IEnumerable<TestCase> testCases)
        {
            List<TestCaseArgument> arguments = new List<TestCaseArgument>();
            Dictionary<string, List<TestCase>> testMethodsInAssemblies = GetTestMethodsByAssembly(testCases);
            if (testMethodsInAssemblies == null || testMethodsInAssemblies.Count <= 0)
            {
                return arguments;
            }

            foreach (string assembly in testMethodsInAssemblies.Keys)
            {
                TestRunOptions testRunOptions = new TestRunOptions
                {
                    DllPath = assembly,
                    MethodsToTest = testMethodsInAssemblies[assembly].Select(m => m.FullyQualifiedName).ToList(),
                    ReportOutputFileType = ReportOutputFileType.TRX,
                    ReportOutputPath = string.Concat(assembly, "_TestResult.xml")
                };

                string assemblyPath = Path.GetDirectoryName(assembly);
                if (assemblyPath == null)
                {
                    throw new Exception($"Failed to get directory name for assembly location: {assembly}");
                }

                string configurationFilePath = Path.Combine(assemblyPath, SilverlightUnitTestAdapter.Constants.ConfigurationFileName);
                if (File.Exists(configurationFilePath))
                {
                    Settings settings = Settings.Load(configurationFilePath);
                    if (settings.QueryString != null && settings.QueryString.Count > 0)
                    {
                        NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(string.Empty);

                        foreach (KeyValuePair<string, string> keyValuePair in settings.QueryString)
                        {
                            nameValueCollection.Add(keyValuePair.Key, keyValuePair.Value);
                        }

                        testRunOptions.QueryString = nameValueCollection.ToString();
                    }

                    if (settings.UnitTestProvider != UnitTestProviderType.Undefined)
                    {
                        testRunOptions.UnitTestProviderType = settings.UnitTestProvider;
                    }

                    testRunOptions.Debug = settings.Debug;
                }

                TestCaseArgument argumentInfo = new TestCaseArgument(testRunOptions, testMethodsInAssemblies[assembly]);
                arguments.Add(argumentInfo);
            }

            return arguments;
        }

        /// <summary>
        /// Executes StatLight with the specified arguments.
        /// </summary>
        /// <param name="arguments">The arguments.</param>
        internal void ExecuteStatLight(TestCaseArgument arguments)
        {
            string executingAssemblyLocation = Assembly.GetExecutingAssembly().Location;
            string currentAssemblyPath = Path.GetDirectoryName(executingAssemblyLocation);
            if (currentAssemblyPath == null)
            {
                throw new Exception($"Failed to get directory name for executing assembly location: {executingAssemblyLocation}");
            }

            if (this.isBeingDebugged)
            {
                TestRunOptions testRunOptions = arguments.TestRunOptions;
                ILogger consoleLogger = new ConsoleLogger(LogChatterLevels.Full);

                InputOptions inputOptions = new InputOptions()
                    .SetDllPaths(new[] { testRunOptions.DllPath })
                    .SetMethodsToTest(testRunOptions.MethodsToTest)
                    .SetReportOutputFileType(testRunOptions.ReportOutputFileType)
                    .SetReportOutputPath(testRunOptions.ReportOutputPath)
                    .SetIsRequestingDebug(testRunOptions.Debug);

                if (!string.IsNullOrEmpty(testRunOptions.QueryString))
                {
                    inputOptions.SetQueryString(testRunOptions.QueryString);
                }

                if (testRunOptions.UnitTestProviderType != UnitTestProviderType.Undefined)
                {
                    inputOptions.SetUnitTestProviderType(testRunOptions.UnitTestProviderType);
                }

                RunnerExecutionEngine commandLineExecutionEngine = BootStrapper
                    .Initialize(inputOptions, consoleLogger)
                    .Resolve<RunnerExecutionEngine>();

                commandLineExecutionEngine.Run();
            }
            else
            {
                // run statlight on the command line so that messages sent to the Console within the unit test are written to the Test output window
                string testAssembly = arguments.TestRunOptions.DllPath;

                StringBuilder argument = new StringBuilder();
                argument.Append("-d=");
                argument.Append(string.Concat("\"", testAssembly, "\""));
                argument.Append(" --MethodsToTest=");
                argument.Append("\"");
                for (int i = 0; i < arguments.TestRunOptions.MethodsToTest.Count; i++)
                {
                    argument.Append(arguments.TestRunOptions.MethodsToTest.ElementAt(i));
                    if (i != arguments.TestRunOptions.MethodsToTest.Count - 1)
                    {
                        argument.Append(";");
                    }
                }

                argument.Append("\"");

                string assemblyPath = Path.GetDirectoryName(testAssembly);
                if (assemblyPath == null)
                {
                    throw new Exception($"Failed to get directory name for assembly location: {testAssembly}");
                }

                string configurationFilePath = Path.Combine(assemblyPath, SilverlightUnitTestAdapter.Constants.ConfigurationFileName);
                if (File.Exists(configurationFilePath))
                {
                    Settings settings = Settings.Load(configurationFilePath);
                    if (settings.QueryString != null && settings.QueryString.Count > 0)
                    {
                        argument.Append(" --QueryString=");
                        argument.Append("\"");

                        NameValueCollection queryString = HttpUtility.ParseQueryString(string.Empty);

                        foreach (KeyValuePair<string, string> keyValuePair in settings.QueryString)
                        {
                            queryString.Add(keyValuePair.Key, keyValuePair.Value);
                        }

                        argument.Append(queryString.ToString());

                        argument.Append("\"");
                    }

                    if (settings.UnitTestProvider != UnitTestProviderType.Undefined)
                    {
                        argument.Append($" --OverrideTestProvider:{settings.UnitTestProvider}");
                    }

                    if (settings.Debug)
                    {
                        argument.Append(" --debug");
                    }
                }

                argument.Append(" -r=");
                argument.Append(string.Concat("\"", arguments.TestRunOptions.ReportOutputPath));
                argument.Append("\"");
                argument.Append(" --ReportOutputFileType:");
                argument.Append("\"TRX");
                argument.Append("\"");

                using (Process process = new Process())
                {
                    process.StartInfo.FileName = Path.Combine(currentAssemblyPath, "StatLight.exe");
                    process.StartInfo.Arguments = argument.ToString();
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    this.logger.SendMessage(TestMessageLevel.Informational, $"\"{process.StartInfo.FileName}\" {process.StartInfo.Arguments}");

                    process.Start();

                    var outputReader = this.ConsumeReader(process.StandardOutput);
                    var errorReader = this.ConsumeReader(process.StandardError);

                    process.WaitForExit();
                    outputReader.Wait();
                    errorReader.Wait();

                    this.logger.SendMessage(TestMessageLevel.Informational, string.Concat(Localized.StatLightExitCodeMessage, process.ExitCode));
                }
            }
        }

        /// <summary>
        /// Processes the results.
        /// </summary>
        /// <param name="tests">The tests.</param>
        /// <param name="argument">The argument.</param>
        /// <param name="frameworkHandle">The framework handle.</param>
        internal void ProcessResults(IEnumerable<TestCase> tests, TestCaseArgument argument, IFrameworkHandle frameworkHandle)
        {
            TrxSchemaReader reader = new TrxSchemaReader(this.logger, tests);
            TestRunType testRun = reader.Read(argument.TestRunOptions.ReportOutputPath);
            if (testRun == null)
            {
                return;
            }

            foreach (TrxResult result in reader.ProcessStatLightResult(testRun))
            {
                TestResult testResult = result.GetTestResult(this.logger);
                frameworkHandle.RecordResult(testResult);
                frameworkHandle.RecordEnd(result.TestCase, testResult.Outcome);
            }
        }

        /// <summary>
        /// Runs the tests.
        /// </summary>
        /// <param name="testCases">The test cases.</param>
        /// <param name="frameworkHandle">The framework handle.</param>
        internal void RunTests(IEnumerable<TestCase> testCases, IFrameworkHandle frameworkHandle)
        {
            foreach (TestCaseArgument argument in GetArguments(testCases))
            {
                RecordStartTests(argument, frameworkHandle);
                this.ExecuteStatLight(argument);
                this.ProcessResults(argument.TestCases, argument, frameworkHandle);
            }
        }

        private async Task ConsumeReader(TextReader reader)
        {
            string text;

            while ((text = await reader.ReadLineAsync()) != null)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    this.logger.SendMessage(TestMessageLevel.Informational, text);
                }
            }
        }
    }
}