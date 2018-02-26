// <copyright file="Filter.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class Filter
    {
        private IpVersion ipVersionField;

        private bool ipVersionFieldSpecified;

        private Protocol protocolField;

        private bool protocolFieldSpecified;

        private string physicalAddressField;

        private AddressType localField;

        private AddressType remoteField;

        private string nameField;

        private bool notField;

        public IpVersion IpVersion
        {
            get
            {
                return this.ipVersionField;
            }

            set
            {
                this.ipVersionField = value;
            }
        }

        [XmlIgnore]
        public bool IpVersionSpecified
        {
            get
            {
                return this.ipVersionFieldSpecified;
            }

            set
            {
                this.ipVersionFieldSpecified = value;
            }
        }

        public AddressType Local
        {
            get
            {
                return this.localField;
            }

            set
            {
                this.localField = value;
            }
        }

        [XmlAttribute(DataType="ID")]
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

        [DefaultValue(false)]
        [XmlAttribute]
        public bool not
        {
            get
            {
                return this.notField;
            }

            set
            {
                this.notField = value;
            }
        }

        [XmlElement(DataType="token")]
        public string PhysicalAddress
        {
            get
            {
                return this.physicalAddressField;
            }

            set
            {
                this.physicalAddressField = value;
            }
        }

        public Protocol Protocol
        {
            get
            {
                return this.protocolField;
            }

            set
            {
                this.protocolField = value;
            }
        }

        [XmlIgnore]
        public bool ProtocolSpecified
        {
            get
            {
                return this.protocolFieldSpecified;
            }

            set
            {
                this.protocolFieldSpecified = value;
            }
        }

        public AddressType Remote
        {
            get
            {
                return this.remoteField;
            }

            set
            {
                this.remoteField = value;
            }
        }

        public Filter()
        {
            this.notField = false;
        }
    }
}