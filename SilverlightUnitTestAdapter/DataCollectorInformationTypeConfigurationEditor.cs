// <copyright file="DataCollectorInformationTypeConfigurationEditor.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class DataCollectorInformationTypeConfigurationEditor
    {
        private string typeUriField;

        private string assemblyQualifiedNameField;

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