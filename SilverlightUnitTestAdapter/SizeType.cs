// <copyright file="SizeType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class SizeType
    {
        private SizeTypeUnit unitField;

        private string valueField;

        [DefaultValue(SizeTypeUnit.@byte)]
        [XmlAttribute]
        public SizeTypeUnit unit
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

        [XmlText(DataType="positiveInteger")]
        public string Value
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

        public SizeType()
        {
            this.unitField = SizeTypeUnit.@byte;
        }
    }
}