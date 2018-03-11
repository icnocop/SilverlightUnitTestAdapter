// <copyright file="TestContainerDiscoverer.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using EnvDTE;
    using EnvDTE80;
    using Microsoft.VisualStudio.TestWindow.Extensibility;

    /// <summary>
    /// Test Container Discoverer.
    /// </summary>
    /// <seealso cref="Microsoft.VisualStudio.TestWindow.Extensibility.ITestContainerDiscoverer" />
    public class TestContainerDiscoverer : ITestContainerDiscoverer
    {
        private readonly DTE2 dte;

        private readonly List<TestContainer> discoveredContainers;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestContainerDiscoverer"/> class.
        /// </summary>
        /// <param name="dte">The DTE.</param>
        public TestContainerDiscoverer(DTE2 dte)
        {
            this.discoveredContainers = new List<TestContainer>();
            this.dte = dte;
            if (dte?.Events.SolutionEvents != null)
            {
                this.dte.Events.SolutionEvents.Opened += this.SolutionEvents_Opened;
            }
        }

        /// <summary>
        /// Occurs when the test containers are updated.
        /// </summary>
        public event EventHandler TestContainersUpdated;

        /// <summary>
        /// Gets the executor URI.
        /// </summary>
        /// <value>The executor URI.</value>
        public Uri ExecutorUri => new Uri(Constants.ExecutorUri);

        /// <summary>
        /// Gets the test containers.
        /// </summary>
        /// <value>The test containers.</value>
        public IEnumerable<ITestContainer> TestContainers => this.discoveredContainers;

        /// <summary>
        /// Gets the project full path.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>The full path to the project.</returns>
        internal static string GetProjectFullPath(Project project)
        {
            return project.Properties == null ? string.Empty : project.FullName;
        }

        /// <summary>
        /// Gets the name of the project output file.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>The project's output file name.</returns>
        internal static string GetProjectOutputFileName(Project project)
        {
            string empty = string.Empty;

            if (project.Properties != null)
            {
                empty = project.Properties.Item("OutputFileName").Value.ToString();
            }

            return empty;
        }

        /// <summary>
        /// Gets the project output path.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>The project's output path.</returns>
        internal static string GetProjectOutputPath(Project project)
        {
            return project.ConfigurationManager == null ? string.Empty
                : project.ConfigurationManager.ActiveConfiguration.Properties.Item("OutputPath").Value.ToString();
        }

        /// <summary>
        /// Raises the containers updated event.
        /// </summary>
        internal void RaiseContainersUpdatedEvent()
        {
            this.TestContainersUpdated?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Reads the project information.
        /// </summary>
        /// <param name="project">The project.</param>
        internal void ReadProjectInfo(Project project)
        {
            if (project == null)
            {
                return;
            }

            string fullPath = GetProjectFullPath(project);
            string outputDir = Path.Combine(fullPath, GetProjectOutputPath(project));
            string outputFileName = GetProjectOutputFileName(project);
            this.CreateTestContainer(Path.Combine(outputDir, outputFileName));
        }

        private void BuildEvents_OnBuildDone(vsBuildScope scope, vsBuildAction action)
        {
        }

        private void CreateTestContainer(string assemblyPath)
        {
            TestContainer container = new TestContainer(this, assemblyPath);
            this.discoveredContainers.Add(container);
        }

        private void SolutionEvents_Opened()
        {
            this.dte.Events.BuildEvents.OnBuildDone += this.BuildEvents_OnBuildDone;
        }
    }
}