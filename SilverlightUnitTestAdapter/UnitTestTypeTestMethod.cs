// <copyright file="UnitTestTypeTestMethod.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class UnitTestTypeTestMethod
    {
        private string codeBaseField;

        private string classNameField;

        private string nameField;

        private bool isValidField;

        private string adapterTypeNameField;

        [XmlAttribute]
        public string adapterTypeName
        {
            get
            {
                return this.adapterTypeNameField;
            }

            set
            {
                this.adapterTypeNameField = value;
            }
        }

        [XmlAttribute]
        public string className
        {
            get
            {
                return this.classNameField;
            }

            set
            {
                this.classNameField = value;
            }
        }

        [XmlAttribute]
        public string codeBase
        {
            get
            {
                return this.codeBaseField;
            }

            set
            {
                this.codeBaseField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool isValid
        {
            get
            {
                return this.isValidField;
            }

            set
            {
                this.isValidField = value;
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

        public UnitTestTypeTestMethod()
        {
            this.isValidField = false;
        }
    }
}