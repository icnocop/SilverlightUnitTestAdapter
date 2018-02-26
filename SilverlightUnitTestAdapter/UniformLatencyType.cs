// <copyright file="UniformLatencyType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlInclude(typeof(LinearLatencyType))]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class UniformLatencyType
    {
        private MsecType minField;

        private MsecType maxField;

        public MsecType Max
        {
            get
            {
                return this.maxField;
            }

            set
            {
                this.maxField = value;
            }
        }

        public MsecType Min
        {
            get
            {
                return this.minField;
            }

            set
            {
                this.minField = value;
            }
        }
    }
}