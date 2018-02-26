// <copyright file="VirtualLink.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class VirtualLink
    {
        private LinkRule[] linkRuleField;

        private string nameField;

        private ushort instancesField;

        private bool instancesFieldSpecified;

        [XmlAttribute]
        public ushort instances
        {
            get
            {
                return this.instancesField;
            }

            set
            {
                this.instancesField = value;
            }
        }

        [XmlIgnore]
        public bool instancesSpecified
        {
            get
            {
                return this.instancesFieldSpecified;
            }

            set
            {
                this.instancesFieldSpecified = value;
            }
        }

        [XmlElement("LinkRule")]
        public LinkRule[] LinkRule
        {
            get
            {
                return this.linkRuleField;
            }

            set
            {
                this.linkRuleField = value;
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
    }
}