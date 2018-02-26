// <copyright file="MsecType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class MsecType
    {
        private MsecTypeUnit unitField;

        private bool unitFieldSpecified;

        private string valueField;

        [XmlAttribute]
        public MsecTypeUnit unit
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

        [XmlIgnore]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }

            set
            {
                this.unitFieldSpecified = value;
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
    }
}