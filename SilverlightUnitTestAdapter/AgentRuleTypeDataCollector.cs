// <copyright file="AgentRuleTypeDataCollector.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class AgentRuleTypeDataCollector
    {
        private AgentRuleTypeDataCollectorConfiguration configurationField;

        private string uriField;

        private string friendlyNameField;

        private string assemblyQualifiedNameField;

        private bool enabledField;

        [XmlAttribute]
        public string assemblyQualifiedName
        {
            get
            {
                return this.assemblyQualifiedNameField;
            }

            set
            {
                this.assemblyQualifiedNameField = value;
            }
        }

        public AgentRuleTypeDataCollectorConfiguration Configuration
        {
            get
            {
                return this.configurationField;
            }

            set
            {
                this.configurationField = value;
            }
        }

        [DefaultValue(true)]
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
        public string friendlyName
        {
            get
            {
                return this.friendlyNameField;
            }

            set
            {
                this.friendlyNameField = value;
            }
        }

        [XmlAttribute(DataType="anyURI")]
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

        public AgentRuleTypeDataCollector()
        {
            this.enabledField = true;
        }
    }
}