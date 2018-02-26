// <copyright file="RuleResultType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class RuleResultType
    {
        private RuleResultTypeRuleProperty[] rulePropertiesField;

        private string nameField;

        private string ruleTypeField;

        private bool successField;

        private string messageField;

        [XmlAttribute]
        public string message
        {
            get
            {
                return this.messageField;
            }

            set
            {
                this.messageField = value;
            }
        }

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

        [XmlArrayItem("RuleProperty", IsNullable=false)]
        public RuleResultTypeRuleProperty[] RuleProperties
        {
            get
            {
                return this.rulePropertiesField;
            }

            set
            {
                this.rulePropertiesField = value;
            }
        }

        [XmlAttribute]
        public string ruleType
        {
            get
            {
                return this.ruleTypeField;
            }

            set
            {
                this.ruleTypeField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool success
        {
            get
            {
                return this.successField;
            }

            set
            {
                this.successField = value;
            }
        }

        public RuleResultType()
        {
            this.successField = false;
        }
    }
}