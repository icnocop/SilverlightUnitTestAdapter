// <copyright file="WebDataType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class WebDataType
    {
        private WebDataTypeHeaders headersField;

        private string urlField;

        private string commandField;

        private string contentTypeField;

        private string encodingNameField;

        [XmlAttribute]
        public string command
        {
            get
            {
                return this.commandField;
            }

            set
            {
                this.commandField = value;
            }
        }

        [XmlAttribute]
        public string contentType
        {
            get
            {
                return this.contentTypeField;
            }

            set
            {
                this.contentTypeField = value;
            }
        }

        [XmlAttribute]
        public string encodingName
        {
            get
            {
                return this.encodingNameField;
            }

            set
            {
                this.encodingNameField = value;
            }
        }

        public WebDataTypeHeaders Headers
        {
            get
            {
                return this.headersField;
            }

            set
            {
                this.headersField = value;
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