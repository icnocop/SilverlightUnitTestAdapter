// <copyright file="TestRunTypeResultSummaryRunInfosRunInfo.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [GeneratedCode("xsd", "4.0.30319.17929")]
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class TestRunTypeResultSummaryRunInfosRunInfo
    {
        private object textField;

        private object exceptionField;

        private string computerNameField;

        private TestOutcome outcomeField;

        private string timestampField;

        [XmlAttribute]
        public string computerName
        {
            get
            {
                return this.computerNameField;
            }

            set
            {
                this.computerNameField = value;
            }
        }

        public object Exception
        {
            get
            {
                return this.exceptionField;
            }

            set
            {
                this.exceptionField = value;
            }
        }

        [XmlAttribute]
        public TestOutcome outcome
        {
            get
            {
                return this.outcomeField;
            }

            set
            {
                this.outcomeField = value;
            }
        }

        public object Text
        {
            get
            {
                return this.textField;
            }

            set
            {
                this.textField = value;
            }
        }

        [XmlAttribute]
        public string timestamp
        {
            get
            {
                return this.timestampField;
            }

            set
            {
                this.timestampField = value;
            }
        }
    }
}