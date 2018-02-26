// <copyright file="CounterType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class CounterType
    {
        private CounterTypeThresholdRule[] thresholdRulesField;

        private string nameField;

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

        [XmlArrayItem("ThresholdRule", IsNullable=false)]
        public CounterTypeThresholdRule[] ThresholdRules
        {
            get
            {
                return this.thresholdRulesField;
            }

            set
            {
                this.thresholdRulesField = value;
            }
        }
    }
}