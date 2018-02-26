// <copyright file="TrxResult.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.TrxSchema
{
    using System;
    using System.Xml;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;

    internal class TrxResult
    {
        internal TestCase TestCase
        {
            get;
            set;
        }

        internal UnitTestType UnitTest
        {
            get;
            set;
        }

        internal UnitTestResultType UnitTestResult
        {
            get;
            set;
        }

        internal Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome ConvertTestOutcome(string testOutcome)
        {
            Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome outcome;
            Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome testOutcome1;
            if (!Enum.TryParse(testOutcome, out outcome))
            {
                testOutcome1 = 0;
            }
            else
            {
                testOutcome1 = outcome;
            }

            return testOutcome1;
        }

        internal TestResult GetTestResult()
        {
            DateTime startTime;
            TimeSpan duration;
            DateTime endTime;
            TestResult result = new TestResult(this.TestCase);
            result.ComputerName = this.UnitTestResult.computerName;
            result.DisplayName = string.Concat(this.UnitTest.TestMethod.className, ".", this.UnitTest.TestMethod.name);
            if (DateTime.TryParse(this.UnitTestResult.startTime, out startTime))
            {
                result.StartTime = startTime;
            }

            if (TimeSpan.TryParse(this.UnitTestResult.duration, out duration))
            {
                result.Duration = duration;
            }

            if (DateTime.TryParse(this.UnitTestResult.endTime, out endTime))
            {
                result.EndTime = endTime;
            }

            result.Outcome = this.ConvertTestOutcome(this.UnitTestResult.outcome);
            if (this.UnitTestResult.Items != null)
            {
                object[] items = this.UnitTestResult.Items;
                for (int i = 0; i < items.Length; i++)
                {
                    OutputType output = items[i] as OutputType;
                    if (output == null ? false : output.ErrorInfo != null)
                    {
                        XmlNode[] messageNode = output.ErrorInfo.Message as XmlNode[];
                        if (messageNode == null)
                        {
                            result.ErrorMessage = Localized.InformationNotAvailable;
                        }
                        else
                        {
                            result.ErrorMessage = messageNode[0].InnerText;
                        }

                        XmlNode[] stackNode = output.ErrorInfo.StackTrace as XmlNode[];
                        if (stackNode == null)
                        {
                            result.ErrorStackTrace = Localized.InformationNotAvailable;
                        }
                        else
                        {
                            result.ErrorStackTrace = stackNode[0].InnerText;
                        }
                    }
                }
            }

            return result;
        }
    }
}