// <copyright file="WebTestRequestTypeFormPostHttpBodyFileUploadParameter.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class WebTestRequestTypeFormPostHttpBodyFileUploadParameter
    {
        private string nameField;

        private string fileNameField;

        private string contentTypeField;

        [XmlAttribute]
        public string contentType
        {
            get
            {
                return this.contentTypeField;
            }

            set
            {
                this.contentTypeField = value;
            }
        }

        [XmlAttribute]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }

            set
            {
                this.fileNameField = value;
            }
        }

        [XmlAttribute]
        public string name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }
    }
}