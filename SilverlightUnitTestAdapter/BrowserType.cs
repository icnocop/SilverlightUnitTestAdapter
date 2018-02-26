// <copyright file="BrowserType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class BrowserType
    {
        private HeadersTypeHeader[] headersField;

        private string nameField;

        private int maxConnectionsField;

        private bool maxConnectionsFieldSpecified;

        [XmlArrayItem("Header", IsNullable=false)]
        public HeadersTypeHeader[] Headers
        {
            get
            {
                return this.headersField;
            }

            set
            {
                this.headersField = value;
            }
        }

        [XmlAttribute]
        public int MaxConnections
        {
            get
            {
                return this.maxConnectionsField;
            }

            set
            {
                this.maxConnectionsField = value;
            }
        }

        [XmlIgnore]
        public bool MaxConnectionsSpecified
        {
            get
            {
                return this.maxConnectionsFieldSpecified;
            }

            set
            {
                this.maxConnectionsFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }
    }
}