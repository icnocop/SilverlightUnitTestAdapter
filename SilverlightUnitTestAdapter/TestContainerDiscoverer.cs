// <copyright file="TestContainerDiscoverer.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio.Shell;
    using Microsoft.VisualStudio.TestWindow.Extensibility;

    /// <summary>
    /// Test Container Discoverer.
    /// </summary>
    /// <seealso cref="Microsoft.VisualStudio.TestWindow.Extensibility.ITestContainerDiscoverer" />
    [Export(typeof(ITestContainerDiscoverer))]
    public class TestContainerDiscoverer : TestContainerDiscovererBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestContainerDiscoverer"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        [ImportingConstructor]
        public TestContainerDiscoverer(
            [Import(typeof(SVsServiceProvider))] IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        /// <summary>
        /// Gets the executor URI.
        /// </summary>
        /// <value>The executor URI.</value>
        public override Uri ExecutorUri => new Uri(Constants.ExecutorUri);

        protected override string[] TestContainerFileExtensions { get { return new[] { ".dll" }; } }

        protected override string[] WatchedFilePatterns { get { return new[] { "*.dll" }; } }
    }
}