// <copyright file="DataCollectorInformationTypeDataCollector.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class DataCollectorInformationTypeDataCollector
    {
        private object friendlyNameField;

        private object descriptionField;

        private DataCollectorInformationTypeDataCollectorDefaultConfiguration defaultConfigurationField;

        private DataCollectorInformationTypeDataCollectorConfigurationEditor configurationEditorField;

        private string typeUriField;

        private bool requiresOutOfProcessCollectionField;

        private bool requiresOutOfProcessCollectionFieldSpecified;

        private string assemblyQualifiedNameField;

        private bool isEnabledByDefaultField;

        private bool enabledOnCollectionOnlyAgentsField;

        private string supportedTestClientsField;

        private string supportedLocationsField;

        private string supportedAgentRoleTypesField;

        private bool isEnabledByDefaultForTailoredApplicationsField;

        private bool supportsTailoredApplicationsField;

        [XmlAttribute]
        public string assemblyQualifiedName
        {
            get
            {
                return this.assemblyQualifiedNameField;
            }

            set
            {
                this.assemblyQualifiedNameField = value;
            }
        }

        public DataCollectorInformationTypeDataCollectorConfigurationEditor ConfigurationEditor
        {
            get
            {
                return this.configurationEditorField;
            }

            set
            {
                this.configurationEditorField = value;
            }
        }

        public DataCollectorInformationTypeDataCollectorDefaultConfiguration DefaultConfiguration
        {
            get
            {
                return this.defaultConfigurationField;
            }

            set
            {
                this.defaultConfigurationField = value;
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

        [DefaultValue(true)]
        [XmlAttribute]
        public bool enabledOnCollectionOnlyAgents
        {
            get
            {
                return this.enabledOnCollectionOnlyAgentsField;
            }

            set
            {
                this.enabledOnCollectionOnlyAgentsField = value;
            }
        }

        public object FriendlyName
        {
            get
            {
                return this.friendlyNameField;
            }

            set
            {
                this.friendlyNameField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool isEnabledByDefault
        {
            get
            {
                return this.isEnabledByDefaultField;
            }

            set
            {
                this.isEnabledByDefaultField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool isEnabledByDefaultForTailoredApplications
        {
            get
            {
                return this.isEnabledByDefaultForTailoredApplicationsField;
            }

            set
            {
                this.isEnabledByDefaultForTailoredApplicationsField = value;
            }
        }

        [XmlAttribute]
        public bool requiresOutOfProcessCollection
        {
            get
            {
                return this.requiresOutOfProcessCollectionField;
            }

            set
            {
                this.requiresOutOfProcessCollectionField = value;
            }
        }

        [XmlIgnore]
        public bool requiresOutOfProcessCollectionSpecified
        {
            get
            {
                return this.requiresOutOfProcessCollectionFieldSpecified;
            }

            set
            {
                this.requiresOutOfProcessCollectionFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string supportedAgentRoleTypes
        {
            get
            {
                return this.supportedAgentRoleTypesField;
            }

            set
            {
                this.supportedAgentRoleTypesField = value;
            }
        }

        [XmlAttribute]
        public string supportedLocations
        {
            get
            {
                return this.supportedLocationsField;
            }

            set
            {
                this.supportedLocationsField = value;
            }
        }

        [XmlAttribute]
        public string supportedTestClients
        {
            get
            {
                return this.supportedTestClientsField;
            }

            set
            {
                this.supportedTestClientsField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool supportsTailoredApplications
        {
            get
            {
                return this.supportsTailoredApplicationsField;
            }

            set
            {
                this.supportsTailoredApplicationsField = value;
            }
        }

        [XmlAttribute(DataType="anyURI")]
        public string typeUri
        {
            get
            {
                return this.typeUriField;
            }

            set
            {
                this.typeUriField = value;
            }
        }

        public DataCollectorInformationTypeDataCollector()
        {
            this.isEnabledByDefaultField = false;
            this.enabledOnCollectionOnlyAgentsField = true;
            this.isEnabledByDefaultForTailoredApplicationsField = false;
            this.supportsTailoredApplicationsField = false;
        }
    }
}