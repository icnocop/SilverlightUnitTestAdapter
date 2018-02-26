// <copyright file="TestSettingsTypeExecutionHosts.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestSettingsTypeExecutionHosts
    {
        private object[] itemsField;

        private string typeField;

        private bool skipUnhostableTestsField;

        [XmlAnyElement]
        [XmlElement("AspNet", typeof(TestSettingsTypeExecutionHostsAspNet))]
        [XmlElement("DeviceHostRunConfigData", typeof(TestSettingsTypeExecutionHostsDeviceHostRunConfigData))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }

            set
            {
                this.itemsField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool skipUnhostableTests
        {
            get
            {
                return this.skipUnhostableTestsField;
            }

            set
            {
                this.skipUnhostableTestsField = value;
            }
        }

        [XmlAttribute]
        public string type
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

        public TestSettingsTypeExecutionHosts()
        {
            this.skipUnhostableTestsField = true;
        }
    }
}