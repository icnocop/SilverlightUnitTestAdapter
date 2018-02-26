// <copyright file="CollectorType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class CollectorType
    {
        private UriAttachmentType[] uriAttachmentsField;

        private string agentNameField;

        private string agentDisplayNameField;

        private string collectorDisplayNameField;

        private bool isFromRemoteAgentField;

        private string uriField;

        [XmlAttribute]
        public string agentDisplayName
        {
            get
            {
                return this.agentDisplayNameField;
            }

            set
            {
                this.agentDisplayNameField = value;
            }
        }

        [XmlAttribute]
        public string agentName
        {
            get
            {
                return this.agentNameField;
            }

            set
            {
                this.agentNameField = value;
            }
        }

        [XmlAttribute]
        public string collectorDisplayName
        {
            get
            {
                return this.collectorDisplayNameField;
            }

            set
            {
                this.collectorDisplayNameField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool isFromRemoteAgent
        {
            get
            {
                return this.isFromRemoteAgentField;
            }

            set
            {
                this.isFromRemoteAgentField = value;
            }
        }

        [XmlAttribute]
        public string uri
        {
            get
            {
                return this.uriField;
            }

            set
            {
                this.uriField = value;
            }
        }

        [XmlArrayItem("UriAttachment", IsNullable=false)]
        public UriAttachmentType[] UriAttachments
        {
            get
            {
                return this.uriAttachmentsField;
            }

            set
            {
                this.uriAttachmentsField = value;
            }
        }

        public CollectorType()
        {
            this.isFromRemoteAgentField = false;
        }
    }
}