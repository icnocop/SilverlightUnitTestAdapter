// <copyright file="TestRunOptions.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.StatLight
{
    using System;
    using System.Collections.Generic;
    using global::StatLight.Core.Configuration;
    using global::StatLight.Core.Reporting;

    /// <summary>
    /// Test Run Options.
    /// </summary>
    [Serializable]
    public class TestRunOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunOptions"/> class.
        /// </summary>
        public TestRunOptions()
        {
            this.OverriddenSettings = new Dictionary<string, string>();
        }

        /// <summary>
        /// Gets or sets the DLL path.
        /// </summary>
        /// <value>The DLL path.</value>
        public string DllPath { get; set; }

        /// <summary>
        /// Gets or sets the methods to test.
        /// </summary>
        /// <value>The methods to test.</value>
        public List<string> MethodsToTest { get; set; }

        /// <summary>
        /// Gets or sets the type of the report output file.
        /// </summary>
        /// <value>The type of the report output file.</value>
        public ReportOutputFileType ReportOutputFileType { get; set; }

        /// <summary>
        /// Gets or sets the report output path.
        /// </summary>
        /// <value>The report output path.</value>
        public string ReportOutputPath { get; set; }

        /// <summary>
        /// Gets or sets the query string.
        /// </summary>
        /// <value>The query string.</value>
        public string QueryString { get; set; }

        /// <summary>
        /// Gets or sets the unit test provider.
        /// </summary>
        /// <value>The unit test provider.</value>
        public UnitTestProviderType UnitTestProviderType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TestRunOptions"/> is debug.
        /// </summary>
        /// <value><c>true</c> if debug; otherwise, <c>false</c>.</value>
        public bool Debug { get; set; }

        /// <summary>
        /// Gets or sets the overridden settings.
        /// </summary>
        /// <value>The overridden settings.</value>
        public IDictionary<string, string> OverriddenSettings { get; set; }
    }
}
