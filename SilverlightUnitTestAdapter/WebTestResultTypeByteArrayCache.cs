// <copyright file="WebTestResultTypeByteArrayCache.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class WebTestResultTypeByteArrayCache
    {
        private WebTestResultTypeByteArrayCacheEntry[] entryField;

        private int nextHandleField;

        [XmlElement("Entry")]
        public WebTestResultTypeByteArrayCacheEntry[] Entry
        {
            get
            {
                return this.entryField;
            }

            set
            {
                this.entryField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int nextHandle
        {
            get
            {
                return this.nextHandleField;
            }

            set
            {
                this.nextHandleField = value;
            }
        }

        public WebTestResultTypeByteArrayCache()
        {
            this.nextHandleField = 0;
        }
    }
}