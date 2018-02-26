// <copyright file="TestRunConfigurationCodeCoverageAspNetCodeCoverageItem.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestRunConfigurationCodeCoverageAspNetCodeCoverageItem
    {
        private string idField;

        private string nameField;

        private string applicationRootField;

        private string urlField;

        private bool isIISField;

        private bool isIISFieldSpecified;

        [XmlAttribute]
        public string applicationRoot
        {
            get
            {
                return this.applicationRootField;
            }

            set
            {
                this.applicationRootField = value;
            }
        }

        [XmlAttribute]
        public string id
        {
            get
            {
                return this.idField;
            }

            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute]
        public bool isIIS
        {
            get
            {
                return this.isIISField;
            }

            set
            {
                this.isIISField = value;
            }
        }

        [XmlIgnore]
        public bool isIISSpecified
        {
            get
            {
                return this.isIISFieldSpecified;
            }

            set
            {
                this.isIISFieldSpecified = value;
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