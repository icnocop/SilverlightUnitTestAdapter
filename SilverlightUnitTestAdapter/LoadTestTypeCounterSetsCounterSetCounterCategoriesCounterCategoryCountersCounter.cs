// <copyright file="LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounter.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounter
    {
        private LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRules thresholdRulesField;

        private string nameField;

        private int rangeField;

        private bool rangeFieldSpecified;

        private string rangeGroupField;

        private bool higherIsBetterField;

        [DefaultValue(false)]
        [XmlAttribute]
        public bool HigherIsBetter
        {
            get
            {
                return this.higherIsBetterField;
            }

            set
            {
                this.higherIsBetterField = value;
            }
        }

        [XmlAttribute]
        public string Name
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

        [XmlAttribute]
        public int Range
        {
            get
            {
                return this.rangeField;
            }

            set
            {
                this.rangeField = value;
            }
        }

        [XmlAttribute]
        public string RangeGroup
        {
            get
            {
                return this.rangeGroupField;
            }

            set
            {
                this.rangeGroupField = value;
            }
        }

        [XmlIgnore]
        public bool RangeSpecified
        {
            get
            {
                return this.rangeFieldSpecified;
            }

            set
            {
                this.rangeFieldSpecified = value;
            }
        }

        public LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRules ThresholdRules
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

        public LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounter()
        {
            this.higherIsBetterField = false;
        }
    }
}