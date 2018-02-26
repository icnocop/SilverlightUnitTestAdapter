// <copyright file="LoadTestResultTypeSummaryPageSummary.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestResultTypeSummaryPageSummary
    {
        private string scenarioNameField;

        private string testNameField;

        private string urlField;

        private int pageCountField;

        private int responseTimeField;

        [XmlAttribute]
        public int pageCount
        {
            get
            {
                return this.pageCountField;
            }

            set
            {
                this.pageCountField = value;
            }
        }

        [XmlAttribute]
        public int responseTime
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
        public string url
        {
            get
            {
                return this.urlField;
            }

            set
            {
                this.urlField = value;
            }
        }
    }
}