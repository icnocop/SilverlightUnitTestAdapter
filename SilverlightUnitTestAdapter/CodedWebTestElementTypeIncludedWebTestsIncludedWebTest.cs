// <copyright file="CodedWebTestElementTypeIncludedWebTestsIncludedWebTest.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class CodedWebTestElementTypeIncludedWebTestsIncludedWebTest
    {
        private string nameField;

        private string pathField;

        private string testIdField;

        private bool isCodedWebTestField;

        [DefaultValue(false)]
        [XmlAttribute]
        public bool isCodedWebTest
        {
            get
            {
                return this.isCodedWebTestField;
            }

            set
            {
                this.isCodedWebTestField = value;
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
        public string path
        {
            get
            {
                return this.pathField;
            }

            set
            {
                this.pathField = value;
            }
        }

        [XmlAttribute]
        public string testId
        {
            get
            {
                return this.testIdField;
            }

            set
            {
                this.testIdField = value;
            }
        }

        public CodedWebTestElementTypeIncludedWebTestsIncludedWebTest()
        {
            this.isCodedWebTestField = false;
        }
    }
}