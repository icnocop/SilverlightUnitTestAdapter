// <copyright file="LoadTestTypeScenariosScenario.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestTypeScenariosScenario
    {
        private LoadTestTypeScenariosScenarioThinkProfile thinkProfileField;

        private LoadTestTypeScenariosScenarioLoadProfile loadProfileField;

        private LoadTestTypeScenariosScenarioTestProfile[] testMixField;

        private LoadTestTypeScenariosScenarioBrowserMix browserMixField;

        private LoadTestTypeScenariosScenarioNetworkMix networkMixField;

        private string nameField;

        private string allowedAgentsField;

        private bool iPSwitchingField;

        private bool iPSwitchingFieldSpecified;

        private bool disableDuringWarmupField;

        private bool disableDuringWarmupFieldSpecified;

        private int delayStartTimeField;

        private bool delayStartTimeFieldSpecified;

        private int delayBetweenIterationsField;

        private bool delayBetweenIterationsFieldSpecified;

        private int maxTestIterationsField;

        private bool maxTestIterationsFieldSpecified;

        private int percentNewUsersField;

        private bool percentNewUsersFieldSpecified;

        private TestMixType testMixTypeField;

        private bool testMixTypeFieldSpecified;

        private bool applyDistributionToPacingDelayField;

        private bool applyDistributionToPacingDelayFieldSpecified;

        [XmlAttribute]
        public string AllowedAgents
        {
            get
            {
                return this.allowedAgentsField;
            }

            set
            {
                this.allowedAgentsField = value;
            }
        }

        [XmlAttribute]
        public bool ApplyDistributionToPacingDelay
        {
            get
            {
                return this.applyDistributionToPacingDelayField;
            }

            set
            {
                this.applyDistributionToPacingDelayField = value;
            }
        }

        [XmlIgnore]
        public bool ApplyDistributionToPacingDelaySpecified
        {
            get
            {
                return this.applyDistributionToPacingDelayFieldSpecified;
            }

            set
            {
                this.applyDistributionToPacingDelayFieldSpecified = value;
            }
        }

        public LoadTestTypeScenariosScenarioBrowserMix BrowserMix
        {
            get
            {
                return this.browserMixField;
            }

            set
            {
                this.browserMixField = value;
            }
        }

        [XmlAttribute]
        public int DelayBetweenIterations
        {
            get
            {
                return this.delayBetweenIterationsField;
            }

            set
            {
                this.delayBetweenIterationsField = value;
            }
        }

        [XmlIgnore]
        public bool DelayBetweenIterationsSpecified
        {
            get
            {
                return this.delayBetweenIterationsFieldSpecified;
            }

            set
            {
                this.delayBetweenIterationsFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int DelayStartTime
        {
            get
            {
                return this.delayStartTimeField;
            }

            set
            {
                this.delayStartTimeField = value;
            }
        }

        [XmlIgnore]
        public bool DelayStartTimeSpecified
        {
            get
            {
                return this.delayStartTimeFieldSpecified;
            }

            set
            {
                this.delayStartTimeFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool DisableDuringWarmup
        {
            get
            {
                return this.disableDuringWarmupField;
            }

            set
            {
                this.disableDuringWarmupField = value;
            }
        }

        [XmlIgnore]
        public bool DisableDuringWarmupSpecified
        {
            get
            {
                return this.disableDuringWarmupFieldSpecified;
            }

            set
            {
                this.disableDuringWarmupFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool IPSwitching
        {
            get
            {
                return this.iPSwitchingField;
            }

            set
            {
                this.iPSwitchingField = value;
            }
        }

        [XmlIgnore]
        public bool IPSwitchingSpecified
        {
            get
            {
                return this.iPSwitchingFieldSpecified;
            }

            set
            {
                this.iPSwitchingFieldSpecified = value;
            }
        }

        public LoadTestTypeScenariosScenarioLoadProfile LoadProfile
        {
            get
            {
                return this.loadProfileField;
            }

            set
            {
                this.loadProfileField = value;
            }
        }

        [XmlAttribute]
        public int MaxTestIterations
        {
            get
            {
                return this.maxTestIterationsField;
            }

            set
            {
                this.maxTestIterationsField = value;
            }
        }

        [XmlIgnore]
        public bool MaxTestIterationsSpecified
        {
            get
            {
                return this.maxTestIterationsFieldSpecified;
            }

            set
            {
                this.maxTestIterationsFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string Name
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

        public LoadTestTypeScenariosScenarioNetworkMix NetworkMix
        {
            get
            {
                return this.networkMixField;
            }

            set
            {
                this.networkMixField = value;
            }
        }

        [XmlAttribute]
        public int PercentNewUsers
        {
            get
            {
                return this.percentNewUsersField;
            }

            set
            {
                this.percentNewUsersField = value;
            }
        }

        [XmlIgnore]
        public bool PercentNewUsersSpecified
        {
            get
            {
                return this.percentNewUsersFieldSpecified;
            }

            set
            {
                this.percentNewUsersFieldSpecified = value;
            }
        }

        [XmlArrayItem("TestProfile", IsNullable=false)]
        public LoadTestTypeScenariosScenarioTestProfile[] TestMix
        {
            get
            {
                return this.testMixField;
            }

            set
            {
                this.testMixField = value;
            }
        }

        [XmlAttribute]
        public TestMixType TestMixType
        {
            get
            {
                return this.testMixTypeField;
            }

            set
            {
                this.testMixTypeField = value;
            }
        }

        [XmlIgnore]
        public bool TestMixTypeSpecified
        {
            get
            {
                return this.testMixTypeFieldSpecified;
            }

            set
            {
                this.testMixTypeFieldSpecified = value;
            }
        }

        public LoadTestTypeScenariosScenarioThinkProfile ThinkProfile
        {
            get
            {
                return this.thinkProfileField;
            }

            set
            {
                this.thinkProfileField = value;
            }
        }
    }
}