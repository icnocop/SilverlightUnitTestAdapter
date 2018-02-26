// <copyright file="LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRule.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRule
    {
        private LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRuleRuleParameters ruleParametersField;

        private string classnameField;

        [XmlAttribute]
        public string Classname
        {
            get
            {
                return this.classnameField;
            }

            set
            {
                this.classnameField = value;
            }
        }

        public LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRuleRuleParameters RuleParameters
        {
            get
            {
                return this.ruleParametersField;
            }

            set
            {
                this.ruleParametersField = value;
            }
        }
    }
}