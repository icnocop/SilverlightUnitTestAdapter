// <copyright file="ScenarioType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class ScenarioType
    {
        private ScenarioTypeLoadProfile loadProfileField;

        private ScenarioTypeThinkProfile thinkProfileField;

        private ScenarioTypeTestProfile[] testMixField;

        private ScenarioTypeBrowserProfile[] browserMixField;

        private ScenarioTypeNetworkProfile[] networkMixField;

        private string testMixTypeField;

        private string nameField;

        private string allowedAgentsField;

        private bool ipSwitchingField;

        private bool disableDuringWarmupField;

        private int delayBetweenIterationsField;

        private int maxTestIterationsField;

        private int delayStartTimeField;

        private int percentNewUsersField;

        [DefaultValue("")]
        [XmlAttribute]
        public string allowedAgents
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

        [XmlArrayItem("BrowserProfile", IsNullable=false)]
        public ScenarioTypeBrowserProfile[] BrowserMix
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

        [DefaultValue(0)]
        [XmlAttribute]
        public int delayBetweenIterations
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

        [DefaultValue(0)]
        [XmlAttribute]
        public int delayStartTime
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

        [DefaultValue(false)]
        [XmlAttribute]
        public bool disableDuringWarmup
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

        [DefaultValue(false)]
        [XmlAttribute]
        public bool ipSwitching
        {
            get
            {
                return this.ipSwitchingField;
            }

            set
            {
                this.ipSwitchingField = value;
            }
        }

        public ScenarioTypeLoadProfile LoadProfile
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

        [DefaultValue(0)]
        [XmlAttribute]
        public int maxTestIterations
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

        [XmlArrayItem("NetworkProfile", IsNullable=false)]
        public ScenarioTypeNetworkProfile[] NetworkMix
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

        [DefaultValue(100)]
        [XmlAttribute]
        public int percentNewUsers
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

        [XmlArrayItem("TestProfile", IsNullable=false)]
        public ScenarioTypeTestProfile[] TestMix
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
        public string testMixType
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

        public ScenarioTypeThinkProfile ThinkProfile
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

        public ScenarioType()
        {
            this.allowedAgentsField = "";
            this.ipSwitchingField = false;
            this.disableDuringWarmupField = false;
            this.delayBetweenIterationsField = 0;
            this.maxTestIterationsField = 0;
            this.delayStartTimeField = 0;
            this.percentNewUsersField = 100;
        }
    }
}