// <copyright file="TestRunTypeResultSummary.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestRunTypeResultSummary
    {
        private object[] itemsField;

        private ResultFilesTypeResultFile[] resultFilesField;

        private FileUriType[] fileUrisField;

        private CollectorType[] collectorDataEntriesField;

        private DataCollectorMessageType[] dataCollectorMessagesField;

        private string outcomeField;

        private bool isPartialRunField;

        [XmlArrayItem("Collector", IsNullable=false)]
        public CollectorType[] CollectorDataEntries
        {
            get
            {
                return this.collectorDataEntriesField;
            }

            set
            {
                this.collectorDataEntriesField = value;
            }
        }

        [XmlArrayItem("DataCollectorExceptionMessage", typeof(DataCollectorExceptionMessageType), IsNullable=false)]
        [XmlArrayItem("DataCollectorMessage", IsNullable=false)]
        public DataCollectorMessageType[] DataCollectorMessages
        {
            get
            {
                return this.dataCollectorMessagesField;
            }

            set
            {
                this.dataCollectorMessagesField = value;
            }
        }

        [XmlArrayItem("FileUri", IsNullable=false)]
        public FileUriType[] FileUris
        {
            get
            {
                return this.fileUrisField;
            }

            set
            {
                this.fileUrisField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool isPartialRun
        {
            get
            {
                return this.isPartialRunField;
            }

            set
            {
                this.isPartialRunField = value;
            }
        }

        [XmlElement("Counters", typeof(CountersType))]
        [XmlElement("Output", typeof(TestRunOutputType))]
        [XmlElement("RunInfos", typeof(TestRunTypeResultSummaryRunInfos))]
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
        public string outcome
        {
            get
            {
                return this.outcomeField;
            }

            set
            {
                this.outcomeField = value;
            }
        }

        [XmlArrayItem("ResultFile", IsNullable=false)]
        public ResultFilesTypeResultFile[] ResultFiles
        {
            get
            {
                return this.resultFilesField;
            }

            set
            {
                this.resultFilesField = value;
            }
        }

        public TestRunTypeResultSummary()
        {
            this.isPartialRunField = false;
        }
    }
}