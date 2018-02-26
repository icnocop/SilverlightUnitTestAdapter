// <copyright file="VirtualChannel.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class VirtualChannel
    {
        private FilterList filterListField;

        private VirtualLink[] virtualLinkField;

        private string nameField;

        private VirtualChannelDispatchType dispatchTypeField;

        private bool dispatchTypeFieldSpecified;

        [XmlAttribute]
        public VirtualChannelDispatchType DispatchType
        {
            get
            {
                return this.dispatchTypeField;
            }

            set
            {
                this.dispatchTypeField = value;
            }
        }

        [XmlIgnore]
        public bool DispatchTypeSpecified
        {
            get
            {
                return this.dispatchTypeFieldSpecified;
            }

            set
            {
                this.dispatchTypeFieldSpecified = value;
            }
        }

        public FilterList FilterList
        {
            get
            {
                return this.filterListField;
            }

            set
            {
                this.filterListField = value;
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

        [XmlElement("VirtualLink")]
        public VirtualLink[] VirtualLink
        {
            get
            {
                return this.virtualLinkField;
            }

            set
            {
                this.virtualLinkField = value;
            }
        }
    }
}