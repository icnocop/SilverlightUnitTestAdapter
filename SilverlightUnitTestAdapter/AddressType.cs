// <copyright file="AddressType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class AddressType
    {
        private string ipAddressField;

        private string ipMaskField;

        private ushort portBeginField;

        private ushort portEndField;

        [XmlElement(DataType="token")]
        public string IpAddress
        {
            get
            {
                return this.ipAddressField;
            }

            set
            {
                this.ipAddressField = value;
            }
        }

        [XmlElement(DataType="token")]
        public string IpMask
        {
            get
            {
                return this.ipMaskField;
            }

            set
            {
                this.ipMaskField = value;
            }
        }

        public ushort PortBegin
        {
            get
            {
                return this.portBeginField;
            }

            set
            {
                this.portBeginField = value;
            }
        }

        public ushort PortEnd
        {
            get
            {
                return this.portEndField;
            }

            set
            {
                this.portEndField = value;
            }
        }
    }
}