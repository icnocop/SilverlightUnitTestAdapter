// <copyright file="LoadTestType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlRoot("LoadTest", Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable=false)]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class LoadTestType
    {
        private LoadTestTypeScenarios[] scenariosField;

        private LoadTestTypeCounterSets[] counterSetsField;

        private LoadTestTypeRunConfigurations[] runConfigurationsField;

        private string idField;

        private string nameField;

        private string descriptionField;

        private string ownerField;

        private string storageField;

        private int priorityField;

        private bool priorityFieldSpecified;

        private bool enabledField;

        private bool enabledFieldSpecified;

        private string cssProjectStructureField;

        private string cssIterationField;

        private string deploymentItemsEditableField;

        private string workItemIdsField;

        private string traceLevelField;

        private string currentRunConfigField;

        private string loadTestPluginClassField;

        [XmlElement("CounterSets")]
        public LoadTestTypeCounterSets[] CounterSets
        {
            get
            {
                return this.counterSetsField;
            }

            set
            {
                this.counterSetsField = value;
            }
        }

        [XmlAttribute]
        public string CssIteration
        {
            get
            {
                return this.cssIterationField;
            }

            set
            {
                this.cssIterationField = value;
            }
        }

        [XmlAttribute]
        public string CssProjectStructure
        {
            get
            {
                return this.cssProjectStructureField;
            }

            set
            {
                this.cssProjectStructureField = value;
            }
        }

        [XmlAttribute]
        public string CurrentRunConfig
        {
            get
            {
                return this.currentRunConfigField;
            }

            set
            {
                this.currentRunConfigField = value;
            }
        }

        [XmlAttribute]
        public string DeploymentItemsEditable
        {
            get
            {
                return this.deploymentItemsEditableField;
            }

            set
            {
                this.deploymentItemsEditableField = value;
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
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }

            set
            {
                this.enabledField = value;
            }
        }

        [XmlIgnore]
        public bool EnabledSpecified
        {
            get
            {
                return this.enabledFieldSpecified;
            }

            set
            {
                this.enabledFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string Id
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

        [XmlAttribute]
        public string LoadTestPluginClass
        {
            get
            {
                return this.loadTestPluginClassField;
            }

            set
            {
                this.loadTestPluginClassField = value;
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
        public string Owner
        {
            get
            {
                return this.ownerField;
            }

            set
            {
                this.ownerField = value;
            }
        }

        [XmlAttribute]
        public int Priority
        {
            get
            {
                return this.priorityField;
            }

            set
            {
                this.priorityField = value;
            }
        }

        [XmlIgnore]
        public bool PrioritySpecified
        {
            get
            {
                return this.priorityFieldSpecified;
            }

            set
            {
                this.priorityFieldSpecified = value;
            }
        }

        [XmlElement("RunConfigurations")]
        public LoadTestTypeRunConfigurations[] RunConfigurations
        {
            get
            {
                return this.runConfigurationsField;
            }

            set
            {
                this.runConfigurationsField = value;
            }
        }

        [XmlElement("Scenarios")]
        public LoadTestTypeScenarios[] Scenarios
        {
            get
            {
                return this.scenariosField;
            }

            set
            {
                this.scenariosField = value;
            }
        }

        [XmlAttribute]
        public string storage
        {
            get
            {
                return this.storageField;
            }

            set
            {
                this.storageField = value;
            }
        }

        [XmlAttribute]
        public string TraceLevel
        {
            get
            {
                return this.traceLevelField;
            }

            set
            {
                this.traceLevelField = value;
            }
        }

        [XmlAttribute]
        public string WorkItemIds
        {
            get
            {
                return this.workItemIdsField;
            }

            set
            {
                this.workItemIdsField = value;
            }
        }
    }
}