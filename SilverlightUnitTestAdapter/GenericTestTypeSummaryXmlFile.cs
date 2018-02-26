// <copyright file="GenericTestTypeSummaryXmlFile.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class GenericTestTypeSummaryXmlFile
    {
        private string pathField;

        private bool enabledField;

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

        public GenericTestTypeSummaryXmlFile()
        {
            this.enabledField = false;
        }
    }
}