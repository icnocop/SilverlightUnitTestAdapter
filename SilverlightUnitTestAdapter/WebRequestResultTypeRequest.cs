// <copyright file="WebRequestResultTypeRequest.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class WebRequestResultTypeRequest
    {
        private object headersField;

        private string urlField;

        private string commandField;

        private string contentTypeField;

        private string encodingField;

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
        public string encoding
        {
            get
            {
                return this.encodingField;
            }

            set
            {
                this.encodingField = value;
            }
        }

        public object Headers
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