// <copyright file="TestEntriesType1.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlType(TypeName="TestEntriesType", Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class TestEntriesType1
    {
        private TestEntryType[] testEntryField;

        [XmlElement("TestEntry")]
        public TestEntryType[] TestEntry
        {
            get
            {
                return this.testEntryField;
            }

            set
            {
                this.testEntryField = value;
            }
        }
    }
}