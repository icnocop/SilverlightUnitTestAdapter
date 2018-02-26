// <copyright file="WebTestResultType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class WebTestResultType : TestResultType
    {
        private object[] items1Field;

        private Items1ChoiceType[] items1ElementNameField;

        private uint dataRowCountField;

        [DefaultValue(typeof(uint), "0")]
        [XmlAttribute]
        public uint dataRowCount
        {
            get
            {
                return this.dataRowCountField;
            }

            set
            {
                this.dataRowCountField = value;
            }
        }

        [XmlChoiceIdentifier("Items1ElementName")]
        [XmlElement("ByteArrayCache", typeof(WebTestResultTypeByteArrayCache))]
        [XmlElement("TestRunConfiguration", typeof(TestRunConfiguration))]
        [XmlElement("TestSettings", typeof(TestSettingsType))]
        [XmlElement("WebRequestResults", typeof(WebRequestResultsType1))]
        [XmlElement("WebTestRecordedResultFilePath", typeof(string))]
        [XmlElement("WebTestResultDetails", typeof(WebTestResultDetailsType))]
        [XmlElement("WebTestResultFilePath", typeof(string))]
        public object[] Items1
        {
            get
            {
                return this.items1Field;
            }

            set
            {
                this.items1Field = value;
            }
        }

        [XmlElement("Items1ElementName")]
        [XmlIgnore]
        public Items1ChoiceType[] Items1ElementName
        {
            get
            {
                return this.items1ElementNameField;
            }

            set
            {
                this.items1ElementNameField = value;
            }
        }

        public WebTestResultType()
        {
            this.dataRowCountField = 0;
        }
    }
}