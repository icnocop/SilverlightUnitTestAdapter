// <copyright file="BurstLatencyType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class BurstLatencyType
    {
        private MsecType timeField;

        private SecType periodMinField;

        private SecType periodMaxField;

        private decimal probabilityField;

        public SecType PeriodMax
        {
            get
            {
                return this.periodMaxField;
            }

            set
            {
                this.periodMaxField = value;
            }
        }

        public SecType PeriodMin
        {
            get
            {
                return this.periodMinField;
            }

            set
            {
                this.periodMinField = value;
            }
        }

        public decimal Probability
        {
            get
            {
                return this.probabilityField;
            }

            set
            {
                this.probabilityField = value;
            }
        }

        public MsecType Time
        {
            get
            {
                return this.timeField;
            }

            set
            {
                this.timeField = value;
            }
        }
    }
}