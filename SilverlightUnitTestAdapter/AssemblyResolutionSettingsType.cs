// <copyright file="AssemblyResolutionSettingsType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlRoot("TestExecution", Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable=false)]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class AssemblyResolutionSettingsType
    {
        private AssemblyResolutionSettingsTypeAssemblyResolution assemblyResolutionField;

        private string testTypeIdField;

        public AssemblyResolutionSettingsTypeAssemblyResolution AssemblyResolution
        {
            get
            {
                return this.assemblyResolutionField;
            }

            set
            {
                this.assemblyResolutionField = value;
            }
        }

        [XmlAttribute]
        public string testTypeId
        {
            get
            {
                return this.testTypeIdField;
            }

            set
            {
                this.testTypeIdField = value;
            }
        }
    }
}