// <copyright file="DataCollectorInformationType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class DataCollectorInformationType
    {
        private DataCollectorInformationTypeDataCollector[] dataCollectorsField;

        private DataCollectorInformationTypeConfigurationEditor[] configurationEditorsField;

        [XmlArrayItem("ConfigurationEditor", IsNullable=false)]
        public DataCollectorInformationTypeConfigurationEditor[] ConfigurationEditors
        {
            get
            {
                return this.configurationEditorsField;
            }

            set
            {
                this.configurationEditorsField = value;
            }
        }

        [XmlArrayItem("DataCollector", IsNullable=false)]
        public DataCollectorInformationTypeDataCollector[] DataCollectors
        {
            get
            {
                return this.dataCollectorsField;
            }

            set
            {
                this.dataCollectorsField = value;
            }
        }
    }
}