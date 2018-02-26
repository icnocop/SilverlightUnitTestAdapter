// <copyright file="BaseTestType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlInclude(typeof(CodedWebTestElementType))]
    [XmlInclude(typeof(DeclarativeWebTestElementType))]
    [XmlInclude(typeof(GenericTestType))]
    [XmlInclude(typeof(OrderedTestType))]
    [XmlInclude(typeof(PlainTextManualTestType))]
    [XmlInclude(typeof(UnitTestType))]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public abstract class BaseTestType
    {
        private object[] itemsField;

        private bool enabledField;

        private string idField;

        private string nameField;

        private bool isGroupableField;

        private int priorityField;

        private string namedCategoryField;

        private string storageField;

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

        [DefaultValue(true)]
        [XmlAttribute]
        public bool isGroupable
        {
            get
            {
                return this.isGroupableField;
            }

            set
            {
                this.isGroupableField = value;
            }
        }

        [XmlElement("Agent", typeof(BaseTestTypeAgent))]
        [XmlElement("Command", typeof(GenericTestTypeCommand))]
        [XmlElement("Css", typeof(BaseTestTypeCss))]
        [XmlElement("DeploymentItems", typeof(BaseTestTypeDeploymentItems))]
        [XmlElement("Description", typeof(object))]
        [XmlElement("Execution", typeof(BaseTestTypeExecution))]
        [XmlElement("IncludedWebTests", typeof(CodedWebTestElementTypeIncludedWebTests))]
        [XmlElement("Owners", typeof(BaseTestTypeOwners))]
        [XmlElement("Properties", typeof(BaseTestTypeProperties))]
        [XmlElement("SummaryXmlFile", typeof(GenericTestTypeSummaryXmlFile))]
        [XmlElement("TcmInformation", typeof(TcmInformationType))]
        [XmlElement("TestCategory", typeof(BaseTestTypeTestCategory))]
        [XmlElement("WebTestClass", typeof(CodedWebTestElementTypeWebTestClass))]
        [XmlElement("WorkItemIDs", typeof(WorkItemIDsType))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }

            set
            {
                this.itemsField = value;
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

        [DefaultValue("")]
        [XmlAttribute]
        public string namedCategory
        {
            get
            {
                return this.namedCategoryField;
            }

            set
            {
                this.namedCategoryField = value;
            }
        }

        [DefaultValue(2147483647)]
        [XmlAttribute]
        public int priority
        {
            get
            {
                return this.priorityField;
            }

            set
            {
                this.priorityField = value;
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

        public BaseTestType()
        {
            this.enabledField = true;
            this.isGroupableField = true;
            this.priorityField = 2147483647;
            this.namedCategoryField = "";
        }
    }
}