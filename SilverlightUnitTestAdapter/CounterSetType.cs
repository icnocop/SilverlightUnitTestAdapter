// <copyright file="CounterSetType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class CounterSetType
    {
        private CounterSetTypeCounterCategory[] counterCategoriesField;

        private string nameField;

        private string counterSetTypeField;

        [XmlArrayItem("CounterCategory", IsNullable=false)]
        public CounterSetTypeCounterCategory[] CounterCategories
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
        public string counterSetType
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
    }
}