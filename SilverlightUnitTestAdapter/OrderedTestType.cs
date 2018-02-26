// <copyright file="OrderedTestType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlRoot("OrderedTest", Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable=false)]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class OrderedTestType : BaseTestType
    {
        private LinkType[] testLinksField;

        private bool continueAfterFailureField;

        [DefaultValue(false)]
        [XmlAttribute]
        public bool continueAfterFailure
        {
            get
            {
                return this.continueAfterFailureField;
            }

            set
            {
                this.continueAfterFailureField = value;
            }
        }

        [XmlArrayItem("TestLink", IsNullable=false)]
        public LinkType[] TestLinks
        {
            get
            {
                return this.testLinksField;
            }

            set
            {
                this.testLinksField = value;
            }
        }

        public OrderedTestType()
        {
            this.continueAfterFailureField = false;
        }
    }
}