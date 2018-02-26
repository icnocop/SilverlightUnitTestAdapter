// <copyright file="DiscoveryCacheTypeControllerAgent.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class DiscoveryCacheTypeControllerAgent
    {
        private DataCollectorInformationType dataCollectorInformationField;

        private NameValuePropertyType[] agentPropertiesField;

        private string nameField;

        [XmlArrayItem("Property", IsNullable=false)]
        public NameValuePropertyType[] AgentProperties
        {
            get
            {
                return this.agentPropertiesField;
            }

            set
            {
                this.agentPropertiesField = value;
            }
        }

        public DataCollectorInformationType DataCollectorInformation
        {
            get
            {
                return this.dataCollectorInformationField;
            }

            set
            {
                this.dataCollectorInformationField = value;
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
    }
}