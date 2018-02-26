// <copyright file="ManualTestResultType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class ManualTestResultType : TestResultType
    {
        private object commentsField;

        private string testFileField;

        public object Comments
        {
            get
            {
                return this.commentsField;
            }

            set
            {
                this.commentsField = value;
            }
        }

        [XmlAttribute]
        public string testFile
        {
            get
            {
                return this.testFileField;
            }

            set
            {
                this.testFileField = value;
            }
        }
    }
}