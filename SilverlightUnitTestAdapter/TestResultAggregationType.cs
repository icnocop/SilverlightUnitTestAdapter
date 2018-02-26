// <copyright file="TestResultAggregationType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlInclude(typeof(UnitTestResultType))]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class TestResultAggregationType : TestResultType
    {
        private CountersType countersField;

        private ResultsType innerResultsField;

        public CountersType Counters
        {
            get
            {
                return this.countersField;
            }

            set
            {
                this.countersField = value;
            }
        }

        public ResultsType InnerResults
        {
            get
            {
                return this.innerResultsField;
            }

            set
            {
                this.innerResultsField = value;
            }
        }
    }
}