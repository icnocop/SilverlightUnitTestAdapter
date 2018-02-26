// <copyright file="LoadTestResultTypeSummaryPerformanceCounterResult.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestResultTypeSummaryPerformanceCounterResult
    {
        private string machineNameField;

        private string categoryNameField;

        private string instanceNameField;

        private string counterNameField;

        private double valueField;

        private bool isOverallResultCounterField;

        private bool higherIsBetterField;

        [XmlAttribute]
        public string categoryName
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
        public string counterName
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

        [DefaultValue(true)]
        [XmlAttribute]
        public bool higherIsBetter
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
        public string instanceName
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

        [DefaultValue(true)]
        [XmlAttribute]
        public bool isOverallResultCounter
        {
            get
            {
                return this.isOverallResultCounterField;
            }

            set
            {
                this.isOverallResultCounterField = value;
            }
        }

        [XmlAttribute]
        public string machineName
        {
            get
            {
                return this.machineNameField;
            }

            set
            {
                this.machineNameField = value;
            }
        }

        [XmlAttribute]
        public double value
        {
            get
            {
                return this.valueField;
            }

            set
            {
                this.valueField = value;
            }
        }

        public LoadTestResultTypeSummaryPerformanceCounterResult()
        {
            this.isOverallResultCounterField = true;
            this.higherIsBetterField = true;
        }
    }
}