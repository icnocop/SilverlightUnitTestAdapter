// <copyright file="WebTestRequestType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class WebTestRequestType
    {
        private WebTestRequestTypeStringHttpBody stringHttpBodyField;

        private WebTestRequestType[] dependentRequestsField;

        private HeadersTypeHeader[] headersField;

        private WebTestRequestTypeExtractionRule[] extractionRulesField;

        private WebTestRequestTypeQueryStringParameter[] queryStringParametersField;

        private WebTestRequestTypeFormPostHttpBody formPostHttpBodyField;

        private string guidField;

        private string methodField;

        private decimal versionField;

        private bool versionFieldSpecified;

        private string urlField;

        private byte thinkTimeField;

        private bool thinkTimeFieldSpecified;

        private byte timeoutField;

        private bool timeoutFieldSpecified;

        private bool parseLinksField;

        private bool followRedirectsField;

        private bool cacheField;

        [DefaultValue(true)]
        [XmlAttribute]
        public bool cache
        {
            get
            {
                return this.cacheField;
            }

            set
            {
                this.cacheField = value;
            }
        }

        [XmlArrayItem("Request", IsNullable=false)]
        public WebTestRequestType[] DependentRequests
        {
            get
            {
                return this.dependentRequestsField;
            }

            set
            {
                this.dependentRequestsField = value;
            }
        }

        [XmlArrayItem("ExtractionRule", IsNullable=false)]
        public WebTestRequestTypeExtractionRule[] ExtractionRules
        {
            get
            {
                return this.extractionRulesField;
            }

            set
            {
                this.extractionRulesField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool followRedirects
        {
            get
            {
                return this.followRedirectsField;
            }

            set
            {
                this.followRedirectsField = value;
            }
        }

        public WebTestRequestTypeFormPostHttpBody FormPostHttpBody
        {
            get
            {
                return this.formPostHttpBodyField;
            }

            set
            {
                this.formPostHttpBodyField = value;
            }
        }

        [XmlAttribute]
        public string Guid
        {
            get
            {
                return this.guidField;
            }

            set
            {
                this.guidField = value;
            }
        }

        [XmlArrayItem("Header", IsNullable=false)]
        public HeadersTypeHeader[] Headers
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
        public string method
        {
            get
            {
                return this.methodField;
            }

            set
            {
                this.methodField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool parseLinks
        {
            get
            {
                return this.parseLinksField;
            }

            set
            {
                this.parseLinksField = value;
            }
        }

        [XmlArrayItem("QueryStringParameter", IsNullable=false)]
        public WebTestRequestTypeQueryStringParameter[] QueryStringParameters
        {
            get
            {
                return this.queryStringParametersField;
            }

            set
            {
                this.queryStringParametersField = value;
            }
        }

        public WebTestRequestTypeStringHttpBody StringHttpBody
        {
            get
            {
                return this.stringHttpBodyField;
            }

            set
            {
                this.stringHttpBodyField = value;
            }
        }

        [XmlAttribute]
        public byte thinkTime
        {
            get
            {
                return this.thinkTimeField;
            }

            set
            {
                this.thinkTimeField = value;
            }
        }

        [XmlIgnore]
        public bool thinkTimeSpecified
        {
            get
            {
                return this.thinkTimeFieldSpecified;
            }

            set
            {
                this.thinkTimeFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public byte timeout
        {
            get
            {
                return this.timeoutField;
            }

            set
            {
                this.timeoutField = value;
            }
        }

        [XmlIgnore]
        public bool timeoutSpecified
        {
            get
            {
                return this.timeoutFieldSpecified;
            }

            set
            {
                this.timeoutFieldSpecified = value;
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

        [XmlAttribute]
        public decimal version
        {
            get
            {
                return this.versionField;
            }

            set
            {
                this.versionField = value;
            }
        }

        [XmlIgnore]
        public bool versionSpecified
        {
            get
            {
                return this.versionFieldSpecified;
            }

            set
            {
                this.versionFieldSpecified = value;
            }
        }

        public WebTestRequestType()
        {
            this.parseLinksField = true;
            this.followRedirectsField = true;
            this.cacheField = true;
        }
    }
}