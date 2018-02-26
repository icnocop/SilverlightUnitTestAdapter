// <copyright file="WebRequestResultType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class WebRequestResultType
    {
        private WebRequestResultTypeRequest requestField;

        private WebRequestResultTypeResponse responseField;

        private WebRequestResultTypeEntry[] contextField;

        private WebRequestResultTypeError[] errorsField;

        private WebRequestResultType[] dependantResultsField;

        private RuleResultType[] validationRuleResultsField;

        private RuleResultType[] extractionRuleResultsField;

        private string redirectUrlField;

        private string exceptionMessageField;

        private int runField;

        private bool runFieldSpecified;

        private bool submittedField;

        private bool submittedFieldSpecified;

        private bool cachedField;

        private bool cachedFieldSpecified;

        private bool isRedirectFollowField;

        private bool isRedirectFollowFieldSpecified;

        private int requestBodyBytesHandleField;

        private bool requestBodyBytesHandleFieldSpecified;

        private int responseBytesHandleField;

        private bool responseBytesHandleFieldSpecified;

        private string resultsUrlField;

        private int httpStatusField;

        private bool recordResultField;

        private string scenarioNameField;

        private string testCaseNameField;

        private int failedValidationRuleCountField;

        private bool failedValidationRuleCountFieldSpecified;

        private int successfulExtractionRuleCountField;

        private bool successfulExtractionRuleCountFieldSpecified;

        private int failedExtractionRuleCountField;

        private bool failedExtractionRuleCountFieldSpecified;

        private bool requestPassedByCodeField;

        private bool requestPassedByCodeFieldSpecified;

        [XmlAttribute]
        public bool cached
        {
            get
            {
                return this.cachedField;
            }

            set
            {
                this.cachedField = value;
            }
        }

        [XmlIgnore]
        public bool cachedSpecified
        {
            get
            {
                return this.cachedFieldSpecified;
            }

            set
            {
                this.cachedFieldSpecified = value;
            }
        }

        [XmlArrayItem("Entry", IsNullable=false)]
        public WebRequestResultTypeEntry[] Context
        {
            get
            {
                return this.contextField;
            }

            set
            {
                this.contextField = value;
            }
        }

        [XmlArrayItem("WebRequestResult", IsNullable=false)]
        public WebRequestResultType[] DependantResults
        {
            get
            {
                return this.dependantResultsField;
            }

            set
            {
                this.dependantResultsField = value;
            }
        }

        [XmlArrayItem("Error", IsNullable=false)]
        public WebRequestResultTypeError[] Errors
        {
            get
            {
                return this.errorsField;
            }

            set
            {
                this.errorsField = value;
            }
        }

        [XmlAttribute]
        public string exceptionMessage
        {
            get
            {
                return this.exceptionMessageField;
            }

            set
            {
                this.exceptionMessageField = value;
            }
        }

        [XmlArrayItem("ExtractionRuleResult", IsNullable=false)]
        public RuleResultType[] ExtractionRuleResults
        {
            get
            {
                return this.extractionRuleResultsField;
            }

            set
            {
                this.extractionRuleResultsField = value;
            }
        }

        [XmlAttribute]
        public int failedExtractionRuleCount
        {
            get
            {
                return this.failedExtractionRuleCountField;
            }

            set
            {
                this.failedExtractionRuleCountField = value;
            }
        }

        [XmlIgnore]
        public bool failedExtractionRuleCountSpecified
        {
            get
            {
                return this.failedExtractionRuleCountFieldSpecified;
            }

            set
            {
                this.failedExtractionRuleCountFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int failedValidationRuleCount
        {
            get
            {
                return this.failedValidationRuleCountField;
            }

            set
            {
                this.failedValidationRuleCountField = value;
            }
        }

        [XmlIgnore]
        public bool failedValidationRuleCountSpecified
        {
            get
            {
                return this.failedValidationRuleCountFieldSpecified;
            }

            set
            {
                this.failedValidationRuleCountFieldSpecified = value;
            }
        }

        [DefaultValue(200)]
        [XmlAttribute]
        public int httpStatus
        {
            get
            {
                return this.httpStatusField;
            }

            set
            {
                this.httpStatusField = value;
            }
        }

        [XmlAttribute]
        public bool isRedirectFollow
        {
            get
            {
                return this.isRedirectFollowField;
            }

            set
            {
                this.isRedirectFollowField = value;
            }
        }

        [XmlIgnore]
        public bool isRedirectFollowSpecified
        {
            get
            {
                return this.isRedirectFollowFieldSpecified;
            }

            set
            {
                this.isRedirectFollowFieldSpecified = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool recordResult
        {
            get
            {
                return this.recordResultField;
            }

            set
            {
                this.recordResultField = value;
            }
        }

        [XmlAttribute]
        public string redirectUrl
        {
            get
            {
                return this.redirectUrlField;
            }

            set
            {
                this.redirectUrlField = value;
            }
        }

        public WebRequestResultTypeRequest Request
        {
            get
            {
                return this.requestField;
            }

            set
            {
                this.requestField = value;
            }
        }

        [XmlAttribute]
        public int requestBodyBytesHandle
        {
            get
            {
                return this.requestBodyBytesHandleField;
            }

            set
            {
                this.requestBodyBytesHandleField = value;
            }
        }

        [XmlIgnore]
        public bool requestBodyBytesHandleSpecified
        {
            get
            {
                return this.requestBodyBytesHandleFieldSpecified;
            }

            set
            {
                this.requestBodyBytesHandleFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool requestPassedByCode
        {
            get
            {
                return this.requestPassedByCodeField;
            }

            set
            {
                this.requestPassedByCodeField = value;
            }
        }

        [XmlIgnore]
        public bool requestPassedByCodeSpecified
        {
            get
            {
                return this.requestPassedByCodeFieldSpecified;
            }

            set
            {
                this.requestPassedByCodeFieldSpecified = value;
            }
        }

        public WebRequestResultTypeResponse Response
        {
            get
            {
                return this.responseField;
            }

            set
            {
                this.responseField = value;
            }
        }

        [XmlAttribute]
        public int responseBytesHandle
        {
            get
            {
                return this.responseBytesHandleField;
            }

            set
            {
                this.responseBytesHandleField = value;
            }
        }

        [XmlIgnore]
        public bool responseBytesHandleSpecified
        {
            get
            {
                return this.responseBytesHandleFieldSpecified;
            }

            set
            {
                this.responseBytesHandleFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string resultsUrl
        {
            get
            {
                return this.resultsUrlField;
            }

            set
            {
                this.resultsUrlField = value;
            }
        }

        [XmlAttribute]
        public int run
        {
            get
            {
                return this.runField;
            }

            set
            {
                this.runField = value;
            }
        }

        [XmlIgnore]
        public bool runSpecified
        {
            get
            {
                return this.runFieldSpecified;
            }

            set
            {
                this.runFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string scenarioName
        {
            get
            {
                return this.scenarioNameField;
            }

            set
            {
                this.scenarioNameField = value;
            }
        }

        [XmlAttribute]
        public bool submitted
        {
            get
            {
                return this.submittedField;
            }

            set
            {
                this.submittedField = value;
            }
        }

        [XmlIgnore]
        public bool submittedSpecified
        {
            get
            {
                return this.submittedFieldSpecified;
            }

            set
            {
                this.submittedFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int successfulExtractionRuleCount
        {
            get
            {
                return this.successfulExtractionRuleCountField;
            }

            set
            {
                this.successfulExtractionRuleCountField = value;
            }
        }

        [XmlIgnore]
        public bool successfulExtractionRuleCountSpecified
        {
            get
            {
                return this.successfulExtractionRuleCountFieldSpecified;
            }

            set
            {
                this.successfulExtractionRuleCountFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string testCaseName
        {
            get
            {
                return this.testCaseNameField;
            }

            set
            {
                this.testCaseNameField = value;
            }
        }

        [XmlArrayItem("ValidationRuleResult", IsNullable=false)]
        public RuleResultType[] ValidationRuleResults
        {
            get
            {
                return this.validationRuleResultsField;
            }

            set
            {
                this.validationRuleResultsField = value;
            }
        }

        public WebRequestResultType()
        {
            this.httpStatusField = 200;
            this.recordResultField = false;
        }
    }
}