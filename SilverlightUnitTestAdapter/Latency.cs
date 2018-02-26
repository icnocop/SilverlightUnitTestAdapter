// <copyright file="Latency.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlRoot(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable=false)]
    [XmlType(AnonymousType=true, Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class Latency
    {
        private object itemField;

        [XmlElement("Burst", typeof(BurstLatencyType))]
        [XmlElement("Fixed", typeof(FixedLatencyType))]
        [XmlElement("Linear", typeof(LinearLatencyType))]
        [XmlElement("Normal", typeof(NormalLatencyType))]
        [XmlElement("Uniform", typeof(UniformLatencyType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }

            set
            {
                this.itemField = value;
            }
        }
    }
}