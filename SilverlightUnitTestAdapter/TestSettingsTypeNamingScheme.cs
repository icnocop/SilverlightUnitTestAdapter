// <copyright file="TestSettingsTypeNamingScheme.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestSettingsTypeNamingScheme
    {
        private string baseNameField;

        private bool appendTimeStampField;

        private bool useDefaultField;

        [DefaultValue(true)]
        [XmlAttribute]
        public bool appendTimeStamp
        {
            get
            {
                return this.appendTimeStampField;
            }

            set
            {
                this.appendTimeStampField = value;
            }
        }

        [XmlAttribute]
        public string baseName
        {
            get
            {
                return this.baseNameField;
            }

            set
            {
                this.baseNameField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool useDefault
        {
            get
            {
                return this.useDefaultField;
            }

            set
            {
                this.useDefaultField = value;
            }
        }

        public TestSettingsTypeNamingScheme()
        {
            this.appendTimeStampField = true;
            this.useDefaultField = true;
        }
    }
}