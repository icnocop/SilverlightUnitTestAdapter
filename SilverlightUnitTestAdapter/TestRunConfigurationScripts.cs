// <copyright file="TestRunConfigurationScripts.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestRunConfigurationScripts
    {
        private string cleanupScriptField;

        private string setupScriptField;

        [XmlAttribute]
        public string cleanupScript
        {
            get
            {
                return this.cleanupScriptField;
            }

            set
            {
                this.cleanupScriptField = value;
            }
        }

        [XmlAttribute]
        public string setupScript
        {
            get
            {
                return this.setupScriptField;
            }

            set
            {
                this.setupScriptField = value;
            }
        }
    }
}