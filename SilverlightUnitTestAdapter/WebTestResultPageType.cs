// <copyright file="WebTestResultPageType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class WebTestResultPageType
    {
        private WebRequestResultType webRequestResultField;

        private WebTestResultRedirectedPageType[] redirectedPagesField;

        [XmlArrayItem("RedirectedPage", IsNullable=false)]
        public WebTestResultRedirectedPageType[] RedirectedPages
        {
            get
            {
                return this.redirectedPagesField;
            }

            set
            {
                this.redirectedPagesField = value;
            }
        }

        public WebRequestResultType WebRequestResult
        {
            get
            {
                return this.webRequestResultField;
            }

            set
            {
                this.webRequestResultField = value;
            }
        }
    }
}