// <copyright file="ScenarioTypeTestProfile.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class ScenarioTypeTestProfile
    {
        private ScenarioTypeTestProfilePercentage percentageField;

        private string percentageField1;

        private string nameField;

        private string pathField;

        private string typeField;

        private string idField;

        [XmlAttribute]
        public string id
        {
            get
            {
                return this.idField;
            }

            set
            {
                this.idField = value;
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

        [XmlAttribute]
        public string percentage
        {
            get
            {
                return this.percentageField1;
            }

            set
            {
                this.percentageField1 = value;
            }
        }

        public ScenarioTypeTestProfilePercentage Percentage
        {
            get
            {
                return this.percentageField;
            }

            set
            {
                this.percentageField = value;
            }
        }

        [XmlAttribute]
        public string type
        {
            get
            {
                return this.typeField;
            }

            set
            {
                this.typeField = value;
            }
        }
    }
}