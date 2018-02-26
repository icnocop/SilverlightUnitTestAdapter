// <copyright file="LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategory.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategory
    {
        private LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCounters countersField;

        private LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryInstances instancesField;

        private string nameField;

        public LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCounters Counters
        {
            get
            {
                return this.countersField;
            }

            set
            {
                this.countersField = value;
            }
        }

        public LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryInstances Instances
        {
            get
            {
                return this.instancesField;
            }

            set
            {
                this.instancesField = value;
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