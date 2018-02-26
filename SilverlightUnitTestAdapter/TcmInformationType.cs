// <copyright file="TcmInformationType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TcmInformationType
    {
        private int testCaseIdField;

        private int testRunIdField;

        private int testResultIdField;

        private string testIterationIdField;

        [XmlAttribute]
        public int testCaseId
        {
            get
            {
                return this.testCaseIdField;
            }

            set
            {
                this.testCaseIdField = value;
            }
        }

        [XmlAttribute(DataType="nonNegativeInteger")]
        public string testIterationId
        {
            get
            {
                return this.testIterationIdField;
            }

            set
            {
                this.testIterationIdField = value;
            }
        }

        [XmlAttribute]
        public int testResultId
        {
            get
            {
                return this.testResultIdField;
            }

            set
            {
                this.testResultIdField = value;
            }
        }

        [XmlAttribute]
        public int testRunId
        {
            get
            {
                return this.testRunIdField;
            }

            set
            {
                this.testRunIdField = value;
            }
        }
    }
}