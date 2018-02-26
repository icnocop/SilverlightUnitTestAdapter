// <copyright file="DataCollectorConfigurationSection.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlRoot("DataCollectorConfiguration", Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable=false)]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class DataCollectorConfigurationSection
    {
        private DataCollectorConfigurationSectionDataCollector[] dataCollectorField;

        [XmlElement("DataCollector")]
        public DataCollectorConfigurationSectionDataCollector[] DataCollector
        {
            get
            {
                return this.dataCollectorField;
            }

            set
            {
                this.dataCollectorField = value;
            }
        }
    }
}