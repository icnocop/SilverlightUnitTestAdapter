// <copyright file="DataCollectorExceptionMessageType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class DataCollectorExceptionMessageType : DataCollectorMessageType
    {
        private string exceptionTypeField;

        private string exceptionMessageField;

        private string stackTraceField;

        public string ExceptionMessage
        {
            get
            {
                return this.exceptionMessageField;
            }

            set
            {
                this.exceptionMessageField = value;
            }
        }

        public string ExceptionType
        {
            get
            {
                return this.exceptionTypeField;
            }

            set
            {
                this.exceptionTypeField = value;
            }
        }

        public string StackTrace
        {
            get
            {
                return this.stackTraceField;
            }

            set
            {
                this.stackTraceField = value;
            }
        }
    }
}