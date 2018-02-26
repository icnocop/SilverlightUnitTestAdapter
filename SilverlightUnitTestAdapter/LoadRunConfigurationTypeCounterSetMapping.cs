// <copyright file="LoadRunConfigurationTypeCounterSetMapping.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadRunConfigurationTypeCounterSetMapping
    {
        private LoadRunConfigurationTypeCounterSetMappingCounterSetReferences counterSetReferencesField;

        private string computerNameField;

        [XmlAttribute]
        public string computerName
        {
            get
            {
                return this.computerNameField;
            }

            set
            {
                this.computerNameField = value;
            }
        }

        public LoadRunConfigurationTypeCounterSetMappingCounterSetReferences CounterSetReferences
        {
            get
            {
                return this.counterSetReferencesField;
            }

            set
            {
                this.counterSetReferencesField = value;
            }
        }
    }
}