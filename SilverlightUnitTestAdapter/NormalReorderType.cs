// <copyright file="NormalReorderType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class NormalReorderType
    {
        private decimal rateField;

        private double deviationField;

        private ushort maxPacketLagField;

        public double Deviation
        {
            get
            {
                return this.deviationField;
            }

            set
            {
                this.deviationField = value;
            }
        }

        public ushort MaxPacketLag
        {
            get
            {
                return this.maxPacketLagField;
            }

            set
            {
                this.maxPacketLagField = value;
            }
        }

        public decimal Rate
        {
            get
            {
                return this.rateField;
            }

            set
            {
                this.rateField = value;
            }
        }
    }
}