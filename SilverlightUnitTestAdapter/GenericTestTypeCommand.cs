// <copyright file="GenericTestTypeCommand.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class GenericTestTypeCommand
    {
        private GenericTestTypeCommandEnvironmentVariable[] environmentVariablesField;

        private string filenameField;

        private string argumentsField;

        private string workingDirectoryField;

        private int maxDurationField;

        private bool redirectStandardOutputAndErrorField;

        [XmlAttribute]
        public string arguments
        {
            get
            {
                return this.argumentsField;
            }

            set
            {
                this.argumentsField = value;
            }
        }

        [XmlArrayItem("EnvironmentVariable", IsNullable=false)]
        public GenericTestTypeCommandEnvironmentVariable[] EnvironmentVariables
        {
            get
            {
                return this.environmentVariablesField;
            }

            set
            {
                this.environmentVariablesField = value;
            }
        }

        [XmlAttribute]
        public string filename
        {
            get
            {
                return this.filenameField;
            }

            set
            {
                this.filenameField = value;
            }
        }

        [DefaultValue(3600000)]
        [XmlAttribute]
        public int maxDuration
        {
            get
            {
                return this.maxDurationField;
            }

            set
            {
                this.maxDurationField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool redirectStandardOutputAndError
        {
            get
            {
                return this.redirectStandardOutputAndErrorField;
            }

            set
            {
                this.redirectStandardOutputAndErrorField = value;
            }
        }

        [XmlAttribute]
        public string workingDirectory
        {
            get
            {
                return this.workingDirectoryField;
            }

            set
            {
                this.workingDirectoryField = value;
            }
        }

        public GenericTestTypeCommand()
        {
            this.maxDurationField = 3600000;
            this.redirectStandardOutputAndErrorField = true;
        }
    }
}