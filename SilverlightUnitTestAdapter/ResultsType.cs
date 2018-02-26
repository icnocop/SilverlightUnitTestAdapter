// <copyright file="ResultsType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class ResultsType
    {
        private object[] itemsField;

        private ItemsChoiceType3[] itemsElementNameField;

        [XmlAnyElement]
        [XmlChoiceIdentifier("ItemsElementName")]
        [XmlElement("GenericTestResult", typeof(TestResultAggregationType))]
        [XmlElement("LoadTestResult", typeof(LoadTestResultType))]
        [XmlElement("ManualTestResult", typeof(ManualTestResultType))]
        [XmlElement("TestResult", typeof(TestResultType))]
        [XmlElement("TestResultAggregation", typeof(TestResultAggregationType))]
        [XmlElement("UnitTestResult", typeof(UnitTestResultType))]
        [XmlElement("WebTestResult", typeof(WebTestResultType))]
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
        public ItemsChoiceType3[] ItemsElementName
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