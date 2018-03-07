// <copyright file="TrxResult.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.TrxSchema
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Xml;
    using Configuration;
    using Helpers;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using SilverlightUnitTestAdapter.Plugin;
    using VSTS;

    /// <summary>
    /// TRX Result.
    /// </summary>
    internal class TrxResult
    {
        /// <summary>
        /// Gets or sets the test case.
        /// </summary>
        /// <value>The test case.</value>
        internal TestCase TestCase { get; set; }

        /// <summary>
        /// Gets or sets the unit test.
        /// </summary>
        /// <value>The unit test.</value>
        internal UnitTestType UnitTest { get; set; }

        /// <summary>
        /// Gets or sets the unit test result.
        /// </summary>
        /// <value>The unit test result.</value>
        internal UnitTestResultType UnitTestResult { get; set; }

        /// <summary>
        /// Converts the string to the test outcome.
        /// </summary>
        /// <param name="testOutcomeString">The test outcome string.</param>
        /// <returns>The test outcome.</returns>
        internal static Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome ConvertTestOutcome(string testOutcomeString)
        {
            Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome testOutcome;
            if (!Enum.TryParse(testOutcomeString, out testOutcome))
            {
                return 0;
            }

            return testOutcome;
        }

        /// <summary>
        /// Gets the test result.
        /// </summary>
        /// <param name="shell">The shell.</param>
        /// <returns>The test result.</returns>
        internal TestResult GetTestResult(VsShell shell)
        {
            TestResult result = new TestResult(this.TestCase)
            {
                ComputerName = this.UnitTestResult.computerName,
                DisplayName = string.Concat(this.UnitTest.TestMethod.className, ".", this.UnitTest.TestMethod.name)
            };

            DateTime startTime;
            if (DateTime.TryParse(this.UnitTestResult.startTime, out startTime))
            {
                result.StartTime = startTime;
            }

            TimeSpan duration;
            if (TimeSpan.TryParse(this.UnitTestResult.duration, out duration))
            {
                result.Duration = duration;
            }

            DateTime endTime;
            if (DateTime.TryParse(this.UnitTestResult.endTime, out endTime))
            {
                result.EndTime = endTime;
            }

            result.Outcome = ConvertTestOutcome(this.UnitTestResult.outcome);

            if (this.UnitTestResult.Items != null)
            {
                object[] items = this.UnitTestResult.Items;
                foreach (object item in items)
                {
                    OutputType output = item as OutputType;
                    if (output?.ErrorInfo != null)
                    {
                        OutputTypeErrorInfo errorInfo = output.ErrorInfo;

                        XmlNode[] messageNode = errorInfo.Message as XmlNode[];
                        if (messageNode != null)
                        {
                            result.ErrorMessage = messageNode[0].InnerText;
                        }

                        XmlNode[] stackTraceNode = errorInfo.StackTrace as XmlNode[];
                        if (stackTraceNode != null)
                        {
                            result.ErrorStackTrace = stackTraceNode[0].InnerText;
                        }
                    }
                }
            }

            PluginHelper pluginHelper = new PluginHelper(
                shell,
                this.TestCase.Source,
                result);
            pluginHelper.TransformTestResults();

            return result;
        }
    }
}