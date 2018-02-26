// <copyright file="CounterDescriptorType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class CounterDescriptorType
    {
        private string machineNameField;

        private string categoryNameField;

        private string counterNameField;

        private string instanceNameField;

        private string baseInstanceNameField;

        private int loadTestItemIdField;

        [XmlAttribute]
        public string baseInstanceName
        {
            get
            {
                return this.baseInstanceNameField;
            }

            set
            {
                this.baseInstanceNameField = value;
            }
        }

        [XmlAttribute]
        public string categoryName
        {
            get
            {
                return this.categoryNameField;
            }

            set
            {
                this.categoryNameField = value;
            }
        }

        [XmlAttribute]
        public string counterName
        {
            get
            {
                return this.counterNameField;
            }

            set
            {
                this.counterNameField = value;
            }
        }

        [XmlAttribute]
        public string instanceName
        {
            get
            {
                return this.instanceNameField;
            }

            set
            {
                this.instanceNameField = value;
            }
        }

        [DefaultValue(-1)]
        [XmlAttribute]
        public int loadTestItemId
        {
            get
            {
                return this.loadTestItemIdField;
            }

            set
            {
                this.loadTestItemIdField = value;
            }
        }

        [XmlAttribute]
        public string machineName
        {
            get
            {
                return this.machineNameField;
            }

            set
            {
                this.machineNameField = value;
            }
        }

        public CounterDescriptorType()
        {
            this.loadTestItemIdField = -1;
        }
    }
}