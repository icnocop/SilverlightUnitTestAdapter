// <copyright file="TestResultDetailType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlRoot("TestResultDetail", Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable=false)]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class TestResultDetailType
    {
        private TestDefinitionType testDefinitionsField;

        private ResultsType resultField;

        private string runIdField;

        public ResultsType Result
        {
            get
            {
                return this.resultField;
            }

            set
            {
                this.resultField = value;
            }
        }

        [XmlAttribute]
        public string runId
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

        public TestDefinitionType TestDefinitions
        {
            get
            {
                return this.testDefinitionsField;
            }

            set
            {
                this.testDefinitionsField = value;
            }
        }
    }
}