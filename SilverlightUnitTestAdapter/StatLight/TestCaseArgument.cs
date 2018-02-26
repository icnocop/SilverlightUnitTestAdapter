// <copyright file="TestCaseArgument.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.StatLight
{
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;

    internal class TestCaseArgument
    {
        private string Argument
        {
            get;
            set;
        }

        internal string AssemblyPath
        {
            get;
            set;
        }

        internal List<TestCase> TestCases
        {
            get;
            set;
        }

        internal string TestResultPath
        {
            get
            {
                return string.Concat(this.AssemblyPath, "_TestResult.xml");
            }
        }

        public TestCaseArgument(string arguments, string assemblyPath, List<TestCase> testCases)
        {
            this.Argument = arguments;
            this.AssemblyPath = assemblyPath;
            this.TestCases = testCases;
        }

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