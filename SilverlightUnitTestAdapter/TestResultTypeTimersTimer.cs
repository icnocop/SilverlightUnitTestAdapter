// <copyright file="TestResultTypeTimersTimer.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestResultTypeTimersTimer
    {
        private string nameField;

        private string startTimeField;

        private int durationField;

        private bool durationFieldSpecified;

        [XmlAttribute]
        public int duration
        {
            get
            {
                return this.durationField;
            }

            set
            {
                this.durationField = value;
            }
        }

        [XmlIgnore]
        public bool durationSpecified
        {
            get
            {
                return this.durationFieldSpecified;
            }

            set
            {
                this.durationFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        [XmlAttribute]
        public string startTime
        {
            get
            {
                return this.startTimeField;
            }

            set
            {
                this.startTimeField = value;
            }
        }
    }
}