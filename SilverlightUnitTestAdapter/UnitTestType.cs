// <copyright file="UnitTestType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml;
    using System.Xml.Serialization;

    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [GeneratedCode("xsd", "4.0.30319.17929")]
    [Serializable]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class UnitTestType : BaseTestType
    {
        private UnitTestTypeTestMethod testMethodField;

        private UnitTestTypeDataSource dataSourceField;

        private UnitTestTypeAspNet aspNetField;

        private object[] aspNetDevelopmentServersField;

        private XmlNode extensionField;

        public UnitTestTypeAspNet AspNet
        {
            get
            {
                return this.aspNetField;
            }

            set
            {
                this.aspNetField = value;
            }
        }

        [XmlArrayItem("DevelopmentServer", IsNullable=false)]
        public object[] AspNetDevelopmentServers
        {
            get
            {
                return this.aspNetDevelopmentServersField;
            }

            set
            {
                this.aspNetDevelopmentServersField = value;
            }
        }

        public UnitTestTypeDataSource DataSource
        {
            get
            {
                return this.dataSourceField;
            }

            set
            {
                this.dataSourceField = value;
            }
        }

        public XmlNode Extension
        {
            get
            {
                return this.extensionField;
            }

            set
            {
                this.extensionField = value;
            }
        }

        public UnitTestTypeTestMethod TestMethod
        {
            get
            {
                return this.testMethodField;
            }

            set
            {
                this.testMethodField = value;
            }
        }
    }
}