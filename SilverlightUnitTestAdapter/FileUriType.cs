// <copyright file="FileUriType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class FileUriType
    {
        private string fileField;

        private string uriField;

        [XmlAttribute]
        public string file
        {
            get
            {
                return this.fileField;
            }

            set
            {
                this.fileField = value;
            }
        }

        [XmlAttribute]
        public string uri
        {
            get
            {
                return this.uriField;
            }

            set
            {
                this.uriField = value;
            }
        }
    }
}