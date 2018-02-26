// <copyright file="LinkType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LinkType
    {
        private string idField;

        private string nameField;

        private string storageField;

        private bool enabledField;

        private string typeField;

        [DefaultValue(true)]
        [XmlAttribute]
        public bool enabled
        {
            get
            {
                return this.enabledField;
            }

            set
            {
                this.enabledField = value;
            }
        }

        [XmlAttribute]
        public string id
        {
            get
            {
                return this.idField;
            }

            set
            {
                this.idField = value;
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

        [XmlAttribute]
        public string storage
        {
            get
            {
                return this.storageField;
            }

            set
            {
                this.storageField = value;
            }
        }

        [XmlAttribute]
        public string type
        {
            get
            {
                return this.typeField;
            }

            set
            {
                this.typeField = value;
            }
        }

        public LinkType()
        {
            this.enabledField = true;
        }
    }
}