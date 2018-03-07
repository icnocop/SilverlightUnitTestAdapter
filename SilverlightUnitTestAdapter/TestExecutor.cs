// <copyright file="TestExecutor.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
    using SilverlightUnitTestAdapter.Helpers;
    using SilverlightUnitTestAdapter.StatLight;

    /// <summary>
    /// Test Executor.
    /// </summary>
    /// <seealso cref="Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.ITestExecutor" />
    [ExtensionUri(Constants.ExecutorUri)]
    public class TestExecutor : ITestExecutor
    {
        /// <summary>
        /// Cancels the test.
        /// </summary>
        public void Cancel()
        {
        }

        /// <summary>
        /// Runs the tests.
        /// </summary>
        /// <param name="sources">The sources.</param>
        /// <param name="runContext">The run context.</param>
        /// <param name="frameworkHandle">The framework handle.</param>
        public void RunTests(IEnumerable<string> sources, IRunContext runContext, IFrameworkHandle frameworkHandle)
        {
            VsShell shell = new VsShell(frameworkHandle);

            try
            {
                // Register the IOleMessageFilter to handle any threading errors.
                MessageFilter.Register();

                shell.Initialize(true);

                StatLightWrapper statLightWrapper = new StatLightWrapper(shell);

                TaskExecution taskExecution = new TaskExecution(frameworkHandle, statLightWrapper, shell);
                taskExecution.StartTask(sources);
            }
            catch (Exception ex)
            {
                shell.Trace(ex.ToString());
                throw;
            }
            finally
            {
                // and turn off the IOleMessageFilter.
                MessageFilter.Revoke();
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
            VsShell shell = new VsShell(frameworkHandle);

            try
            {
                // Register the IOleMessageFilter to handle any threading errors.
                MessageFilter.Register();

                shell.Initialize(true);

                shell.Trace("Start executing Silverlight tests. Based on the selected number of tests this might take some time...");

                IEnumerable<TestCase> testCases = tests.ToList();
                shell.Trace(string.Concat(testCases.Count(), " will be executed."));

                StatLightWrapper statLightWrapper = new StatLightWrapper(shell);

                TaskExecution taskExecution = new TaskExecution(frameworkHandle, statLightWrapper, shell);
                taskExecution.StartTask(testCases);

                int num = testCases.Count();
                shell.Trace(string.Concat("----- Finished execution of ", num.ToString(), " tests. ----- "));
            }
            catch (Exception ex)
            {
                shell.Trace($"Message: {ex.Message}");
                shell.Trace(ex.ToString());
                throw;
            }
            finally
            {
                // and turn off the IOleMessageFilter.
                MessageFilter.Revoke();
            }
        }
    }
}