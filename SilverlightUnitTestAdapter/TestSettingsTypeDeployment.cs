// <copyright file="TestSettingsTypeDeployment.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestSettingsTypeDeployment : DeploymentItemsType
    {
        private bool deploySatelliteAssembliesField;

        private string ignoredDependentAssembliesField;

        private string userDeploymentRootField;

        private string runDeploymentRootField;

        private bool useDefaultDeploymentRootField;

        private bool enabledField;

        private bool uploadDeploymentItemsField;

        [DefaultValue(false)]
        [XmlAttribute]
        public bool deploySatelliteAssemblies
        {
            get
            {
                return this.deploySatelliteAssembliesField;
            }

            set
            {
                this.deploySatelliteAssembliesField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool enabled
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

        [XmlAttribute]
        public string ignoredDependentAssemblies
        {
            get
            {
                return this.ignoredDependentAssembliesField;
            }

            set
            {
                this.ignoredDependentAssembliesField = value;
            }
        }

        [XmlAttribute]
        public string runDeploymentRoot
        {
            get
            {
                return this.runDeploymentRootField;
            }

            set
            {
                this.runDeploymentRootField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool uploadDeploymentItems
        {
            get
            {
                return this.uploadDeploymentItemsField;
            }

            set
            {
                this.uploadDeploymentItemsField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool useDefaultDeploymentRoot
        {
            get
            {
                return this.useDefaultDeploymentRootField;
            }

            set
            {
                this.useDefaultDeploymentRootField = value;
            }
        }

        [XmlAttribute]
        public string userDeploymentRoot
        {
            get
            {
                return this.userDeploymentRootField;
            }

            set
            {
                this.userDeploymentRootField = value;
            }
        }

        public TestSettingsTypeDeployment()
        {
            this.deploySatelliteAssembliesField = false;
            this.useDefaultDeploymentRootField = true;
            this.enabledField = true;
            this.uploadDeploymentItemsField = false;
        }
    }
}