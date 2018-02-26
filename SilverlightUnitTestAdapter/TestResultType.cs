// <copyright file="TestResultType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlInclude(typeof(LoadTestResultType))]
    [XmlInclude(typeof(ManualTestResultType))]
    [XmlInclude(typeof(TestResultAggregationType))]
    [XmlInclude(typeof(UnitTestResultType))]
    [XmlInclude(typeof(WebTestResultType))]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class TestResultType
    {
        private object[] itemsField;

        private string testNameField;

        private string testTypeField;

        private string testIdField;

        private string executionIdField;

        private string parentExecutionIdField;

        private string testListIdField;

        private string outcomeField;

        private string computerNameField;

        private string relativeResultsDirectoryField;

        private string startTimeField;

        private string endTimeField;

        private string durationField;

        private bool spoolMessageField;

        private int processExitCodeField;

        private bool processExitCodeFieldSpecified;

        private bool isAbortedField;

        private bool isAbortedFieldSpecified;

        private string relativeTestOutputDirectoryField;

        [XmlAttribute]
        public string computerName
        {
            get
            {
                return this.computerNameField;
            }

            set
            {
                this.computerNameField = value;
            }
        }

        [XmlAttribute]
        public string duration
        {
            get
            {
                return this.durationField;
            }

            set
            {
                this.durationField = value;
            }
        }

        [XmlAttribute]
        public string endTime
        {
            get
            {
                return this.endTimeField;
            }

            set
            {
                this.endTimeField = value;
            }
        }

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

        [XmlAttribute]
        public bool isAborted
        {
            get
            {
                return this.isAbortedField;
            }

            set
            {
                this.isAbortedField = value;
            }
        }

        [XmlIgnore]
        public bool isAbortedSpecified
        {
            get
            {
                return this.isAbortedFieldSpecified;
            }

            set
            {
                this.isAbortedFieldSpecified = value;
            }
        }

        [XmlElement("CollectorDataEntries", typeof(CollectorDataEntriesType))]
        [XmlElement("DataCollectorMessages", typeof(DataCollectorMessagesType))]
        [XmlElement("FileUris", typeof(FileUrisType))]
        [XmlElement("Output", typeof(OutputType))]
        [XmlElement("ResultFiles", typeof(ResultFilesType))]
        [XmlElement("TcmInformation", typeof(TcmInformationType))]
        [XmlElement("Timers", typeof(TestResultTypeTimers))]
        [XmlElement("WorkItems", typeof(WorkItemIDsType))]
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

        [XmlAttribute]
        public int processExitCode
        {
            get
            {
                return this.processExitCodeField;
            }

            set
            {
                this.processExitCodeField = value;
            }
        }

        [XmlIgnore]
        public bool processExitCodeSpecified
        {
            get
            {
                return this.processExitCodeFieldSpecified;
            }

            set
            {
                this.processExitCodeFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string relativeResultsDirectory
        {
            get
            {
                return this.relativeResultsDirectoryField;
            }

            set
            {
                this.relativeResultsDirectoryField = value;
            }
        }

        [XmlAttribute]
        public string relativeTestOutputDirectory
        {
            get
            {
                return this.relativeTestOutputDirectoryField;
            }

            set
            {
                this.relativeTestOutputDirectoryField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool spoolMessage
        {
            get
            {
                return this.spoolMessageField;
            }

            set
            {
                this.spoolMessageField = value;
            }
        }

        [XmlAttribute]
        public string startTime
        {
            get
            {
                return this.startTimeField;
            }

            set
            {
                this.startTimeField = value;
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

        [XmlAttribute]
        public string testName
        {
            get
            {
                return this.testNameField;
            }

            set
            {
                this.testNameField = value;
            }
        }

        [XmlAttribute]
        public string testType
        {
            get
            {
                return this.testTypeField;
            }

            set
            {
                this.testTypeField = value;
            }
        }

        public TestResultType()
        {
            this.spoolMessageField = true;
        }
    }
}