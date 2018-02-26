// <copyright file="AssemblyResolutionSettingsTypeAssemblyResolution.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class AssemblyResolutionSettingsTypeAssemblyResolution
    {
        private AssemblyResolutionSettingsTypeAssemblyResolutionTestDirectory testDirectoryField;

        private RuntimeResolutionDirectoryType[] runtimeResolutionField;

        private ResolutionDirectoryType[] discoveryResolutionField;

        private string applicationBaseDirectoryField;

        [XmlAttribute]
        public string applicationBaseDirectory
        {
            get
            {
                return this.applicationBaseDirectoryField;
            }

            set
            {
                this.applicationBaseDirectoryField = value;
            }
        }

        [XmlArrayItem("Directory", IsNullable=false)]
        public ResolutionDirectoryType[] DiscoveryResolution
        {
            get
            {
                return this.discoveryResolutionField;
            }

            set
            {
                this.discoveryResolutionField = value;
            }
        }

        [XmlArrayItem("Directory", IsNullable=false)]
        public RuntimeResolutionDirectoryType[] RuntimeResolution
        {
            get
            {
                return this.runtimeResolutionField;
            }

            set
            {
                this.runtimeResolutionField = value;
            }
        }

        public AssemblyResolutionSettingsTypeAssemblyResolutionTestDirectory TestDirectory
        {
            get
            {
                return this.testDirectoryField;
            }

            set
            {
                this.testDirectoryField = value;
            }
        }
    }
}