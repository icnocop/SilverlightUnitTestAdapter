// <copyright file="TestSettingsTypeExecutionTestTypeSpecific.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlType(AnonymousType=true, Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class TestSettingsTypeExecutionTestTypeSpecific
    {
        private object[] itemsField;

        private ItemsChoiceType2[] itemsElementNameField;

        [XmlAnyElement]
        [XmlChoiceIdentifier("ItemsElementName")]
        [XmlElement("UnitTestRunConfig", typeof(AssemblyResolutionSettingsType))]
        [XmlElement("WebTestRunConfig", typeof(WebTestRunConfigurationType))]
        [XmlElement("WebTestRunConfiguration", typeof(WebTestRunConfigurationType))]
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
        public ItemsChoiceType2[] ItemsElementName
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