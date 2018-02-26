// <copyright file="TestSettingsTypeExecutionHostsDeviceHostRunConfigData.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestSettingsTypeExecutionHostsDeviceHostRunConfigData
    {
        private string nameField;

        private string deviceIdField;

        private string deviceNameField;

        private string platformIdField;

        private string platformNameField;

        private string uiPlatformIdField;

        [XmlAttribute]
        public string deviceId
        {
            get
            {
                return this.deviceIdField;
            }

            set
            {
                this.deviceIdField = value;
            }
        }

        [XmlAttribute]
        public string deviceName
        {
            get
            {
                return this.deviceNameField;
            }

            set
            {
                this.deviceNameField = value;
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
        public string platformId
        {
            get
            {
                return this.platformIdField;
            }

            set
            {
                this.platformIdField = value;
            }
        }

        [XmlAttribute]
        public string platformName
        {
            get
            {
                return this.platformNameField;
            }

            set
            {
                this.platformNameField = value;
            }
        }

        [XmlAttribute]
        public string uiPlatformId
        {
            get
            {
                return this.uiPlatformIdField;
            }

            set
            {
                this.uiPlatformIdField = value;
            }
        }
    }
}