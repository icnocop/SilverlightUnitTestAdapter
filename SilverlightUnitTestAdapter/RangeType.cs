// <copyright file="RangeType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class RangeType
    {
        private string lowerField;

        private string upperField;

        [XmlAttribute]
        public string lower
        {
            get
            {
                return this.lowerField;
            }

            set
            {
                this.lowerField = value;
            }
        }

        [XmlAttribute]
        public string upper
        {
            get
            {
                return this.upperField;
            }

            set
            {
                this.upperField = value;
            }
        }
    }
}