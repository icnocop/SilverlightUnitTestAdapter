// <copyright file="BurstLossType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class BurstLossType
    {
        private decimal rateField;

        private string minPacketField;

        private string maxPacketField;

        [XmlElement(DataType="positiveInteger")]
        public string MaxPacket
        {
            get
            {
                return this.maxPacketField;
            }

            set
            {
                this.maxPacketField = value;
            }
        }

        [XmlElement(DataType="positiveInteger")]
        public string MinPacket
        {
            get
            {
                return this.minPacketField;
            }

            set
            {
                this.minPacketField = value;
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