// <copyright file="BaseTestTypeCss.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class BaseTestTypeCss
    {
        private string projectStructureField;

        private string iterationField;

        [XmlAttribute]
        public string iteration
        {
            get
            {
                return this.iterationField;
            }

            set
            {
                this.iterationField = value;
            }
        }

        [XmlAttribute]
        public string projectStructure
        {
            get
            {
                return this.projectStructureField;
            }

            set
            {
                this.projectStructureField = value;
            }
        }
    }
}