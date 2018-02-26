// <copyright file="TestContainerDiscoverer.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using EnvDTE;
    using EnvDTE80;
    using Microsoft.VisualStudio.TestWindow.Extensibility;

    public class TestContainerDiscoverer : ITestContainerDiscoverer
    {
        private readonly DTE2 dte;

        private readonly List<TestContainer> discoveredContainers;

        public Uri ExecutorUri
        {
            get
            {
                return new Uri("executor://statlighttestadapter/v1");
            }
        }

        public IEnumerable<ITestContainer> TestContainers
        {
            get
            {
                return this.discoveredContainers;
            }
        }

        public TestContainerDiscoverer(DTE2 dte)
        {
            this.discoveredContainers = new List<TestContainer>();
            this.dte = dte;
            if (this.dte == null ? false : this.dte.Events.SolutionEvents != null)
            {
                this.dte.Events.SolutionEvents.Opened += this.SolutionEvents_Opened;
            }
        }

        private void BuildEvents_OnBuildDone(vsBuildScope Scope, vsBuildAction Action)
        {
        }

        private void CreateTestContainer(string assemblyPath)
        {
            TestContainer container = new TestContainer(this, assemblyPath, new Uri("executor://statlighttestadapter/v1"));
            this.discoveredContainers.Add(container);
        }

        internal string GetProjectFullPath(Project project)
        {
            string str;
            str = project.Properties == null ? string.Empty : project.FullName;
            return str;
        }

        internal string GetProjectOutputFileName(Project project)
        {
            string empty;
            if (project.Properties == null)
            {
                empty = string.Empty;
            }
            else
            {
                foreach (Property item in project.Properties)
                {
                    Debug.WriteLine(string.Concat(item.Name, ": ", item.Value));
                }

                empty = project.Properties.Item("OutputFileName").Value.ToString();
            }

            return empty;
        }

        internal string GetProjectOutputPath(Project project)
        {
            string str;
            str = project.ConfigurationManager == null ? string.Empty : project.ConfigurationManager.ActiveConfiguration.Properties.Item("OutputPath").Value.ToString();
            return str;
        }

        internal void RaiseContainersUpdatedEvent()
        {
            if (this.TestContainersUpdated != null)
            {
                this.TestContainersUpdated(this, new EventArgs());
            }
        }

        internal void ReadProjectInfo(Project project)
        {
            if (project != null)
            {
                string fullPath = this.GetProjectFullPath(project);
                string outputDir = Path.Combine(fullPath, this.GetProjectOutputPath(project));
                string outputFileName = this.GetProjectOutputFileName(project);
                this.CreateTestContainer(Path.Combine(outputDir, outputFileName));
            }
        }

        private void SolutionEvents_Opened()
        {
            this.dte.Events.BuildEvents.OnBuildDone += this.BuildEvents_OnBuildDone;
        }

        public event EventHandler TestContainersUpdated;
    }
}