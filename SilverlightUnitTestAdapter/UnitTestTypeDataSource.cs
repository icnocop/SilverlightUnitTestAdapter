// <copyright file="UnitTestTypeDataSource.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class UnitTestTypeDataSource
    {
        private string settingNameField;

        private string accessMethodField;

        private string connectionStringField;

        private string providerInvariantNameField;

        private string tableNameField;

        [XmlAttribute]
        public string accessMethod
        {
            get
            {
                return this.accessMethodField;
            }

            set
            {
                this.accessMethodField = value;
            }
        }

        [XmlAttribute]
        public string connectionString
        {
            get
            {
                return this.connectionStringField;
            }

            set
            {
                this.connectionStringField = value;
            }
        }

        [XmlAttribute]
        public string providerInvariantName
        {
            get
            {
                return this.providerInvariantNameField;
            }

            set
            {
                this.providerInvariantNameField = value;
            }
        }

        [XmlAttribute]
        public string settingName
        {
            get
            {
                return this.settingNameField;
            }

            set
            {
                this.settingNameField = value;
            }
        }

        [XmlAttribute]
        public string tableName
        {
            get
            {
                return this.tableNameField;
            }

            set
            {
                this.tableNameField = value;
            }
        }
    }
}