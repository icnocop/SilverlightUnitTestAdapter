// <copyright file="WebTestResultTransactionType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class WebTestResultTransactionType
    {
        private object[] webTestResultGroupField;

        private string nameField;

        private bool isIncludedTestField;

        private bool isIncludedTestFieldSpecified;

        private string responseTimeField;

        [XmlAttribute]
        public bool isIncludedTest
        {
            get
            {
                return this.isIncludedTestField;
            }

            set
            {
                this.isIncludedTestField = value;
            }
        }

        [XmlIgnore]
        public bool isIncludedTestSpecified
        {
            get
            {
                return this.isIncludedTestFieldSpecified;
            }

            set
            {
                this.isIncludedTestFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
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

        [XmlArrayItem("WebTestResultComment", typeof(WebTestResultCommentType), IsNullable=false)]
        [XmlArrayItem("WebTestResultPage", typeof(WebTestResultPageType), IsNullable=false)]
        [XmlArrayItem("WebTestResultTransaction", typeof(WebTestResultTransactionType), IsNullable=false)]
        public object[] WebTestResultGroup
        {
            get
            {
                return this.webTestResultGroupField;
            }

            set
            {
                this.webTestResultGroupField = value;
            }
        }
    }
}