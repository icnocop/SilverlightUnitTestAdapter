// <copyright file="TestCaseArgument.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.StatLight
{
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;

    /// <summary>
    /// Test Case Argument.
    /// </summary>
    internal class TestCaseArgument
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseArgument"/> class.
        /// </summary>
        /// <param name="arguments">The arguments.</param>
        /// <param name="assemblyPath">The assembly path.</param>
        /// <param name="testCases">The test cases.</param>
        public TestCaseArgument(string arguments, string assemblyPath, List<TestCase> testCases)
        {
            this.Argument = arguments;
            this.AssemblyPath = assemblyPath;
            this.TestCases = testCases;
        }

        /// <summary>
        /// Gets or sets the test cases.
        /// </summary>
        /// <value>The test cases.</value>
        internal List<TestCase> TestCases { get; set; }

        /// <summary>
        /// Gets the test result path.
        /// </summary>
        /// <value>The test result path.</value>
        internal string TestResultPath => string.Concat(this.AssemblyPath, "_TestResult.xml");

        private string Argument { get; set; }

        private string AssemblyPath { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <returns>System.String.</returns>
        internal string GetArguments()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(this.Argument);
            builder.Append(" -r=");
            builder.Append(string.Concat("\"", this.TestResultPath));
            builder.Append("\"");
            builder.Append(" --ReportOutputFileType:");
            builder.Append("\"TRX");
            builder.Append("\"");
            return builder.ToString();
        }
    }
}