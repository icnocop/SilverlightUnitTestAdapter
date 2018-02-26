// <copyright file="OutputType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class OutputType
    {
        private object stdOutField;

        private object stdErrField;

        private object debugTraceField;

        private object traceInfoField;

        private OutputTypeErrorInfo errorInfoField;

        private object exceptionField;

        private object[] textMessagesField;

        public object DebugTrace
        {
            get
            {
                return this.debugTraceField;
            }

            set
            {
                this.debugTraceField = value;
            }
        }

        public OutputTypeErrorInfo ErrorInfo
        {
            get
            {
                return this.errorInfoField;
            }

            set
            {
                this.errorInfoField = value;
            }
        }

        public object Exception
        {
            get
            {
                return this.exceptionField;
            }

            set
            {
                this.exceptionField = value;
            }
        }

        public object StdErr
        {
            get
            {
                return this.stdErrField;
            }

            set
            {
                this.stdErrField = value;
            }
        }

        public object StdOut
        {
            get
            {
                return this.stdOutField;
            }

            set
            {
                this.stdOutField = value;
            }
        }

        [XmlArrayItem("Message", IsNullable=false)]
        public object[] TextMessages
        {
            get
            {
                return this.textMessagesField;
            }

            set
            {
                this.textMessagesField = value;
            }
        }

        public object TraceInfo
        {
            get
            {
                return this.traceInfoField;
            }

            set
            {
                this.traceInfoField = value;
            }
        }
    }
}