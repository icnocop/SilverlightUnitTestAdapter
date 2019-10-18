// <copyright file="TestExecutor.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Assemblies;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
    using SilverlightUnitTestAdapter.StatLight;

    /// <summary>
    /// Test Executor.
    /// </summary>
    /// <seealso cref="Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.ITestExecutor" />
    [ExtensionUri(Constants.ExecutorUri)]
    public class TestExecutor : ITestExecutor
    {
        /// <summary>
        /// Runs the tests.
        /// </summary>
        /// <param name="sources">The sources.</param>
        /// <param name="runContext">The run context.</param>
        /// <param name="frameworkHandle">The framework handle.</param>
        public void RunTests(IEnumerable<string> sources, IRunContext runContext, IFrameworkHandle frameworkHandle)
        {
            try
            {
                StatLightWrapper statLightWrapper = new StatLightWrapper(frameworkHandle, runContext.IsBeingDebugged);

                TaskExecution taskExecution = new TaskExecution(frameworkHandle, statLightWrapper);
                taskExecution.StartTask(sources);
            }
            catch (Exception ex)
            {
                frameworkHandle.SendMessage(TestMessageLevel.Error, ex.ToString());
                return;
            }
        }

        /// <summary>
        /// Runs the tests.
        /// </summary>
        /// <param name="tests">The tests.</param>
        /// <param name="runContext">The run context.</param>
        /// <param name="frameworkHandle">The framework handle.</param>
        public void RunTests(IEnumerable<TestCase> tests, IRunContext runContext, IFrameworkHandle frameworkHandle)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                ConsoleWriter consoleWriter = new ConsoleWriter(
                    value =>
                    {
                        if (value == '\0')
                        {
                            return;
                        }

                        stringBuilder.Append(value);

                        string message = stringBuilder.ToString();
                        if (string.IsNullOrEmpty(message) || (!message.EndsWith(Environment.NewLine)))
                        {
                            return;
                        }

                        if (message == Environment.NewLine)
                        {
                            stringBuilder.Clear();
                            return;
                        }

                        frameworkHandle.SendMessage(TestMessageLevel.Informational, message);

                        stringBuilder.Clear();
                    });
                Console.SetOut(consoleWriter);

                frameworkHandle.SendMessage(TestMessageLevel.Informational, "Start executing Silverlight tests. Based on the selected number of tests this might take some time...");

                IEnumerable<TestCase> testCases = tests.ToList();
                frameworkHandle.SendMessage(TestMessageLevel.Informational, string.Concat(testCases.Count(), " will be executed."));

                StatLightWrapper statLightWrapper = new StatLightWrapper(frameworkHandle, runContext.IsBeingDebugged);

                TaskExecution taskExecution = new TaskExecution(frameworkHandle, statLightWrapper);
                taskExecution.StartTask(testCases);

                consoleWriter.Flush();

                int num = testCases.Count();
                frameworkHandle.SendMessage(TestMessageLevel.Informational, string.Concat("----- Finished execution of ", num.ToString(), " tests. ----- "));
            }
            catch (Exception ex)
            {
                frameworkHandle.SendMessage(TestMessageLevel.Error, ex.ToString());
                return;
            }
        }

        /// <summary>
        /// Cancels the test.
        /// </summary>
        public void Cancel()
        {
        }
    }
}