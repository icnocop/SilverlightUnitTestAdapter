// <copyright file="ConstantTrafficType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlInclude(typeof(ExponentialTrafficType))]
    [XmlInclude(typeof(ParetoTrafficType))]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class ConstantTrafficType
    {
        private SpeedType rateField;

        private SizeType packetSizeField;

        public SizeType PacketSize
        {
            get
            {
                return this.packetSizeField;
            }

            set
            {
                this.packetSizeField = value;
            }
        }

        public SpeedType Rate
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