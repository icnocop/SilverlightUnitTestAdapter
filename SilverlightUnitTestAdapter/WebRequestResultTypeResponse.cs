// <copyright file="WebRequestResultTypeResponse.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class WebRequestResultTypeResponse
    {
        private object headersField;

        private string urlField;

        private string contentTypeField;

        private string statusLineField;

        private string pageTimeField;

        private string timeField;

        private string statusCodeStringField;

        private string contentLengthField;

        [XmlAttribute]
        public string contentLength
        {
            get
            {
                return this.contentLengthField;
            }

            set
            {
                this.contentLengthField = value;
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
        public string pageTime
        {
            get
            {
                return this.pageTimeField;
            }

            set
            {
                this.pageTimeField = value;
            }
        }

        [XmlAttribute]
        public string statusCodeString
        {
            get
            {
                return this.statusCodeStringField;
            }

            set
            {
                this.statusCodeStringField = value;
            }
        }

        [XmlAttribute]
        public string statusLine
        {
            get
            {
                return this.statusLineField;
            }

            set
            {
                this.statusLineField = value;
            }
        }

        [XmlAttribute]
        public string time
        {
            get
            {
                return this.timeField;
            }

            set
            {
                this.timeField = value;
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