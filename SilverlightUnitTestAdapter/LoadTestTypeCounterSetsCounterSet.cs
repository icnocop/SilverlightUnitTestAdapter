// <copyright file="LoadTestTypeCounterSetsCounterSet.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestTypeCounterSetsCounterSet
    {
        private LoadTestTypeCounterSetsCounterSetCounterCategories counterCategoriesField;

        private LoadTestTypeCounterSetsCounterSetDefaultCounter[] defaultCountersForAutomaticGraphsField;

        private string nameField;

        private string counterSetTypeField;

        private string locIdField;

        public LoadTestTypeCounterSetsCounterSetCounterCategories CounterCategories
        {
            get
            {
                return this.counterCategoriesField;
            }

            set
            {
                this.counterCategoriesField = value;
            }
        }

        [XmlAttribute]
        public string CounterSetType
        {
            get
            {
                return this.counterSetTypeField;
            }

            set
            {
                this.counterSetTypeField = value;
            }
        }

        [XmlArrayItem("DefaultCounter", IsNullable=false)]
        public LoadTestTypeCounterSetsCounterSetDefaultCounter[] DefaultCountersForAutomaticGraphs
        {
            get
            {
                return this.defaultCountersForAutomaticGraphsField;
            }

            set
            {
                this.defaultCountersForAutomaticGraphsField = value;
            }
        }

        [XmlAttribute]
        public string LocId
        {
            get
            {
                return this.locIdField;
            }

            set
            {
                this.locIdField = value;
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
    }
}