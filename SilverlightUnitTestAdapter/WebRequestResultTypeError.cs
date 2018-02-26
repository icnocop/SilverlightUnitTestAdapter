// <copyright file="WebRequestResultTypeError.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class WebRequestResultTypeError
    {
        private object stackTraceField;

        private object exceptionTextField;

        private WebTestErrorType typeField;

        private bool typeFieldSpecified;

        private string subTypeField;

        private string textField;

        private string stackTraceField1;

        private string exceptionTextField1;

        private string timeField;

        [XmlAttribute]
        public string exceptionText
        {
            get
            {
                return this.exceptionTextField1;
            }

            set
            {
                this.exceptionTextField1 = value;
            }
        }

        public object ExceptionText
        {
            get
            {
                return this.exceptionTextField;
            }

            set
            {
                this.exceptionTextField = value;
            }
        }

        [XmlAttribute]
        public string stackTrace
        {
            get
            {
                return this.stackTraceField1;
            }

            set
            {
                this.stackTraceField1 = value;
            }
        }

        public object StackTrace
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

        [XmlAttribute]
        public string subType
        {
            get
            {
                return this.subTypeField;
            }

            set
            {
                this.subTypeField = value;
            }
        }

        [XmlAttribute]
        public string text
        {
            get
            {
                return this.textField;
            }

            set
            {
                this.textField = value;
            }
        }

        [XmlAttribute]
        public string time
        {
            get
            {
                return this.timeField;
            }

            set
            {
                this.timeField = value;
            }
        }

        [XmlAttribute]
        public WebTestErrorType type
        {
            get
            {
                return this.typeField;
            }

            set
            {
                this.typeField = value;
            }
        }

        [XmlIgnore]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }

            set
            {
                this.typeFieldSpecified = value;
            }
        }
    }
}