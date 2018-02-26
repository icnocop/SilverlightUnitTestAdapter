// <copyright file="DataCollectorMessageType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlInclude(typeof(DataCollectorExceptionMessageType))]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class DataCollectorMessageType
    {
        private string textField;

        private DataCollectorMessageLevelType levelField;

        private string agentNameField;

        private string timestampField;

        private string dataCollectorUriField;

        private string dataCollectorFriendlyNameField;

        [XmlAttribute]
        public string agentName
        {
            get
            {
                return this.agentNameField;
            }

            set
            {
                this.agentNameField = value;
            }
        }

        [XmlAttribute]
        public string dataCollectorFriendlyName
        {
            get
            {
                return this.dataCollectorFriendlyNameField;
            }

            set
            {
                this.dataCollectorFriendlyNameField = value;
            }
        }

        [XmlAttribute]
        public string dataCollectorUri
        {
            get
            {
                return this.dataCollectorUriField;
            }

            set
            {
                this.dataCollectorUriField = value;
            }
        }

        [XmlAttribute]
        public DataCollectorMessageLevelType level
        {
            get
            {
                return this.levelField;
            }

            set
            {
                this.levelField = value;
            }
        }

        public string Text
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
        public string timestamp
        {
            get
            {
                return this.timestampField;
            }

            set
            {
                this.timestampField = value;
            }
        }
    }
}