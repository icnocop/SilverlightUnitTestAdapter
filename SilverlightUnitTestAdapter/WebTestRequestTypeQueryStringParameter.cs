// <copyright file="WebTestRequestTypeQueryStringParameter.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class WebTestRequestTypeQueryStringParameter
    {
        private string nameField;

        private string valueField;

        private bool useToGroupResultsField;

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

        [DefaultValue(false)]
        [XmlAttribute]
        public bool useToGroupResults
        {
            get
            {
                return this.useToGroupResultsField;
            }

            set
            {
                this.useToGroupResultsField = value;
            }
        }

        [XmlAttribute]
        public string value
        {
            get
            {
                return this.valueField;
            }

            set
            {
                this.valueField = value;
            }
        }

        public WebTestRequestTypeQueryStringParameter()
        {
            this.useToGroupResultsField = false;
        }
    }
}