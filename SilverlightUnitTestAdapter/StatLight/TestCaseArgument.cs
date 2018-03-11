// <copyright file="TestCaseArgument.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.StatLight
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;

    /// <summary>
    /// Test Case Argument.
    /// </summary>
    [Serializable]
    internal class TestCaseArgument
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseArgument" /> class.
        /// </summary>
        /// <param name="testRunOptions">The test run options.</param>
        /// <param name="testCases">The test cases.</param>
        public TestCaseArgument(TestRunOptions testRunOptions, List<TestCase> testCases)
        {
            this.TestRunOptions = testRunOptions;
            this.TestCases = testCases;
        }

        /// <summary>
        /// Gets or sets the test cases.
        /// </summary>
        /// <value>The test cases.</value>
        internal List<TestCase> TestCases { get; set; }

        /// <summary>
        /// Gets or sets the test run options.
        /// </summary>
        /// <value>The test run options.</value>
        internal TestRunOptions TestRunOptions { get; set; }
    }
}