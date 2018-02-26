// <copyright file="LoadTestResultTypeSummary.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestResultTypeSummary
    {
        private LoadTestResultTypeSummaryPerformanceCounterResult[] performanceCounterResultsField;

        private LoadTestResultTypeSummaryPageSummary[] pageSummariesField;

        private LoadTestResultTypeSummaryTestSummary[] testSummariesField;

        private LoadTestResultTypeSummaryTransactionSummary[] transactionSummariesField;

        [XmlArrayItem("PageSummary", IsNullable=false)]
        public LoadTestResultTypeSummaryPageSummary[] PageSummaries
        {
            get
            {
                return this.pageSummariesField;
            }

            set
            {
                this.pageSummariesField = value;
            }
        }

        [XmlArrayItem("PerformanceCounterResult", IsNullable=false)]
        public LoadTestResultTypeSummaryPerformanceCounterResult[] PerformanceCounterResults
        {
            get
            {
                return this.performanceCounterResultsField;
            }

            set
            {
                this.performanceCounterResultsField = value;
            }
        }

        [XmlArrayItem("TestSummary", IsNullable=false)]
        public LoadTestResultTypeSummaryTestSummary[] TestSummaries
        {
            get
            {
                return this.testSummariesField;
            }

            set
            {
                this.testSummariesField = value;
            }
        }

        [XmlArrayItem("TransactionSummary", IsNullable=false)]
        public LoadTestResultTypeSummaryTransactionSummary[] TransactionSummaries
        {
            get
            {
                return this.transactionSummariesField;
            }

            set
            {
                this.transactionSummariesField = value;
            }
        }
    }
}