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
        /// Gets the DLL path.
        /// </summary>
        /// <value>The DLL path.</value>
        public string DllPath { get; private set; }

        /// <summary>
        /// Gets the methods to test.
        /// </summary>
        /// <value>The methods to test.</value>
        public List<string> MethodsToTest { get; private set; }

        /// <summary>
        /// Gets the type of the report output file.
        /// </summary>
        /// <value>The type of the report output file.</value>
        public ReportOutputFileType ReportOutputFileType { get; private set; }

        /// <summary>
        /// Gets the report output path.
        /// </summary>
        /// <value>The report output path.</value>
        public string ReportOutputPath { get; private set; }

        /// <summary>
        /// Gets the query string.
        /// </summary>
        /// <value>The query string.</value>
        public string QueryString { get; private set; }

        /// <summary>
        /// Gets the unit test provider.
        /// </summary>
        /// <value>The unit test provider.</value>
        public UnitTestProviderType UnitTestProviderType { get; private set; }

        /// <summary>
        /// Sets the DLL path.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <returns>The test run options.</returns>
        internal TestRunOptions SetDllPath(string assembly)
        {
            this.DllPath = assembly;

            return this;
        }

        /// <summary>
        /// Sets the methods to test.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns>The test run options.</returns>
        internal TestRunOptions SetMethodsToTest(List<string> list)
        {
            this.MethodsToTest = list;
            return this;
        }

        /// <summary>
        /// Sets the type of the report output file.
        /// </summary>
        /// <param name="reportOutputFileType">Type of the report output file.</param>
        /// <returns>The test run options.</returns>
        internal TestRunOptions SetReportOutputFileType(ReportOutputFileType reportOutputFileType)
        {
            this.ReportOutputFileType = reportOutputFileType;
            return this;
        }

        /// <summary>
        /// Sets the report output path.
        /// </summary>
        /// <param name="reportOutputPath">The report output path.</param>
        /// <returns>The test run options.</returns>
        internal TestRunOptions SetReportOutputPath(string reportOutputPath)
        {
            this.ReportOutputPath = reportOutputPath;
            return this;
        }

        /// <summary>
        /// Sets the query string.
        /// </summary>
        /// <param name="queryString">The query string.</param>
        /// <returns>The test run options.</returns>
        internal TestRunOptions SetQueryString(string queryString)
        {
            this.QueryString = queryString;
            return this;
        }

        /// <summary>
        /// Sets the unit test provider type.
        /// </summary>
        /// <param name="unitTestProviderType">The unit test provider type.</param>
        /// <returns>The test run options.</returns>
        internal TestRunOptions SetUnitTestProvider(UnitTestProviderType unitTestProviderType)
        {
            this.UnitTestProviderType = unitTestProviderType;
            return this;
        }
    }
}
