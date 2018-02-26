// <copyright file="TaskExecution.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
    using SilverlightUnitTestAdapter.Assemblies;
    using SilverlightUnitTestAdapter.StatLight;
    using SilverlightUnitTestAdapter.Tasks;
    using SilverlightUnitTestAdapter.Utils;

    internal class TaskExecution
    {
        private readonly LimitedConcurrencyLevelTaskScheduler scheduler;

        private TaskFactory factory;

        private int testsCompleted;

        private int testsFailed;

        private int testCancelled;

        private readonly StatLightWrapper statLightWrapper;
        private readonly VsShell shell;

        public TaskExecution(IFrameworkHandle frameworkHandle, StatLightWrapper statLightWrapper, VsShell shell)
        {
            this.statLightWrapper = statLightWrapper;
            this.shell = shell;
            this.FrameworkHandle = frameworkHandle;

            this.scheduler = new LimitedConcurrencyLevelTaskScheduler(-1);
            this.factory = new TaskFactory(this.scheduler);
        }

        public IFrameworkHandle FrameworkHandle
        {
            get;
            set;
        }

        internal void ConvertAndRun(string source, List<DiscoveryInfo> discoveryInfos)
        {
            List<TestCase> testCases = new List<TestCase>();
            foreach (DiscoveryInfo discoveryResultItem in discoveryInfos)
            {
                TestCase testCase = new TestCase(discoveryResultItem.GetFullMethodPath(), new Uri("executor://statlighttestadapter/v1"), source);
                testCase.DisplayName = discoveryResultItem.GetFullMethodPath();
                testCase.CodeFilePath = discoveryResultItem.ClassFilePath;
                testCase.LineNumber = discoveryResultItem.LineOfCode;
                testCases.Add(testCase);
            }

            this.shell.Trace(string.Concat("Convertion successfull ", source));
            this.statLightWrapper.RunTests(testCases, this.FrameworkHandle);
            this.shell.Trace(string.Concat("Running tests successfull ", source));
        }

        internal Task<List<DiscoveryInfo>> CreateSourceBasedTask(string source)
        {
            Task<List<DiscoveryInfo>> task = new Task<List<DiscoveryInfo>>(() => this.LoadAssemblies(source));
            Action<Task<List<DiscoveryInfo>>> onSucceeded = result => this.ConvertAndRun(source, result.Result);
            Action<Task<List<DiscoveryInfo>>> onFailed = result => this.TaskFailed(source);
            Action<Task<List<DiscoveryInfo>>> onCancelled = result => this.TaskCancelled(source);
            Task succeededTask = task.ContinueWith(onSucceeded, TaskContinuationOptions.OnlyOnRanToCompletion);
            task.ContinueWith(onFailed, TaskContinuationOptions.OnlyOnFaulted);
            task.ContinueWith(onCancelled, TaskContinuationOptions.OnlyOnCanceled);
            Action<Task> onCompleted = result => this.TaskCompleted(source);
            Action<Task> onFailed2 = result => this.TaskFailed(source);
            Action<Task> onCancelled2 = result => this.TaskCancelled(source);
            succeededTask.ContinueWith(onCompleted, TaskContinuationOptions.OnlyOnRanToCompletion);
            succeededTask.ContinueWith(onFailed2, TaskContinuationOptions.OnlyOnFaulted);
            succeededTask.ContinueWith(onCancelled2, TaskContinuationOptions.OnlyOnCanceled);
            return task;
        }

        internal Task CreateTestBasedTask(IEnumerable<TestCase> testCases)
        {
            Task task = new Task(() => this.statLightWrapper.RunTests(testCases, this.FrameworkHandle));
            Action<Task> onSucceeded = result => this.TaskCompleted(testCases);
            Action<Task> onFailed = result => this.TaskFailed(testCases);
            Action<Task> onCancelled = result => this.TaskCancelled(testCases);
            task.ContinueWith(onSucceeded, TaskContinuationOptions.OnlyOnRanToCompletion);
            task.ContinueWith(onFailed, TaskContinuationOptions.OnlyOnFaulted);
            task.ContinueWith(onCancelled, TaskContinuationOptions.OnlyOnCanceled);
            return task;
        }

        internal List<DiscoveryInfo> LoadAssemblies(string source)
        {
            List<DiscoveryInfo> discoveryResult = new List<DiscoveryInfo>();
            AssemblyLoader loader = new AssemblyLoader(this.shell);

            try
            {
                loader.Initialize(source);
                discoveryResult = loader.Load(source);
            }
            finally
            {
                if (loader != null)
                {
                    ((IDisposable)loader).Dispose();
                }
            }

            this.shell.Trace(string.Concat("Tests in assembly successfull discovered: ", source));
            return discoveryResult;
        }

        internal void StartTask(IEnumerable<string> sources)
        {
            this.testsCompleted = 0;
            this.testsFailed = 0;
            this.testCancelled = 0;
            List<Task> tasks = new List<Task>();
            foreach (string source in sources)
            {
                Task<List<DiscoveryInfo>> task = this.CreateSourceBasedTask(source);
                tasks.Add(task);
                task.Start(this.scheduler);
                this.shell.Trace(string.Concat("Starting new task for: ", source));
            }

            this.shell.Trace("Waiting for all tasks to complete.");
            Task.WaitAll(tasks.ToArray());
            this.shell.Trace("All tasks finished");
        }

        internal void StartTask(IEnumerable<TestCase> tests)
        {
            Task task = this.CreateTestBasedTask(tests);
            this.shell.Trace("Start new task");
            task.Start();
            task.Wait();

            this.shell.Trace("Ended new task");
        }

        internal void TaskCancelled(string source)
        {
            this.testCancelled++;
            this.shell.Trace(string.Concat("Task cancelled for: ", source));
            string[] str = { "--- Completed:", this.testsCompleted.ToString(), ", Failed:", this.testsFailed.ToString(), ", Cancelled:", this.testCancelled.ToString(), " ---" };
            this.shell.Trace(string.Concat(str));
        }

        internal void TaskCancelled(IEnumerable<TestCase> tests)
        {
            this.shell.Trace("Task cancelled");
        }

        internal void TaskCompleted(string source)
        {
            this.testsCompleted++;
            this.shell.Trace(string.Concat("Task completed for: ", source));
            string[] str = { "--- Completed:", this.testsCompleted.ToString(), ", Failed:", this.testsFailed.ToString(), ", Cancelled:", this.testCancelled.ToString(), " ---" };
            this.shell.Trace(string.Concat(str));
        }

        internal void TaskCompleted(IEnumerable<TestCase> tests)
        {
            this.shell.Trace("Task completed");
        }

        internal void TaskFailed(string source)
        {
            this.testsFailed++;
            this.shell.Trace(string.Concat("Task failed for: ", source));
            string[] str = { "--- Completed:", this.testsCompleted.ToString(), ", Failed:", this.testsFailed.ToString(), ", Cancelled:", this.testCancelled.ToString(), " ---" };
            this.shell.Trace(string.Concat(str));
        }

        internal void TaskFailed(IEnumerable<TestCase> tests)
        {
            this.shell.Trace("Task failed");
        }
    }
}