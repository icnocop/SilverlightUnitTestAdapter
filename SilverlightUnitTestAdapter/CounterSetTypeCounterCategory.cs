// <copyright file="CounterSetTypeCounterCategory.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class CounterSetTypeCounterCategory
    {
        private CounterType[] countersField;

        private object instancesField;

        private string nameField;

        [XmlArrayItem("Counter", IsNullable=false)]
        public CounterType[] Counters
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

        public object Instances
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