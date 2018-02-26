// <copyright file="TestContainer.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestWindow.Extensibility;
    using Microsoft.VisualStudio.TestWindow.Extensibility.Model;

    public class TestContainer : ITestContainer
    {
        internal DateTime LastKnownChange;

        private readonly ITestContainerDiscoverer discoverer;

        private readonly string source;

        private Uri executorUri;

        private readonly IEnumerable<Guid> debugEngines;

        public IEnumerable<Guid> DebugEngines
        {
            get
            {
                return this.debugEngines;
            }
        }

        public ITestContainerDiscoverer Discoverer
        {
            get
            {
                return this.discoverer;
            }
        }

        public bool IsAppContainerTestContainer
        {
            get
            {
                return false;
            }
        }

        public string Source
        {
            get
            {
                return this.source;
            }
        }

        public FrameworkVersion TargetFramework
        {
            get
            {
                return 0;
            }
        }

        public Architecture TargetPlatform
        {
            get
            {
                return Architecture.X86;
            }
        }

        public TestContainer(ITestContainerDiscoverer discoverer, string source, Uri executorUri) : this(discoverer, source, executorUri, Enumerable.Empty<Guid>())
        {
            if (!string.IsNullOrWhiteSpace(source))
            {
                this.discoverer = discoverer;
                this.source = source;
                this.executorUri = executorUri;
                this.debugEngines = new List<Guid>();
                this.LastKnownChange = this.GetTimeStamp();
            }
        }

        public TestContainer(ITestContainerDiscoverer discoverer, string source, Uri executorUri, IEnumerable<Guid> debugEngines)
        {
            if (!string.IsNullOrWhiteSpace(source))
            {
                this.discoverer = discoverer;
                this.source = source;
                this.executorUri = executorUri;
                this.debugEngines = debugEngines;
            }
        }

        public int CompareTo(ITestContainer other)
        {
            int num;
            TestContainer testContainer = other as TestContainer;
            num = testContainer != null ? this.LastKnownChange.CompareTo(testContainer.LastKnownChange) : -1;
            return num;
        }

        public IDeploymentData DeployAppContainer()
        {
            return null;
        }

        private DateTime GetTimeStamp()
        {
            DateTime dateTime;
            dateTime = (string.IsNullOrEmpty(this.Source) ? true : !File.Exists(this.Source)) ? DateTime.MinValue : File.GetLastWriteTime(this.Source);
            return dateTime;
        }

        public ITestContainer Snapshot()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Concat("executor://statlighttestadapter/v1/", this.Source);
        }
    }
}