// <copyright file="UnitTestResultType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class UnitTestResultType : TestResultAggregationType
    {
        private XmlNode extensionResultField;

        private string resultTypeField;

        private string dataRowInfoField;

        private bool hasSufficientAccessField;

        [XmlAttribute]
        public string dataRowInfo
        {
            get
            {
                return this.dataRowInfoField;
            }

            set
            {
                this.dataRowInfoField = value;
            }
        }

        public XmlNode ExtensionResult
        {
            get
            {
                return this.extensionResultField;
            }

            set
            {
                this.extensionResultField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool hasSufficientAccess
        {
            get
            {
                return this.hasSufficientAccessField;
            }

            set
            {
                this.hasSufficientAccessField = value;
            }
        }

        [XmlAttribute]
        public string resultType
        {
            get
            {
                return this.resultTypeField;
            }

            set
            {
                this.resultTypeField = value;
            }
        }

        public UnitTestResultType()
        {
            this.hasSufficientAccessField = true;
        }
    }
}