// <copyright file="TestRunConfigurationCodeCoverage.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestRunConfigurationCodeCoverage
    {
        private TestRunConfigurationCodeCoverageCodeCoverageItem[] regularField;

        private TestRunConfigurationCodeCoverageAspNetCodeCoverageItem[] aspNetField;

        private bool enabledField;

        private bool perTestField;

        private bool instrumentInPlaceField;

        private string keyFileField;

        [XmlArrayItem("AspNetCodeCoverageItem", IsNullable=false)]
        public TestRunConfigurationCodeCoverageAspNetCodeCoverageItem[] AspNet
        {
            get
            {
                return this.aspNetField;
            }

            set
            {
                this.aspNetField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool enabled
        {
            get
            {
                return this.enabledField;
            }

            set
            {
                this.enabledField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool instrumentInPlace
        {
            get
            {
                return this.instrumentInPlaceField;
            }

            set
            {
                this.instrumentInPlaceField = value;
            }
        }

        [XmlAttribute]
        public string keyFile
        {
            get
            {
                return this.keyFileField;
            }

            set
            {
                this.keyFileField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool perTest
        {
            get
            {
                return this.perTestField;
            }

            set
            {
                this.perTestField = value;
            }
        }

        [XmlArrayItem("CodeCoverageItem", IsNullable=false)]
        public TestRunConfigurationCodeCoverageCodeCoverageItem[] Regular
        {
            get
            {
                return this.regularField;
            }

            set
            {
                this.regularField = value;
            }
        }

        public TestRunConfigurationCodeCoverage()
        {
            this.enabledField = false;
            this.perTestField = false;
            this.instrumentInPlaceField = true;
        }
    }
}