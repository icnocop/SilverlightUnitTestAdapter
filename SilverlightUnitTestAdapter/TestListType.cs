// <copyright file="TestListType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestListType
    {
        private object descriptionField;

        private LinkType runConfigurationField;

        private LinkType[] testLinksField;

        private string idField;

        private string nameField;

        private bool enabledField;

        private string parentListIdField;

        public object Description
        {
            get
            {
                return this.descriptionField;
            }

            set
            {
                this.descriptionField = value;
            }
        }

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

        [DefaultValue("00000000-0000-0000-0000-000000000000")]
        [XmlAttribute]
        public string parentListId
        {
            get
            {
                return this.parentListIdField;
            }

            set
            {
                this.parentListIdField = value;
            }
        }

        public LinkType RunConfiguration
        {
            get
            {
                return this.runConfigurationField;
            }

            set
            {
                this.runConfigurationField = value;
            }
        }

        [XmlArrayItem("TestLink", IsNullable=false)]
        public LinkType[] TestLinks
        {
            get
            {
                return this.testLinksField;
            }

            set
            {
                this.testLinksField = value;
            }
        }

        public TestListType()
        {
            this.enabledField = true;
            this.parentListIdField = "00000000-0000-0000-0000-000000000000";
        }
    }
}