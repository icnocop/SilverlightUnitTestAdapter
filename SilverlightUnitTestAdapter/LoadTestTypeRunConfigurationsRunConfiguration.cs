// <copyright file="LoadTestTypeRunConfigurationsRunConfiguration.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestTypeRunConfigurationsRunConfiguration
    {
        private LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappings counterSetMappingsField;

        private LoadTestTypeRunConfigurationsRunConfigurationContextParameters[] contextParametersField;

        private string nameField;

        private string descriptionField;

        private string resultsStoreTypeField;

        private string timingDetailsStorageField;

        private int maxErrorDetailsField;

        private int maxRequestUrlsReportedField;

        private int maxErrorsPerTypeField;

        private bool maxErrorsPerTypeFieldSpecified;

        private int maxThresholdViolationsField;

        private bool maxThresholdViolationsFieldSpecified;

        private bool useTestIterationsField;

        private bool useTestIterationsFieldSpecified;

        private int runDurationField;

        private int warmupTimeField;

        private int coolDownTimeField;

        private bool coolDownTimeFieldSpecified;

        private int testIterationsField;

        private bool testIterationsFieldSpecified;

        private WebTestConnectionModel webTestConnectionModelField;

        private int webTestConnectionPoolSizeField;

        private int sampleRateField;

        private LoadTestValidationLevel validationLevelField;

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

        private bool saveTestLogsOnErrorField;

        private bool saveTestLogsOnErrorFieldSpecified;

        private int saveTestLogsFrequencyField;

        private bool saveTestLogsFrequencyFieldSpecified;

        [XmlElement("ContextParameters")]
        public LoadTestTypeRunConfigurationsRunConfigurationContextParameters[] ContextParameters
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
        public int CoolDownTime
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
        public bool CoolDownTimeSpecified
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

        public LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappings CounterSetMappings
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
        public string Description
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

        [XmlAttribute]
        public int MaxErrorDetails
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

        [XmlAttribute]
        public int MaxErrorsPerType
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

        [XmlIgnore]
        public bool MaxErrorsPerTypeSpecified
        {
            get
            {
                return this.maxErrorsPerTypeFieldSpecified;
            }

            set
            {
                this.maxErrorsPerTypeFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int MaxRequestUrlsReported
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

        [XmlAttribute]
        public int MaxThresholdViolations
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

        [XmlIgnore]
        public bool MaxThresholdViolationsSpecified
        {
            get
            {
                return this.maxThresholdViolationsFieldSpecified;
            }

            set
            {
                this.maxThresholdViolationsFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string Name
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
        public string ResultsStoreType
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
        public int RunDuration
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
        public bool RunUnitTestsInAppDomain
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
        public bool RunUnitTestsInAppDomainSpecified
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
        public int SampleRate
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

        [XmlAttribute]
        public int SaveTestLogsFrequency
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

        [XmlIgnore]
        public bool SaveTestLogsFrequencySpecified
        {
            get
            {
                return this.saveTestLogsFrequencyFieldSpecified;
            }

            set
            {
                this.saveTestLogsFrequencyFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool SaveTestLogsOnError
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
        public bool SaveTestLogsOnErrorSpecified
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
        public string SqlTracingConnectString
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
        public string SqlTracingConnectStringDisplayValue
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
        public string SqlTracingDirectory
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
        public bool SqlTracingEnabled
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
        public bool SqlTracingEnabledSpecified
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
        public int SqlTracingFileCount
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
        public bool SqlTracingFileCountSpecified
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
        public int SqlTracingMinimumDuration
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
        public bool SqlTracingMinimumDurationSpecified
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
        public bool SqlTracingRolloverEnabled
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
        public bool SqlTracingRolloverEnabledSpecified
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
        public int TestIterations
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
        public bool TestIterationsSpecified
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
        public string TimingDetailsStorage
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

        [XmlAttribute]
        public bool UseTestIterations
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
        public bool UseTestIterationsSpecified
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
        public LoadTestValidationLevel ValidationLevel
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
        public int WarmupTime
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
        public WebTestConnectionModel WebTestConnectionModel
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
        public int WebTestConnectionPoolSize
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
    }
}