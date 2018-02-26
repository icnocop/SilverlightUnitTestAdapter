// <copyright file="StatisticalType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlInclude(typeof(StatisticalErrorType))]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class StatisticalType
    {
        private decimal goodField;

        private decimal goodToBadField;

        private decimal badField;

        private decimal badToGoodField;

        private SecType switchTimeField;

        public decimal Bad
        {
            get
            {
                return this.badField;
            }

            set
            {
                this.badField = value;
            }
        }

        public decimal BadToGood
        {
            get
            {
                return this.badToGoodField;
            }

            set
            {
                this.badToGoodField = value;
            }
        }

        public decimal Good
        {
            get
            {
                return this.goodField;
            }

            set
            {
                this.goodField = value;
            }
        }

        public decimal GoodToBad
        {
            get
            {
                return this.goodToBadField;
            }

            set
            {
                this.goodToBadField = value;
            }
        }

        public SecType SwitchTime
        {
            get
            {
                return this.switchTimeField;
            }

            set
            {
                this.switchTimeField = value;
            }
        }
    }
}