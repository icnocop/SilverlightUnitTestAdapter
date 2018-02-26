// <copyright file="Emulation.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class Emulation
    {
        private VirtualChannel virtualChannelField;

        private Timestamp[] timestampField;

        [XmlElement("Timestamp")]
        public Timestamp[] Timestamp
        {
            get
            {
                return this.timestampField;
            }

            set
            {
                this.timestampField = value;
            }
        }

        public VirtualChannel VirtualChannel
        {
            get
            {
                return this.virtualChannelField;
            }

            set
            {
                this.virtualChannelField = value;
            }
        }
    }
}