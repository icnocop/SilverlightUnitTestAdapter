// <copyright file="TestRunTypeTimes.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestRunTypeTimes
    {
        private string creationField;

        private string queuingField;

        private string startField;

        private string finishField;

        [XmlAttribute]
        public string creation
        {
            get
            {
                return this.creationField;
            }

            set
            {
                this.creationField = value;
            }
        }

        [XmlAttribute]
        public string finish
        {
            get
            {
                return this.finishField;
            }

            set
            {
                this.finishField = value;
            }
        }

        [XmlAttribute]
        public string queuing
        {
            get
            {
                return this.queuingField;
            }

            set
            {
                this.queuingField = value;
            }
        }

        [XmlAttribute]
        public string start
        {
            get
            {
                return this.startField;
            }

            set
            {
                this.startField = value;
            }
        }
    }
}