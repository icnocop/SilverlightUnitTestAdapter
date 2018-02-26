// <copyright file="TestSettingsType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlRoot("TestSettings", Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable=false)]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class TestSettingsType
    {
        private object descriptionField;

        private TestSettingsTypeDeployment deploymentField;

        private TestSettingsTypeNamingScheme namingSchemeField;

        private TestSettingsTypeScripts scriptsField;

        private object[] constraintsField;

        private TestSettingsTypeRemoteController remoteControllerField;

        private TestSettingsTypeExecution executionField;

        private AgentRuleCollectionType collectionOnlyAgentsField;

        private string idField;

        private string nameField;

        private bool abortRunOnErrorField;

        private bool autoSaveResultsField;

        private bool mapIPAddressesField;

        private bool traceExecutionSequenceField;

        private bool enableDefaultDataCollectorsField;

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

        public AgentRuleCollectionType CollectionOnlyAgents
        {
            get
            {
                return this.collectionOnlyAgentsField;
            }

            set
            {
                this.collectionOnlyAgentsField = value;
            }
        }

        [XmlArrayItem("Agent", IsNullable=false)]
        public object[] Constraints
        {
            get
            {
                return this.constraintsField;
            }

            set
            {
                this.constraintsField = value;
            }
        }

        public TestSettingsTypeDeployment Deployment
        {
            get
            {
                return this.deploymentField;
            }

            set
            {
                this.deploymentField = value;
            }
        }

        public object Description
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

        [DefaultValue(false)]
        [XmlAttribute]
        public bool enableDefaultDataCollectors
        {
            get
            {
                return this.enableDefaultDataCollectorsField;
            }

            set
            {
                this.enableDefaultDataCollectorsField = value;
            }
        }

        public TestSettingsTypeExecution Execution
        {
            get
            {
                return this.executionField;
            }

            set
            {
                this.executionField = value;
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

        public TestSettingsTypeNamingScheme NamingScheme
        {
            get
            {
                return this.namingSchemeField;
            }

            set
            {
                this.namingSchemeField = value;
            }
        }

        public TestSettingsTypeRemoteController RemoteController
        {
            get
            {
                return this.remoteControllerField;
            }

            set
            {
                this.remoteControllerField = value;
            }
        }

        public TestSettingsTypeScripts Scripts
        {
            get
            {
                return this.scriptsField;
            }

            set
            {
                this.scriptsField = value;
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

        public TestSettingsType()
        {
            this.abortRunOnErrorField = false;
            this.autoSaveResultsField = true;
            this.mapIPAddressesField = false;
            this.traceExecutionSequenceField = false;
            this.enableDefaultDataCollectorsField = false;
        }
    }
}