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

    /// <summary>
    /// Test Container.
    /// </summary>
    /// <seealso cref="Microsoft.VisualStudio.TestWindow.Extensibility.ITestContainer" />
    public class TestContainer : ITestContainer
    {
        private DateTime lastKnownChange;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestContainer"/> class.
        /// </summary>
        /// <param name="discoverer">The discoverer.</param>
        /// <param name="source">The source.</param>
        public TestContainer(ITestContainerDiscoverer discoverer, string source)
            : this(discoverer, source, Enumerable.Empty<Guid>())
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                return;
            }

            this.Discoverer = discoverer;
            this.Source = source;
            this.DebugEngines = new List<Guid>();
            this.lastKnownChange = this.GetTimeStamp();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestContainer"/> class.
        /// </summary>
        /// <param name="discoverer">The discoverer.</param>
        /// <param name="source">The source.</param>
        /// <param name="debugEngines">The debug engines.</param>
        public TestContainer(ITestContainerDiscoverer discoverer, string source, IEnumerable<Guid> debugEngines)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                return;
            }

            this.Discoverer = discoverer;
            this.Source = source;
            this.DebugEngines = debugEngines;
        }

        /// <summary>
        /// Gets the debug engines.
        /// </summary>
        /// <value>The debug engines.</value>
        public IEnumerable<Guid> DebugEngines { get; }

        /// <summary>
        /// Gets the discoverer.
        /// </summary>
        /// <value>The discoverer.</value>
        public ITestContainerDiscoverer Discoverer { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is application container test container.
        /// </summary>
        /// <value><c>true</c> if this instance is application container test container; otherwise, <c>false</c>.</value>
        public bool IsAppContainerTestContainer => false;

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>The source.</value>
        public string Source { get; }

        /// <summary>
        /// Gets the target framework.
        /// </summary>
        /// <value>The target framework.</value>
        public FrameworkVersion TargetFramework => 0;

        /// <summary>
        /// Gets the target platform.
        /// </summary>
        /// <value>The target platform.</value>
        public Architecture TargetPlatform => Architecture.X86;

        /// <summary>
        /// Compares this instance to another.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns>System.Int32.</returns>
        public int CompareTo(ITestContainer other)
        {
            TestContainer testContainer = other as TestContainer;
            var num = testContainer != null ? this.lastKnownChange.CompareTo(testContainer.lastKnownChange) : -1;
            return num;
        }

        /// <summary>
        /// Deploys the application container.
        /// </summary>
        /// <returns>The deployment data.</returns>
        public IDeploymentData DeployAppContainer()
        {
            return null;
        }

        /// <summary>
        /// Snapshots this instance.
        /// </summary>
        /// <returns>The test container.</returns>
        public ITestContainer Snapshot()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="string" /> that represents this instance.</returns>
        public override string ToString()
        {
            return string.Concat("executor://statlighttestadapter/v1/", this.Source);
        }

        private DateTime GetTimeStamp()
        {
            var dateTime = string.IsNullOrEmpty(this.Source) || !File.Exists(this.Source) ? DateTime.MinValue : File.GetLastWriteTime(this.Source);
            return dateTime;
        }
    }
}