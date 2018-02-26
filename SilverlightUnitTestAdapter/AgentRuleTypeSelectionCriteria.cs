// <copyright file="AgentRuleTypeSelectionCriteria.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class AgentRuleTypeSelectionCriteria
    {
        private NameValuePropertyType[] agentPropertyField;

        private bool selectAllAgentsField;

        private bool selectAllAgentsFieldSpecified;

        [XmlElement("AgentProperty")]
        public NameValuePropertyType[] AgentProperty
        {
            get
            {
                return this.agentPropertyField;
            }

            set
            {
                this.agentPropertyField = value;
            }
        }

        [XmlAttribute]
        public bool selectAllAgents
        {
            get
            {
                return this.selectAllAgentsField;
            }

            set
            {
                this.selectAllAgentsField = value;
            }
        }

        [XmlIgnore]
        public bool selectAllAgentsSpecified
        {
            get
            {
                return this.selectAllAgentsFieldSpecified;
            }

            set
            {
                this.selectAllAgentsFieldSpecified = value;
            }
        }
    }
}