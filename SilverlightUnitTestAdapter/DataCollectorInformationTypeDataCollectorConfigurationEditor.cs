// <copyright file="DataCollectorInformationTypeDataCollectorConfigurationEditor.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class DataCollectorInformationTypeDataCollectorConfigurationEditor
    {
        private DataCollectorInformationTypeDataCollectorConfigurationEditorConfiguration configurationField;

        private string typeUriField;

        private string helpUriField;

        public DataCollectorInformationTypeDataCollectorConfigurationEditorConfiguration Configuration
        {
            get
            {
                return this.configurationField;
            }

            set
            {
                this.configurationField = value;
            }
        }

        [XmlAttribute(DataType="anyURI")]
        public string helpUri
        {
            get
            {
                return this.helpUriField;
            }

            set
            {
                this.helpUriField = value;
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
    }
}