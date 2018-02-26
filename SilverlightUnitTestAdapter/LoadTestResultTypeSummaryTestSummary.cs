// <copyright file="LoadTestResultTypeSummaryTestSummary.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestResultTypeSummaryTestSummary
    {
        private string scenarioNameField;

        private string testNameField;

        private int totalTestsField;

        private int testsFailedField;

        private int averageDurationField;

        [XmlAttribute]
        public int averageDuration
        {
            get
            {
                return this.averageDurationField;
            }

            set
            {
                this.averageDurationField = value;
            }
        }

        [XmlAttribute]
        public string scenarioName
        {
            get
            {
                return this.scenarioNameField;
            }

            set
            {
                this.scenarioNameField = value;
            }
        }

        [XmlAttribute]
        public string testName
        {
            get
            {
                return this.testNameField;
            }

            set
            {
                this.testNameField = value;
            }
        }

        [XmlAttribute]
        public int testsFailed
        {
            get
            {
                return this.testsFailedField;
            }

            set
            {
                this.testsFailedField = value;
            }
        }

        [XmlAttribute]
        public int totalTests
        {
            get
            {
                return this.totalTestsField;
            }

            set
            {
                this.totalTestsField = value;
            }
        }
    }
}