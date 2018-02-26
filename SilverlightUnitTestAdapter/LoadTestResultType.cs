// <copyright file="LoadTestResultType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestResultType : TestResultAggregationType
    {
        private LoadTestResultTypeAnalyzerViewState analyzerViewStateField;

        private LoadTestResultTypeSummary summaryField;

        private LoadTestRunStatusType runStatusField;

        private int runIdField;

        private string controllerStartTimeField;

        private int loadTestDurationField;

        private bool loadTestDurationFieldSpecified;

        private int loadTestWarmupTimeField;

        private bool loadTestWarmupTimeFieldSpecified;

        private bool previouslyViewedField;

        private string resultsRepositoryConnectStringField;

        private LoadTestResultStoreType resultsStoreTypeField;

        private bool resultsStoreTypeFieldSpecified;

        public LoadTestResultTypeAnalyzerViewState AnalyzerViewState
        {
            get
            {
                return this.analyzerViewStateField;
            }

            set
            {
                this.analyzerViewStateField = value;
            }
        }

        [XmlAttribute]
        public string controllerStartTime
        {
            get
            {
                return this.controllerStartTimeField;
            }

            set
            {
                this.controllerStartTimeField = value;
            }
        }

        [XmlAttribute]
        public int loadTestDuration
        {
            get
            {
                return this.loadTestDurationField;
            }

            set
            {
                this.loadTestDurationField = value;
            }
        }

        [XmlIgnore]
        public bool loadTestDurationSpecified
        {
            get
            {
                return this.loadTestDurationFieldSpecified;
            }

            set
            {
                this.loadTestDurationFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int loadTestWarmupTime
        {
            get
            {
                return this.loadTestWarmupTimeField;
            }

            set
            {
                this.loadTestWarmupTimeField = value;
            }
        }

        [XmlIgnore]
        public bool loadTestWarmupTimeSpecified
        {
            get
            {
                return this.loadTestWarmupTimeFieldSpecified;
            }

            set
            {
                this.loadTestWarmupTimeFieldSpecified = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool previouslyViewed
        {
            get
            {
                return this.previouslyViewedField;
            }

            set
            {
                this.previouslyViewedField = value;
            }
        }

        [XmlAttribute]
        public string resultsRepositoryConnectString
        {
            get
            {
                return this.resultsRepositoryConnectStringField;
            }

            set
            {
                this.resultsRepositoryConnectStringField = value;
            }
        }

        [XmlAttribute]
        public LoadTestResultStoreType resultsStoreType
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

        [XmlIgnore]
        public bool resultsStoreTypeSpecified
        {
            get
            {
                return this.resultsStoreTypeFieldSpecified;
            }

            set
            {
                this.resultsStoreTypeFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int runId
        {
            get
            {
                return this.runIdField;
            }

            set
            {
                this.runIdField = value;
            }
        }

        [DefaultValue(LoadTestRunStatusType.NotStarted)]
        [XmlAttribute]
        public LoadTestRunStatusType runStatus
        {
            get
            {
                return this.runStatusField;
            }

            set
            {
                this.runStatusField = value;
            }
        }

        public LoadTestResultTypeSummary Summary
        {
            get
            {
                return this.summaryField;
            }

            set
            {
                this.summaryField = value;
            }
        }

        public LoadTestResultType()
        {
            this.runStatusField = LoadTestRunStatusType.NotStarted;
            this.previouslyViewedField = false;
        }
    }
}