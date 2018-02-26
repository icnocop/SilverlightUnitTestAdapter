// <copyright file="StatLightWrapper.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.StatLight
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading;
    using Configuration;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
    using SilverlightUnitTestAdapter.TrxSchema;
    using SilverlightUnitTestAdapter.Utils;

    internal class StatLightWrapper
    {
        internal bool isInstalled;

        private readonly VsShell shell;

        public StatLightWrapper(VsShell shell)
        {
            this.shell = shell;
        }

        internal void ExecuteStatLight(TestCaseArgument arguments)
        {
            int timeout = 60000;
            Process process = new Process();
            try
            {
                string currentAssemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                process.StartInfo.FileName = Path.Combine(currentAssemblyPath, "StatLight.exe");
                process.StartInfo.Arguments = arguments.GetArguments();
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                StringBuilder stringBuilder = new StringBuilder();
                StringBuilder stringBuilder1 = new StringBuilder();
                AutoResetEvent autoResetEvent = new AutoResetEvent(false);
                try
                {
                    AutoResetEvent autoResetEvent1 = new AutoResetEvent(false);
                    try
                    {
                        process.OutputDataReceived += (sender, e) => {
                            if (e.Data != null)
                            {
                                stringBuilder.AppendLine(e.Data);
                                this.shell.Trace(e.Data);
                            }
                            else
                            {
                                autoResetEvent.Set();
                            }
                        };
                        process.ErrorDataReceived += (sender, e) => {
                            if (e.Data != null)
                            {
                                stringBuilder1.AppendLine(e.Data);
                                this.shell.Trace(e.Data);
                            }
                            else
                            {
                                autoResetEvent1.Set();
                            }
                        };

                        this.shell.Trace($"\"{process.StartInfo.FileName}\" {process.StartInfo.Arguments}");

                        process.Start();
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();
                        if (!process.WaitForExit(timeout) || !autoResetEvent.WaitOne(timeout) ? true : !autoResetEvent1.WaitOne(timeout))
                        {
                            autoResetEvent.Set();
                            autoResetEvent1.Set();
                            this.shell.Trace(Localized.StatLightTimedOut);
                        }
                        else
                        {
                            this.shell.Trace(string.Concat(Localized.StatLightExitCodeMessage, process.ExitCode));
                        }
                    }
                    finally
                    {
                        if (autoResetEvent1 != null)
                        {
                            ((IDisposable)autoResetEvent1).Dispose();
                        }
                    }
                }
                finally
                {
                    if (autoResetEvent != null)
                    {
                        ((IDisposable)autoResetEvent).Dispose();
                    }
                }
            }
            finally
            {
                if (process != null)
                {
                    ((IDisposable)process).Dispose();
                }
            }
        }

        internal List<TestCaseArgument> GetArguments(IEnumerable<TestCase> testCases)
        {
            List<TestCaseArgument> arguments = new List<TestCaseArgument>();
            Dictionary<string, List<TestCase>> testMethodsInAssemblies = this.GetTestMethodsByAssembly(testCases);
            if (testMethodsInAssemblies == null ? false : testMethodsInAssemblies.Count > 0)
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
                    string configurationFileName = "SilverlightUnitTestAdapter.config";
                    string configurationFilePath = Path.Combine(assemblyPath, configurationFileName);
                    if (File.Exists(configurationFilePath))
                    {
                        Settings settings = Settings.Load(configurationFilePath);

                        argument.Append(" --QueryString=");
                        argument.Append("\"");

                        foreach (NameValuePair nameValuePair in settings.QueryString)
                        {
                            argument.Append($"{nameValuePair.Name}={nameValuePair.Value}&");
                        }

                        argument.Append("\"");
                    }

                    TestCaseArgument argumentInfo = new TestCaseArgument(argument.ToString(), assembly, testMethodsInAssemblies[assembly]);
                    arguments.Add(argumentInfo);
                }
            }

            return arguments;
        }

        internal Dictionary<string, List<TestCase>> GetTestMethodsByAssembly(IEnumerable<TestCase> testCases)
        {
            Dictionary<string, List<TestCase>> testMethodsInAssemblies = new Dictionary<string, List<TestCase>>();
            foreach (TestCase testCase in testCases)
            {
                if (!testMethodsInAssemblies.ContainsKey(testCase.Source))
                {
                    testMethodsInAssemblies.Add(testCase.Source, new List<TestCase>
                    {
                        testCase
                    });
                }
                else
                {
                    testMethodsInAssemblies[testCase.Source].Add(testCase);
                }
            }

            return testMethodsInAssemblies;
        }

        internal bool IsStatLightInstalled()
        {
            bool flag;
            string currentAssemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (new FileInfo(Path.Combine(currentAssemblyPath, "StatLight.exe")).Exists)
            {
                this.isInstalled = true;
                flag = true;
                return flag;
            }

            this.shell.Trace(string.Concat("ERROR: StatLight not found at expected location: ", currentAssemblyPath));
            this.isInstalled = false;
            flag = false;
            return flag;
        }

        internal void ProcessResults(IEnumerable<TestCase> tests, TestCaseArgument argument, IFrameworkHandle frameworkHandle)
        {
            TrxSchemaReader reader = new TrxSchemaReader(this.shell, tests);
            TestRunType testRun = reader.Read(argument.TestResultPath);
            if (testRun != null)
            {
                foreach (TrxResult result in reader.ProcessStatLightResult(testRun))
                {
                    TestResult testResult = result.GetTestResult();
                    frameworkHandle.RecordResult(testResult);
                    frameworkHandle.RecordEnd(result.TestCase, testResult.Outcome);
                }
            }
        }

        internal void RecordStartTests(TestCaseArgument argument, IFrameworkHandle frameworkHandle)
        {
            foreach (TestCase testCase in argument.TestCases)
            {
                frameworkHandle.RecordStart(testCase);
            }
        }

        internal void RunTests(IEnumerable<TestCase> testCases, IFrameworkHandle frameworkHandle)
        {
            List<TestCaseArgument> arguments = new List<TestCaseArgument>();
            if (this.IsStatLightInstalled())
            {
                foreach (TestCaseArgument argument in this.GetArguments(testCases))
                {
                    this.RecordStartTests(argument, frameworkHandle);
                    this.ExecuteStatLight(argument);
                    this.ProcessResults(argument.TestCases, argument, frameworkHandle);
                }
            }
        }
    }
}