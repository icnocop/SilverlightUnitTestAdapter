// <copyright file="CountersType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class CountersType
    {
        private int totalField;

        private bool totalFieldSpecified;

        private int errorField;

        private int failedField;

        private int timeoutField;

        private int abortedField;

        private int inconclusiveField;

        private int passedButRunAbortedField;

        private int notRunnableField;

        private int notExecutedField;

        private int executedField;

        private int disconnectedField;

        private int warningField;

        private int passedField;

        private int completedField;

        private int inProgressField;

        private int pendingField;

        private string valueField;

        [DefaultValue(0)]
        [XmlAttribute]
        public int aborted
        {
            get
            {
                return this.abortedField;
            }

            set
            {
                this.abortedField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int completed
        {
            get
            {
                return this.completedField;
            }

            set
            {
                this.completedField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int disconnected
        {
            get
            {
                return this.disconnectedField;
            }

            set
            {
                this.disconnectedField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int error
        {
            get
            {
                return this.errorField;
            }

            set
            {
                this.errorField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int executed
        {
            get
            {
                return this.executedField;
            }

            set
            {
                this.executedField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int failed
        {
            get
            {
                return this.failedField;
            }

            set
            {
                this.failedField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int inconclusive
        {
            get
            {
                return this.inconclusiveField;
            }

            set
            {
                this.inconclusiveField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int inProgress
        {
            get
            {
                return this.inProgressField;
            }

            set
            {
                this.inProgressField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int notExecuted
        {
            get
            {
                return this.notExecutedField;
            }

            set
            {
                this.notExecutedField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int notRunnable
        {
            get
            {
                return this.notRunnableField;
            }

            set
            {
                this.notRunnableField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int passed
        {
            get
            {
                return this.passedField;
            }

            set
            {
                this.passedField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int passedButRunAborted
        {
            get
            {
                return this.passedButRunAbortedField;
            }

            set
            {
                this.passedButRunAbortedField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int pending
        {
            get
            {
                return this.pendingField;
            }

            set
            {
                this.pendingField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int timeout
        {
            get
            {
                return this.timeoutField;
            }

            set
            {
                this.timeoutField = value;
            }
        }

        [XmlAttribute]
        public int total
        {
            get
            {
                return this.totalField;
            }

            set
            {
                this.totalField = value;
            }
        }

        [XmlIgnore]
        public bool totalSpecified
        {
            get
            {
                return this.totalFieldSpecified;
            }

            set
            {
                this.totalFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string value
        {
            get
            {
                return this.valueField;
            }

            set
            {
                this.valueField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int warning
        {
            get
            {
                return this.warningField;
            }

            set
            {
                this.warningField = value;
            }
        }

        public CountersType()
        {
            this.errorField = 0;
            this.failedField = 0;
            this.timeoutField = 0;
            this.abortedField = 0;
            this.inconclusiveField = 0;
            this.passedButRunAbortedField = 0;
            this.notRunnableField = 0;
            this.notExecutedField = 0;
            this.executedField = 0;
            this.disconnectedField = 0;
            this.warningField = 0;
            this.passedField = 0;
            this.completedField = 0;
            this.inProgressField = 0;
            this.pendingField = 0;
        }
    }
}