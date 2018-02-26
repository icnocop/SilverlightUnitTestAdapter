// <copyright file="LoadRunConfigurationType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadRunConfigurationType
    {
        private LoadRunConfigurationTypeCounterSetMapping[] counterSetMappingsField;

        private object contextParametersField;

        private string nameField;

        private string descriptionField;

        private int timingDetailsStorageField;

        private bool timingDetailsStorageFieldSpecified;

        private int resultsStoreTypeField;

        private bool saveTestLogsOnErrorField;

        private bool saveTestLogsOnErrorFieldSpecified;

        private int saveTestLogsFrequencyField;

        private int maxErrorDetailsField;

        private int maxErrorsPerTypeField;

        private int maxThresholdViolationsField;

        private int maxRequestUrlsReportedField;

        private bool useTestIterationsField;

        private bool useTestIterationsFieldSpecified;

        private int runDurationField;

        private int warmupTimeField;

        private int coolDownTimeField;

        private bool coolDownTimeFieldSpecified;

        private int testIterationsField;

        private bool testIterationsFieldSpecified;

        private string webTestConnectionModelField;

        private int webTestConnectionPoolSizeField;

        private bool webTestConnectionPoolSizeFieldSpecified;

        private int sampleRateField;

        private int validationLevelField;

        private string sqlTracingConnectStringField;

        private string sqlTracingConnectStringDisplayValueField;

        private string sqlTracingDirectoryField;

        private bool sqlTracingEnabledField;

        private bool sqlTracingEnabledFieldSpecified;

        private int sqlTracingFileCountField;

        private bool sqlTracingFileCountFieldSpecified;

        private bool sqlTracingRolloverEnabledField;

        private bool sqlTracingRolloverEnabledFieldSpecified;

        private int sqlTracingMinimumDurationField;

        private bool sqlTracingMinimumDurationFieldSpecified;

        private bool runUnitTestsInAppDomainField;

        private bool runUnitTestsInAppDomainFieldSpecified;

        public object ContextParameters
        {
            get
            {
                return this.contextParametersField;
            }

            set
            {
                this.contextParametersField = value;
            }
        }

        [XmlAttribute]
        public int coolDownTime
        {
            get
            {
                return this.coolDownTimeField;
            }

            set
            {
                this.coolDownTimeField = value;
            }
        }

        [XmlIgnore]
        public bool coolDownTimeSpecified
        {
            get
            {
                return this.coolDownTimeFieldSpecified;
            }

            set
            {
                this.coolDownTimeFieldSpecified = value;
            }
        }

        [XmlArrayItem("CounterSetMapping", IsNullable=false)]
        public LoadRunConfigurationTypeCounterSetMapping[] CounterSetMappings
        {
            get
            {
                return this.counterSetMappingsField;
            }

            set
            {
                this.counterSetMappingsField = value;
            }
        }

        [XmlAttribute]
        public string description
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

        [DefaultValue(100)]
        [XmlAttribute]
        public int maxErrorDetails
        {
            get
            {
                return this.maxErrorDetailsField;
            }

            set
            {
                this.maxErrorDetailsField = value;
            }
        }

        [DefaultValue(1000)]
        [XmlAttribute]
        public int maxErrorsPerType
        {
            get
            {
                return this.maxErrorsPerTypeField;
            }

            set
            {
                this.maxErrorsPerTypeField = value;
            }
        }

        [XmlAttribute]
        public int maxRequestUrlsReported
        {
            get
            {
                return this.maxRequestUrlsReportedField;
            }

            set
            {
                this.maxRequestUrlsReportedField = value;
            }
        }

        [DefaultValue(1000)]
        [XmlAttribute]
        public int maxThresholdViolations
        {
            get
            {
                return this.maxThresholdViolationsField;
            }

            set
            {
                this.maxThresholdViolationsField = value;
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

        [DefaultValue(1)]
        [XmlAttribute]
        public int resultsStoreType
        {
            get
            {
                return this.resultsStoreTypeField;
            }

            set
            {
                this.resultsStoreTypeField = value;
            }
        }

        [XmlAttribute]
        public int runDuration
        {
            get
            {
                return this.runDurationField;
            }

            set
            {
                this.runDurationField = value;
            }
        }

        [XmlAttribute]
        public bool runUnitTestsInAppDomain
        {
            get
            {
                return this.runUnitTestsInAppDomainField;
            }

            set
            {
                this.runUnitTestsInAppDomainField = value;
            }
        }

        [XmlIgnore]
        public bool runUnitTestsInAppDomainSpecified
        {
            get
            {
                return this.runUnitTestsInAppDomainFieldSpecified;
            }

            set
            {
                this.runUnitTestsInAppDomainFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int sampleRate
        {
            get
            {
                return this.sampleRateField;
            }

            set
            {
                this.sampleRateField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int saveTestLogsFrequency
        {
            get
            {
                return this.saveTestLogsFrequencyField;
            }

            set
            {
                this.saveTestLogsFrequencyField = value;
            }
        }

        [XmlAttribute]
        public bool saveTestLogsOnError
        {
            get
            {
                return this.saveTestLogsOnErrorField;
            }

            set
            {
                this.saveTestLogsOnErrorField = value;
            }
        }

        [XmlIgnore]
        public bool saveTestLogsOnErrorSpecified
        {
            get
            {
                return this.saveTestLogsOnErrorFieldSpecified;
            }

            set
            {
                this.saveTestLogsOnErrorFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string sqlTracingConnectString
        {
            get
            {
                return this.sqlTracingConnectStringField;
            }

            set
            {
                this.sqlTracingConnectStringField = value;
            }
        }

        [XmlAttribute]
        public string sqlTracingConnectStringDisplayValue
        {
            get
            {
                return this.sqlTracingConnectStringDisplayValueField;
            }

            set
            {
                this.sqlTracingConnectStringDisplayValueField = value;
            }
        }

        [XmlAttribute]
        public string sqlTracingDirectory
        {
            get
            {
                return this.sqlTracingDirectoryField;
            }

            set
            {
                this.sqlTracingDirectoryField = value;
            }
        }

        [XmlAttribute]
        public bool sqlTracingEnabled
        {
            get
            {
                return this.sqlTracingEnabledField;
            }

            set
            {
                this.sqlTracingEnabledField = value;
            }
        }

        [XmlIgnore]
        public bool sqlTracingEnabledSpecified
        {
            get
            {
                return this.sqlTracingEnabledFieldSpecified;
            }

            set
            {
                this.sqlTracingEnabledFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int sqlTracingFileCount
        {
            get
            {
                return this.sqlTracingFileCountField;
            }

            set
            {
                this.sqlTracingFileCountField = value;
            }
        }

        [XmlIgnore]
        public bool sqlTracingFileCountSpecified
        {
            get
            {
                return this.sqlTracingFileCountFieldSpecified;
            }

            set
            {
                this.sqlTracingFileCountFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int sqlTracingMinimumDuration
        {
            get
            {
                return this.sqlTracingMinimumDurationField;
            }

            set
            {
                this.sqlTracingMinimumDurationField = value;
            }
        }

        [XmlIgnore]
        public bool sqlTracingMinimumDurationSpecified
        {
            get
            {
                return this.sqlTracingMinimumDurationFieldSpecified;
            }

            set
            {
                this.sqlTracingMinimumDurationFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool sqlTracingRolloverEnabled
        {
            get
            {
                return this.sqlTracingRolloverEnabledField;
            }

            set
            {
                this.sqlTracingRolloverEnabledField = value;
            }
        }

        [XmlIgnore]
        public bool sqlTracingRolloverEnabledSpecified
        {
            get
            {
                return this.sqlTracingRolloverEnabledFieldSpecified;
            }

            set
            {
                this.sqlTracingRolloverEnabledFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int testIterations
        {
            get
            {
                return this.testIterationsField;
            }

            set
            {
                this.testIterationsField = value;
            }
        }

        [XmlIgnore]
        public bool testIterationsSpecified
        {
            get
            {
                return this.testIterationsFieldSpecified;
            }

            set
            {
                this.testIterationsFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int timingDetailsStorage
        {
            get
            {
                return this.timingDetailsStorageField;
            }

            set
            {
                this.timingDetailsStorageField = value;
            }
        }

        [XmlIgnore]
        public bool timingDetailsStorageSpecified
        {
            get
            {
                return this.timingDetailsStorageFieldSpecified;
            }

            set
            {
                this.timingDetailsStorageFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool useTestIterations
        {
            get
            {
                return this.useTestIterationsField;
            }

            set
            {
                this.useTestIterationsField = value;
            }
        }

        [XmlIgnore]
        public bool useTestIterationsSpecified
        {
            get
            {
                return this.useTestIterationsFieldSpecified;
            }

            set
            {
                this.useTestIterationsFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int validationLevel
        {
            get
            {
                return this.validationLevelField;
            }

            set
            {
                this.validationLevelField = value;
            }
        }

        [XmlAttribute]
        public int warmupTime
        {
            get
            {
                return this.warmupTimeField;
            }

            set
            {
                this.warmupTimeField = value;
            }
        }

        [XmlAttribute]
        public string webTestConnectionModel
        {
            get
            {
                return this.webTestConnectionModelField;
            }

            set
            {
                this.webTestConnectionModelField = value;
            }
        }

        [XmlAttribute]
        public int webTestConnectionPoolSize
        {
            get
            {
                return this.webTestConnectionPoolSizeField;
            }

            set
            {
                this.webTestConnectionPoolSizeField = value;
            }
        }

        [XmlIgnore]
        public bool webTestConnectionPoolSizeSpecified
        {
            get
            {
                return this.webTestConnectionPoolSizeFieldSpecified;
            }

            set
            {
                this.webTestConnectionPoolSizeFieldSpecified = value;
            }
        }

        public LoadRunConfigurationType()
        {
            this.resultsStoreTypeField = 1;
            this.saveTestLogsFrequencyField = 0;
            this.maxErrorDetailsField = 100;
            this.maxErrorsPerTypeField = 1000;
            this.maxThresholdViolationsField = 1000;
        }
    }
}