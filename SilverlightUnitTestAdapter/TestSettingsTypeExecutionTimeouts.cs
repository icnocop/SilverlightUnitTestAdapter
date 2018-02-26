// <copyright file="TestSettingsTypeExecutionTimeouts.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestSettingsTypeExecutionTimeouts
    {
        private int runTimeoutField;

        private int testTimeoutField;

        private int agentNotRespondingTimeoutField;

        private int deploymentTimeoutField;

        private int scriptTimeoutField;

        [DefaultValue(300000)]
        [XmlAttribute]
        public int agentNotRespondingTimeout
        {
            get
            {
                return this.agentNotRespondingTimeoutField;
            }

            set
            {
                this.agentNotRespondingTimeoutField = value;
            }
        }

        [DefaultValue(300000)]
        [XmlAttribute]
        public int deploymentTimeout
        {
            get
            {
                return this.deploymentTimeoutField;
            }

            set
            {
                this.deploymentTimeoutField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int runTimeout
        {
            get
            {
                return this.runTimeoutField;
            }

            set
            {
                this.runTimeoutField = value;
            }
        }

        [DefaultValue(300000)]
        [XmlAttribute]
        public int scriptTimeout
        {
            get
            {
                return this.scriptTimeoutField;
            }

            set
            {
                this.scriptTimeoutField = value;
            }
        }

        [DefaultValue(1800000)]
        [XmlAttribute]
        public int testTimeout
        {
            get
            {
                return this.testTimeoutField;
            }

            set
            {
                this.testTimeoutField = value;
            }
        }

        public TestSettingsTypeExecutionTimeouts()
        {
            this.runTimeoutField = 0;
            this.testTimeoutField = 1800000;
            this.agentNotRespondingTimeoutField = 300000;
            this.deploymentTimeoutField = 300000;
            this.scriptTimeoutField = 300000;
        }
    }
}