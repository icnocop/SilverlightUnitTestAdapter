// <copyright file="CodedWebTestElementTypeWebTestClass.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class CodedWebTestElementTypeWebTestClass
    {
        private string assemblyField;

        private string namespaceField;

        private string classField;

        [XmlAttribute]
        public string assembly
        {
            get
            {
                return this.assemblyField;
            }

            set
            {
                this.assemblyField = value;
            }
        }

        [XmlAttribute]
        public string @class
        {
            get
            {
                return this.classField;
            }

            set
            {
                this.classField = value;
            }
        }

        [XmlAttribute]
        public string @namespace
        {
            get
            {
                return this.namespaceField;
            }

            set
            {
                this.namespaceField = value;
            }
        }
    }
}