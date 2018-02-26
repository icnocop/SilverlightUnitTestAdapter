// <copyright file="LoadTestTypeScenariosScenarioTestProfile.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestTypeScenariosScenarioTestProfile
    {
        private string nameField;

        private string pathField;

        private string idField;

        private float percentageField;

        private string typeField;

        [XmlAttribute]
        public string Id
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
        public string Name
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
        public string Path
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
        public float Percentage
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
        public string Type
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