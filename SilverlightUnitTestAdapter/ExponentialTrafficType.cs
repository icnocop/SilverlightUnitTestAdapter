// <copyright file="ExponentialTrafficType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlInclude(typeof(ParetoTrafficType))]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class ExponentialTrafficType : ConstantTrafficType
    {
        private SecType burstTimeField;

        private SecType idleTimeField;

        public SecType BurstTime
        {
            get
            {
                return this.burstTimeField;
            }

            set
            {
                this.burstTimeField = value;
            }
        }

        public SecType IdleTime
        {
            get
            {
                return this.idleTimeField;
            }

            set
            {
                this.idleTimeField = value;
            }
        }
    }
}