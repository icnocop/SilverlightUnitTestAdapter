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
    using SilverlightUnitTestAdapter.StatLight;
    using SilverlightUnitTestAdapter.Utils;

    [ExtensionUri("executor://statlighttestadapter/v1")]
    public class TestExecutor : ITestExecutor
    {
        private bool isCancelled;

        public void Cancel()
        {
            this.isCancelled = true;
        }

        public void RunTests(IEnumerable<string> sources, IRunContext runContext, IFrameworkHandle frameworkHandle)
        {
            VsShell shell = new VsShell(frameworkHandle);
            shell.Initialize();

            try
            {
                StatLightWrapper statLightWrapper = new StatLightWrapper(shell);

                List<TestCase> collectedTestCases = new List<TestCase>();
                TaskExecution taskExecution = new TaskExecution(frameworkHandle, statLightWrapper, shell);
                taskExecution.StartTask(sources);
            }
            catch (Exception ex)
            {
                shell.Trace(ex.ToString());
                throw;
            }
        }

        public void RunTests(IEnumerable<TestCase> tests, IRunContext runContext, IFrameworkHandle frameworkHandle)
        {
            VsShell shell = new VsShell(frameworkHandle);
            shell.Initialize();

            try
            {

                shell.Trace("Start executing Silverlight tests. Based on the selected number of tests this might take some time...");
                shell.Trace(string.Concat(tests.Count(), " will be executed."));

                StatLightWrapper statLightWrapper = new StatLightWrapper(shell);

                TaskExecution taskExecution = new TaskExecution(frameworkHandle, statLightWrapper, shell);
                taskExecution.StartTask(tests);

                int num = tests.Count();
                shell.Trace(string.Concat("----- Finished execution of ", num.ToString(), " tests. ----- "));
            }
            catch (Exception ex)
            {
                shell.Trace(ex.ToString());
                throw;
            }
        }
    }
}