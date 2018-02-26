// <copyright file="TestRunConfiguration.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlRoot(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable=false)]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class TestRunConfiguration
    {
        private object[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        private string idField;

        private string nameField;

        private bool isExecutedRemotelyField;

        private bool abortRunOnErrorField;

        private bool autoSaveResultsField;

        private bool mapIPAddressesField;

        private bool traceExecutionSequenceField;

        [DefaultValue(false)]
        [XmlAttribute]
        public bool abortRunOnError
        {
            get
            {
                return this.abortRunOnErrorField;
            }

            set
            {
                this.abortRunOnErrorField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool autoSaveResults
        {
            get
            {
                return this.autoSaveResultsField;
            }

            set
            {
                this.autoSaveResultsField = value;
            }
        }

        [XmlAttribute]
        public string id
        {
            get
            {
                return this.idField;
            }

            set
            {
                this.idField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool isExecutedRemotely
        {
            get
            {
                return this.isExecutedRemotelyField;
            }

            set
            {
                this.isExecutedRemotelyField = value;
            }
        }

        [XmlChoiceIdentifier("ItemsElementName")]
        [XmlElement("Buckets", typeof(TestRunConfigurationBuckets))]
        [XmlElement("CodeCoverage", typeof(TestRunConfigurationCodeCoverage))]
        [XmlElement("Constraints", typeof(TestRunConfigurationConstraints))]
        [XmlElement("Deployment", typeof(TestRunConfigurationDeployment))]
        [XmlElement("Description", typeof(object))]
        [XmlElement("Execution", typeof(TestRunConfigurationExecution))]
        [XmlElement("ExecutionThread", typeof(TestRunConfigurationExecutionThread))]
        [XmlElement("Hosts", typeof(TestRunConfigurationHosts))]
        [XmlElement("NamingScheme", typeof(TestRunConfigurationNamingScheme))]
        [XmlElement("Plugins", typeof(TestRunConfigurationPlugins))]
        [XmlElement("Remote", typeof(TestRunConfigurationRemote))]
        [XmlElement("Scripts", typeof(TestRunConfigurationScripts))]
        [XmlElement("TestTypeSpecific", typeof(TestRunConfigurationTestTypeSpecific))]
        [XmlElement("Timeouts", typeof(TestRunConfigurationTimeouts))]
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

        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }

            set
            {
                this.itemsElementNameField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool mapIPAddresses
        {
            get
            {
                return this.mapIPAddressesField;
            }

            set
            {
                this.mapIPAddressesField = value;
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

        [DefaultValue(false)]
        [XmlAttribute]
        public bool traceExecutionSequence
        {
            get
            {
                return this.traceExecutionSequenceField;
            }

            set
            {
                this.traceExecutionSequenceField = value;
            }
        }

        public TestRunConfiguration()
        {
            this.isExecutedRemotelyField = false;
            this.abortRunOnErrorField = false;
            this.autoSaveResultsField = true;
            this.mapIPAddressesField = false;
            this.traceExecutionSequenceField = false;
        }
    }
}