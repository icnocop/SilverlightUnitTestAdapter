// <copyright file="WebTestResultDetailsType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class WebTestResultDetailsType
    {
        private WebTestResultDetailsTypeWebTestResultIteration[] webTestResultIterationsField;

        [XmlArrayItem("WebTestResultIteration", IsNullable=false)]
        public WebTestResultDetailsTypeWebTestResultIteration[] WebTestResultIterations
        {
            get
            {
                return this.webTestResultIterationsField;
            }

            set
            {
                this.webTestResultIterationsField = value;
            }
        }
    }
}