// <copyright file="WebTestResultDetailsTypeWebTestResultIteration.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class WebTestResultDetailsTypeWebTestResultIteration
    {
        private object[] webTestResultGroupField;

        private int iterationNumberField;

        [XmlAttribute]
        public int iterationNumber
        {
            get
            {
                return this.iterationNumberField;
            }

            set
            {
                this.iterationNumberField = value;
            }
        }

        [XmlArrayItem("WebTestResultComment", typeof(WebTestResultCommentType), IsNullable=false)]
        [XmlArrayItem("WebTestResultPage", typeof(WebTestResultPageType), IsNullable=false)]
        [XmlArrayItem("WebTestResultTransaction", typeof(WebTestResultTransactionType), IsNullable=false)]
        public object[] WebTestResultGroup
        {
            get
            {
                return this.webTestResultGroupField;
            }

            set
            {
                this.webTestResultGroupField = value;
            }
        }
    }
}