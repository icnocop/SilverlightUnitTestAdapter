// <copyright file="AgentRuleType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class AgentRuleType
    {
        private AgentRuleTypeSelectionCriteria selectionCriteriaField;

        private AgentRuleTypeDataCollector[] dataCollectorsField;

        private string nameField;

        [XmlArrayItem("DataCollector", IsNullable=false)]
        public AgentRuleTypeDataCollector[] DataCollectors
        {
            get
            {
                return this.dataCollectorsField;
            }

            set
            {
                this.dataCollectorsField = value;
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

        public AgentRuleTypeSelectionCriteria SelectionCriteria
        {
            get
            {
                return this.selectionCriteriaField;
            }

            set
            {
                this.selectionCriteriaField = value;
            }
        }
    }
}