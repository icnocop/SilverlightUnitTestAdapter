// <copyright file="LoadTestTypeCounterSetsCounterSetDefaultCounter.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestTypeCounterSetsCounterSetDefaultCounter
    {
        private string categoryNameField;

        private string counterNameField;

        private string instanceNameField;

        private string graphNameField;

        private int rangeField;

        private bool rangeFieldSpecified;

        private string runTypeField;

        [XmlAttribute]
        public string CategoryName
        {
            get
            {
                return this.categoryNameField;
            }

            set
            {
                this.categoryNameField = value;
            }
        }

        [XmlAttribute]
        public string CounterName
        {
            get
            {
                return this.counterNameField;
            }

            set
            {
                this.counterNameField = value;
            }
        }

        [XmlAttribute]
        public string GraphName
        {
            get
            {
                return this.graphNameField;
            }

            set
            {
                this.graphNameField = value;
            }
        }

        [XmlAttribute]
        public string InstanceName
        {
            get
            {
                return this.instanceNameField;
            }

            set
            {
                this.instanceNameField = value;
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

        [XmlAttribute]
        public string RunType
        {
            get
            {
                return this.runTypeField;
            }

            set
            {
                this.runTypeField = value;
            }
        }
    }
}