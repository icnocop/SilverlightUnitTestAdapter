// <copyright file="LoadTestResultTypeSummaryTransactionSummary.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestResultTypeSummaryTransactionSummary
    {
        private string scenarioNameField;

        private string testNameField;

        private string transactionNameField;

        private int transactionCountField;

        private string elapsedTimeField;

        private string responseTimeField;

        [XmlAttribute]
        public string elapsedTime
        {
            get
            {
                return this.elapsedTimeField;
            }

            set
            {
                this.elapsedTimeField = value;
            }
        }

        [XmlAttribute]
        public string responseTime
        {
            get
            {
                return this.responseTimeField;
            }

            set
            {
                this.responseTimeField = value;
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
        public int transactionCount
        {
            get
            {
                return this.transactionCountField;
            }

            set
            {
                this.transactionCountField = value;
            }
        }

        [XmlAttribute]
        public string transactionName
        {
            get
            {
                return this.transactionNameField;
            }

            set
            {
                this.transactionNameField = value;
            }
        }
    }
}