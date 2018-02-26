// <copyright file="TestRunConfigurationCodeCoverageCodeCoverageItem.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestRunConfigurationCodeCoverageCodeCoverageItem
    {
        private TestRunConfigurationCodeCoverageCodeCoverageItemKeyFile[] keyFileField;

        private string binaryFileField;

        private string pdbFileField;

        private string outputDirectoryField;

        private bool instrumentInPlaceField;

        [XmlAttribute]
        public string binaryFile
        {
            get
            {
                return this.binaryFileField;
            }

            set
            {
                this.binaryFileField = value;
            }
        }

        [DefaultValue(false)]
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

        [XmlElement("KeyFile")]
        public TestRunConfigurationCodeCoverageCodeCoverageItemKeyFile[] KeyFile
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

        [XmlAttribute]
        public string outputDirectory
        {
            get
            {
                return this.outputDirectoryField;
            }

            set
            {
                this.outputDirectoryField = value;
            }
        }

        [XmlAttribute]
        public string pdbFile
        {
            get
            {
                return this.pdbFileField;
            }

            set
            {
                this.pdbFileField = value;
            }
        }

        public TestRunConfigurationCodeCoverageCodeCoverageItem()
        {
            this.instrumentInPlaceField = false;
        }
    }
}