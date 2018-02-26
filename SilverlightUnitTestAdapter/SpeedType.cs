// <copyright file="SpeedType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class SpeedType
    {
        private SpeedTypeUnit unitField;

        private double valueField;

        [XmlAttribute]
        public SpeedTypeUnit unit
        {
            get
            {
                return this.unitField;
            }

            set
            {
                this.unitField = value;
            }
        }

        [XmlText]
        public double Value
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
    }
}