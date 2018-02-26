// <copyright file="AgentRuleCollectionType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class AgentRuleCollectionType
    {
        private AgentRuleType[] agentRulesField;

        private bool enabledField;

        [XmlArrayItem("AgentRule", IsNullable=false)]
        public AgentRuleType[] AgentRules
        {
            get
            {
                return this.agentRulesField;
            }

            set
            {
                this.agentRulesField = value;
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

        public AgentRuleCollectionType()
        {
            this.enabledField = true;
        }
    }
}