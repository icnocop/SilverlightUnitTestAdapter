// <copyright file="StatLightWrapper.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.StatLight
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using Configuration;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
    using SilverlightUnitTestAdapter.Helpers;
    using SilverlightUnitTestAdapter.TrxSchema;
    using VSTS;

    /// <summary>
    /// StatLight Wrapper.
    /// </summary>
    internal class StatLightWrapper
    {
        private readonly VsShell shell;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatLightWrapper"/> class.
        /// </summary>
        /// <param name="shell">The shell.</param>
        public StatLightWrapper(VsShell shell)
        {
            this.shell = shell;
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
            if (testMethodsInAssemblies != null && testMethodsInAssemblies.Count > 0)
            {
                foreach (string assembly in testMethodsInAssemblies.Keys)
                {
                    StringBuilder argument = new StringBuilder();
                    argument.Append("-d=");
                    argument.Append(string.Concat("\"", assembly, "\""));
                    argument.Append(" --MethodsToTest=");
                    argument.Append("\"");
                    for (int i = 0; i < testMethodsInAssemblies[assembly].Count; i++)
                    {
                        argument.Append(testMethodsInAssemblies[assembly][i].FullyQualifiedName);
                        if (i != testMethodsInAssemblies[assembly].Count - 1)
                        {
                            argument.Append(";");
                        }
                    }

                    argument.Append("\"");

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
                            argument.Append(" --QueryString=");
                            argument.Append("\"");

                            int i = 0;
                            foreach (KeyValuePair<string, string> keyValuePair in settings.QueryString)
                            {
                                argument.Append($"{keyValuePair.Key}={keyValuePair.Value}");

                                if (i < settings.QueryString.Count - 1)
                                {
                                    argument.Append("&");
                                }

                                i++;
                            }

                            argument.Append("\"");
                        }
                    }

                    TestCaseArgument argumentInfo = new TestCaseArgument(argument.ToString(), assembly, testMethodsInAssemblies[assembly]);
                    arguments.Add(argumentInfo);
                }
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

            using (Process process = new Process())
            {
                process.StartInfo.FileName = Path.Combine(currentAssemblyPath, "StatLight.exe");
                process.StartInfo.Arguments = arguments.GetArguments();
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                this.shell.Trace($"\"{process.StartInfo.FileName}\" {process.StartInfo.Arguments}");

                process.Start();

                var reader = this.ConsumeReader(process.StandardOutput);
                reader = this.ConsumeReader(process.StandardError);

                process.WaitForExit();

                this.shell.Trace(string.Concat(Localized.StatLightExitCodeMessage, process.ExitCode));
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
            TrxSchemaReader reader = new TrxSchemaReader(this.shell, tests);
            TestRunType testRun = reader.Read(argument.TestResultPath);
            if (testRun != null)
            {
                foreach (TrxResult result in reader.ProcessStatLightResult(testRun))
                {
                    TestResult testResult = result.GetTestResult(this.shell);
                    frameworkHandle.RecordResult(testResult);
                    frameworkHandle.RecordEnd(result.TestCase, testResult.Outcome);
                }
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
                this.shell.Trace(text);
            }
        }
    }
}