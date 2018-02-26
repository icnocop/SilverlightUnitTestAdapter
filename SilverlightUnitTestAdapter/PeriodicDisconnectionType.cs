// <copyright file="PeriodicDisconnectionType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class PeriodicDisconnectionType
    {
        private decimal rateField;

        private SecType connectionTimeField;

        private SecType disconnectionTimeField;

        public SecType ConnectionTime
        {
            get
            {
                return this.connectionTimeField;
            }

            set
            {
                this.connectionTimeField = value;
            }
        }

        public SecType DisconnectionTime
        {
            get
            {
                return this.disconnectionTimeField;
            }

            set
            {
                this.disconnectionTimeField = value;
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