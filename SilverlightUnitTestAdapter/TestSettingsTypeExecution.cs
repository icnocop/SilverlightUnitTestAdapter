// <copyright file="TestSettingsTypeExecution.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestSettingsTypeExecution
    {
        private TestSettingsTypeExecutionBuckets bucketsField;

        private TestSettingsTypeExecutionExecutionThread executionThreadField;

        private TestSettingsTypeExecutionHosts hostsField;

        private TestSettingsTypeExecutionTestTypeSpecific testTypeSpecificField;

        private TestSettingsTypeExecutionTimeouts timeoutsField;

        private AgentRuleType agentRuleField;

        private TestSettingsTypeExecutionLocation locationField;

        private HostProcessPlatformTypeEnum hostProcessPlatformField;

        private int parallelTestCountField;

        public AgentRuleType AgentRule
        {
            get
            {
                return this.agentRuleField;
            }

            set
            {
                this.agentRuleField = value;
            }
        }

        public TestSettingsTypeExecutionBuckets Buckets
        {
            get
            {
                return this.bucketsField;
            }

            set
            {
                this.bucketsField = value;
            }
        }

        public TestSettingsTypeExecutionExecutionThread ExecutionThread
        {
            get
            {
                return this.executionThreadField;
            }

            set
            {
                this.executionThreadField = value;
            }
        }

        [DefaultValue(HostProcessPlatformTypeEnum.X86)]
        [XmlAttribute]
        public HostProcessPlatformTypeEnum hostProcessPlatform
        {
            get
            {
                return this.hostProcessPlatformField;
            }

            set
            {
                this.hostProcessPlatformField = value;
            }
        }

        public TestSettingsTypeExecutionHosts Hosts
        {
            get
            {
                return this.hostsField;
            }

            set
            {
                this.hostsField = value;
            }
        }

        [DefaultValue(TestSettingsTypeExecutionLocation.Local)]
        [XmlAttribute]
        public TestSettingsTypeExecutionLocation location
        {
            get
            {
                return this.locationField;
            }

            set
            {
                this.locationField = value;
            }
        }

        [DefaultValue(1)]
        [XmlAttribute]
        public int parallelTestCount
        {
            get
            {
                return this.parallelTestCountField;
            }

            set
            {
                this.parallelTestCountField = value;
            }
        }

        public TestSettingsTypeExecutionTestTypeSpecific TestTypeSpecific
        {
            get
            {
                return this.testTypeSpecificField;
            }

            set
            {
                this.testTypeSpecificField = value;
            }
        }

        public TestSettingsTypeExecutionTimeouts Timeouts
        {
            get
            {
                return this.timeoutsField;
            }

            set
            {
                this.timeoutsField = value;
            }
        }

        public TestSettingsTypeExecution()
        {
            this.locationField = TestSettingsTypeExecutionLocation.Local;
            this.hostProcessPlatformField = HostProcessPlatformTypeEnum.X86;
            this.parallelTestCountField = 1;
        }
    }
}