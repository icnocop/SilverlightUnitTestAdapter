// <copyright file="WebRequestResultsType1.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlType(TypeName="WebRequestResultsType", Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class WebRequestResultsType1
    {
        private WebRequestResultType[] webRequestResultField;

        [XmlElement("WebRequestResult")]
        public WebRequestResultType[] WebRequestResult
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