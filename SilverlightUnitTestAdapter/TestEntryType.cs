// <copyright file="TestEntryType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestEntryType
    {
        private TcmInformationType tcmInformationField;

        private TestEntryType[] testEntriesField;

        private string testIdField;

        private string executionIdField;

        private string parentExecutionIdField;

        private string testListIdField;

        private bool isTransparentField;

        [XmlAttribute]
        public string executionId
        {
            get
            {
                return this.executionIdField;
            }

            set
            {
                this.executionIdField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool isTransparent
        {
            get
            {
                return this.isTransparentField;
            }

            set
            {
                this.isTransparentField = value;
            }
        }

        [DefaultValue("00000000-0000-0000-0000-000000000000")]
        [XmlAttribute]
        public string parentExecutionId
        {
            get
            {
                return this.parentExecutionIdField;
            }

            set
            {
                this.parentExecutionIdField = value;
            }
        }

        public TcmInformationType TcmInformation
        {
            get
            {
                return this.tcmInformationField;
            }

            set
            {
                this.tcmInformationField = value;
            }
        }

        [XmlArrayItem("TestEntry", IsNullable=false)]
        public TestEntryType[] TestEntries
        {
            get
            {
                return this.testEntriesField;
            }

            set
            {
                this.testEntriesField = value;
            }
        }

        [XmlAttribute]
        public string testId
        {
            get
            {
                return this.testIdField;
            }

            set
            {
                this.testIdField = value;
            }
        }

        [XmlAttribute]
        public string testListId
        {
            get
            {
                return this.testListIdField;
            }

            set
            {
                this.testListIdField = value;
            }
        }

        public TestEntryType()
        {
            this.parentExecutionIdField = "00000000-0000-0000-0000-000000000000";
            this.isTransparentField = true;
        }
    }
}