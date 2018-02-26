// <copyright file="TestDefinitionType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestDefinitionType
    {
        private object[] itemsField;

        private ItemsChoiceType4[] itemsElementNameField;

        [XmlAnyElement]
        [XmlChoiceIdentifier("ItemsElementName")]
        [XmlElement("CodedWebTest", typeof(CodedWebTestElementType))]
        [XmlElement("GenericTest", typeof(GenericTestType))]
        [XmlElement("LoadTest", typeof(LoadTestType))]
        [XmlElement("ManualTest", typeof(PlainTextManualTestType))]
        [XmlElement("OrderedTest", typeof(OrderedTestType))]
        [XmlElement("UnitTest", typeof(UnitTestType))]
        [XmlElement("UnitTestElement", typeof(UnitTestType))]
        [XmlElement("WebTest", typeof(DeclarativeWebTestElementType))]
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

        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType4[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }

            set
            {
                this.itemsElementNameField = value;
            }
        }
    }
}