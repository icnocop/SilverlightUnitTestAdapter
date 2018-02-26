// <copyright file="TestSettingsTypeExecutionHostsAspNet.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestSettingsTypeExecutionHostsAspNet
    {
        private DevelopmentServerType developmentServerField;

        private string nameField;

        private string urlToTestField;

        private string executionTypeField;

        public DevelopmentServerType DevelopmentServer
        {
            get
            {
                return this.developmentServerField;
            }

            set
            {
                this.developmentServerField = value;
            }
        }

        [XmlAttribute]
        public string executionType
        {
            get
            {
                return this.executionTypeField;
            }

            set
            {
                this.executionTypeField = value;
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

        [XmlAttribute]
        public string urlToTest
        {
            get
            {
                return this.urlToTestField;
            }

            set
            {
                this.urlToTestField = value;
            }
        }
    }
}