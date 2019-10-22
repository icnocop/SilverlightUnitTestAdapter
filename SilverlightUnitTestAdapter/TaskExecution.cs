// <copyright file="TaskExecution.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
    using SilverlightUnitTestAdapter.Assemblies;
    using SilverlightUnitTestAdapter.StatLight;
    using SilverlightUnitTestAdapter.Tasks;

    /// <summary>
    /// Task Execution.
    /// </summary>
    internal class TaskExecution
    {
        private readonly LimitedConcurrencyLevelTaskScheduler scheduler;

        private readonly StatLightWrapper statLightWrapper;

        private int testsCompleted;

        private int testsFailed;

        private int testCancelled;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskExecution" /> class.
        /// </summary>
        /// <param name="frameworkHandle">The framework handle.</param>
        /// <param name="statLightWrapper">The stat light wrapper.</param>
        public TaskExecution(IFrameworkHandle frameworkHandle, StatLightWrapper statLightWrapper)
        {
            this.statLightWrapper = statLightWrapper;
            this.FrameworkHandle = frameworkHandle;

            this.scheduler = new LimitedConcurrencyLevelTaskScheduler(1);
        }

        /// <summary>
        /// Gets or sets the framework handle.
        /// </summary>
        /// <value>The framework handle.</value>
        public IFrameworkHandle FrameworkHandle { get; set; }

        /// <summary>
        /// Converts the discovery information to test cases and runs them.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="discoveryInfos">The discovery infos.</param>
        internal void ConvertAndRun(string source, List<DiscoveryInfo> discoveryInfos)
        {
            this.FrameworkHandle.SendMessage(TestMessageLevel.Informational, $"Converting test cases in '{source}'...");

            List<TestCase> testCases = new List<TestCase>();
            foreach (DiscoveryInfo discoveryResultItem in discoveryInfos)
            {
                TestCase testCase = new TestCase(
                    discoveryResultItem.GetFullMethodPath(),
                    new Uri(Constants.ExecutorUri),
                    source)
                {
                    DisplayName = discoveryResultItem.GetFullMethodPath(),
                    CodeFilePath = discoveryResultItem.ClassFilePath,
                    LineNumber = discoveryResultItem.LineOfCode
                };
                testCases.Add(testCase);
            }

            this.FrameworkHandle.SendMessage(TestMessageLevel.Informational, string.Concat("Conversion successful ", source));
            this.statLightWrapper.RunTests(testCases, this.FrameworkHandle);
            this.FrameworkHandle.SendMessage(TestMessageLevel.Informational, string.Concat("Running tests successful ", source));
        }

        /// <summary>
        /// Creates the source based task.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>The discovery information task.</returns>
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

        /// <summary>
        /// Creates the test based task.
        /// </summary>
        /// <param name="testCases">The test cases.</param>
        /// <returns>The task.</returns>
        internal Task CreateTestBasedTask(IEnumerable<TestCase> testCases)
        {
            Task task = new Task(() => this.statLightWrapper.RunTests(testCases, this.FrameworkHandle));
            Action<Task> onSucceeded = result => this.TaskCompleted();
            Action<Task> onFailed = result => this.TaskFailed();
            Action<Task> onCancelled = result => this.TaskCancelled();
            task.ContinueWith(onSucceeded, TaskContinuationOptions.OnlyOnRanToCompletion);
            task.ContinueWith(onFailed, TaskContinuationOptions.OnlyOnFaulted);
            task.ContinueWith(onCancelled, TaskContinuationOptions.OnlyOnCanceled);
            return task;
        }

        /// <summary>
        /// Loads the assemblies.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>The discovery information.</returns>
        internal List<DiscoveryInfo> LoadAssemblies(string source)
        {
            this.FrameworkHandle.SendMessage(TestMessageLevel.Informational, $"Loading assembly '{source}'...");

            List<DiscoveryInfo> discoveryResult;

            using (AssemblyLoader loader = new AssemblyLoader(this.FrameworkHandle))
            {
                loader.Initialize(source);
                discoveryResult = loader.Load(source);
            }

            this.FrameworkHandle.SendMessage(TestMessageLevel.Informational, string.Concat("Tests in assembly successfully discovered: ", source));
            return discoveryResult;
        }

        /// <summary>
        /// Starts the task.
        /// </summary>
        /// <param name="sources">The sources.</param>
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
                this.FrameworkHandle.SendMessage(TestMessageLevel.Informational, string.Concat("Starting new task for: ", source));
            }

            this.FrameworkHandle.SendMessage(TestMessageLevel.Informational, "Waiting for all tasks to complete.");
            Task.WaitAll(tasks.ToArray());
            this.FrameworkHandle.SendMessage(TestMessageLevel.Informational, "All tasks finished");
        }

        /// <summary>
        /// Starts the task.
        /// </summary>
        /// <param name="tests">The tests.</param>
        internal void StartTask(IEnumerable<TestCase> tests)
        {
            Task task = this.CreateTestBasedTask(tests);
            this.FrameworkHandle.SendMessage(TestMessageLevel.Informational, "Start new task");
            task.Start(this.scheduler);
            task.Wait();

            this.FrameworkHandle.SendMessage(TestMessageLevel.Informational, "Ended new task");
        }

        /// <summary>
        /// Indicates the task was cancelled.
        /// </summary>
        /// <param name="source">The source.</param>
        internal void TaskCancelled(string source)
        {
            this.testCancelled++;
            this.FrameworkHandle.SendMessage(TestMessageLevel.Error, string.Concat("Task cancelled for: ", source));
            string[] str = { "--- Completed:", this.testsCompleted.ToString(), ", Failed:", this.testsFailed.ToString(), ", Cancelled:", this.testCancelled.ToString(), " ---" };
            this.FrameworkHandle.SendMessage(TestMessageLevel.Error, string.Concat(str));
        }

        /// <summary>
        /// Indicates the task was cancelled.
        /// </summary>
        internal void TaskCancelled()
        {
            this.FrameworkHandle.SendMessage(TestMessageLevel.Error, "Task cancelled");
        }

        /// <summary>
        /// Represents an event that is raised when a task either successfully or unsuccessfully completes.
        /// </summary>
        /// <param name="source">The source.</param>
        internal void TaskCompleted(string source)
        {
            this.testsCompleted++;
            this.FrameworkHandle.SendMessage(TestMessageLevel.Informational, string.Concat("Task completed for: ", source));
            string[] str = { "--- Completed:", this.testsCompleted.ToString(), ", Failed:", this.testsFailed.ToString(), ", Cancelled:", this.testCancelled.ToString(), " ---" };
            this.FrameworkHandle.SendMessage(TestMessageLevel.Informational, string.Concat(str));
        }

        /// <summary>
        /// Represents an event that is raised when a task either successfully or unsuccessfully completes.
        /// </summary>
        internal void TaskCompleted()
        {
            this.FrameworkHandle.SendMessage(TestMessageLevel.Informational, "Task completed");
        }

        /// <summary>
        /// Indicates the task failed.
        /// </summary>
        /// <param name="source">The source.</param>
        internal void TaskFailed(string source)
        {
            this.testsFailed++;
            this.FrameworkHandle.SendMessage(TestMessageLevel.Error, string.Concat("Task failed for: ", source));
            string[] str = { "--- Completed:", this.testsCompleted.ToString(), ", Failed:", this.testsFailed.ToString(), ", Cancelled:", this.testCancelled.ToString(), " ---" };
            this.FrameworkHandle.SendMessage(TestMessageLevel.Error, string.Concat(str));
        }

        /// <summary>
        /// Indicates the task failed.
        /// </summary>
        internal void TaskFailed()
        {
            this.FrameworkHandle.SendMessage(TestMessageLevel.Error, "Task failed");
        }
    }
}