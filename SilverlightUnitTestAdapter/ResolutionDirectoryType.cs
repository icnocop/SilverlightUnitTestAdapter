// <copyright file="ResolutionDirectoryType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlInclude(typeof(RuntimeResolutionDirectoryType))]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class ResolutionDirectoryType
    {
        private string pathField;

        private bool includeSubDirectoriesField;

        [XmlAttribute]
        public bool includeSubDirectories
        {
            get
            {
                return this.includeSubDirectoriesField;
            }

            set
            {
                this.includeSubDirectoriesField = value;
            }
        }

        [XmlAttribute]
        public string path
        {
            get
            {
                return this.pathField;
            }

            set
            {
                this.pathField = value;
            }
        }
    }
}