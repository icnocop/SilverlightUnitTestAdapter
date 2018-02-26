// <copyright file="DevelopmentServerType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class DevelopmentServerType
    {
        private string pathToWebSiteField;

        private string webApplicationRootField;

        private string nameField;

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

        [XmlAttribute]
        public string pathToWebSite
        {
            get
            {
                return this.pathToWebSiteField;
            }

            set
            {
                this.pathToWebSiteField = value;
            }
        }

        [XmlAttribute]
        public string webApplicationRoot
        {
            get
            {
                return this.webApplicationRootField;
            }

            set
            {
                this.webApplicationRootField = value;
            }
        }
    }
}