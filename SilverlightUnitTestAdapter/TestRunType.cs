// <copyright file="TestRunType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml;
    using System.Xml.Serialization;

    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [GeneratedCode("xsd", "4.0.30319.17929")]
    [Serializable]
    [XmlRoot("TestRun", Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable=false)]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class TestRunType
    {
        private object[] itemsField;

        private string idField;

        private string nameField;

        private string runUserField;

        private int tcmPassIdField;

        private bool tcmPassIdFieldSpecified;

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

        [XmlElement("Build", typeof(TestRunTypeBuild))]
        [XmlElement("Results", typeof(ResultsType))]
        [XmlElement("ResultSummary", typeof(TestRunTypeResultSummary))]
        [XmlElement("TestDefinitions", typeof(TestDefinitionType))]
        [XmlElement("TestEntries", typeof(TestEntriesType1))]
        [XmlElement("TestLists", typeof(TestRunTypeTestLists))]
        [XmlElement("TestRunConfiguration", typeof(TestRunConfiguration))]
        [XmlElement("TestSettings", typeof(TestSettingsType))]
        [XmlElement("Times", typeof(TestRunTypeTimes))]
        [XmlElement("UserData", typeof(XmlElement))]
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

        [XmlAttribute]
        public string runUser
        {
            get
            {
                return this.runUserField;
            }

            set
            {
                this.runUserField = value;
            }
        }

        [XmlAttribute]
        public int tcmPassId
        {
            get
            {
                return this.tcmPassIdField;
            }

            set
            {
                this.tcmPassIdField = value;
            }
        }

        [XmlIgnore]
        public bool tcmPassIdSpecified
        {
            get
            {
                return this.tcmPassIdFieldSpecified;
            }

            set
            {
                this.tcmPassIdFieldSpecified = value;
            }
        }
    }
}