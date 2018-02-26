// <copyright file="LoadTestTypeScenariosScenarioLoadProfile.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestTypeScenariosScenarioLoadProfile
    {
        private string patternField;

        private int initialUsersField;

        private int maxUsersField;

        private bool maxUsersFieldSpecified;

        private int stepUsersField;

        private bool stepUsersFieldSpecified;

        private int stepDurationField;

        private bool stepDurationFieldSpecified;

        private int stepRampTimeField;

        private bool stepRampTimeFieldSpecified;

        private string machineNameField;

        private string categoryNameField;

        private string counterNameField;

        private string instanceNameField;

        private int minUserCountField;

        private bool minUserCountFieldSpecified;

        private int maxUserCountField;

        private bool maxUserCountFieldSpecified;

        private int maxUserCountIncreaseField;

        private bool maxUserCountIncreaseFieldSpecified;

        private int maxUserCountDecreaseField;

        private bool maxUserCountDecreaseFieldSpecified;

        private int minTargetValueField;

        private bool minTargetValueFieldSpecified;

        private int maxTargetValueField;

        private bool maxTargetValueFieldSpecified;

        private bool higherValuesBetterField;

        private bool higherValuesBetterFieldSpecified;

        private bool stopAdjustingAtGoalField;

        private bool stopAdjustingAtGoalFieldSpecified;

        [XmlAttribute]
        public string CategoryName
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
        public string CounterName
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
        public bool HigherValuesBetter
        {
            get
            {
                return this.higherValuesBetterField;
            }

            set
            {
                this.higherValuesBetterField = value;
            }
        }

        [XmlIgnore]
        public bool HigherValuesBetterSpecified
        {
            get
            {
                return this.higherValuesBetterFieldSpecified;
            }

            set
            {
                this.higherValuesBetterFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int InitialUsers
        {
            get
            {
                return this.initialUsersField;
            }

            set
            {
                this.initialUsersField = value;
            }
        }

        [XmlAttribute]
        public string InstanceName
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

        [XmlAttribute]
        public string MachineName
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

        [XmlAttribute]
        public int MaxTargetValue
        {
            get
            {
                return this.maxTargetValueField;
            }

            set
            {
                this.maxTargetValueField = value;
            }
        }

        [XmlIgnore]
        public bool MaxTargetValueSpecified
        {
            get
            {
                return this.maxTargetValueFieldSpecified;
            }

            set
            {
                this.maxTargetValueFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int MaxUserCount
        {
            get
            {
                return this.maxUserCountField;
            }

            set
            {
                this.maxUserCountField = value;
            }
        }

        [XmlAttribute]
        public int MaxUserCountDecrease
        {
            get
            {
                return this.maxUserCountDecreaseField;
            }

            set
            {
                this.maxUserCountDecreaseField = value;
            }
        }

        [XmlIgnore]
        public bool MaxUserCountDecreaseSpecified
        {
            get
            {
                return this.maxUserCountDecreaseFieldSpecified;
            }

            set
            {
                this.maxUserCountDecreaseFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int MaxUserCountIncrease
        {
            get
            {
                return this.maxUserCountIncreaseField;
            }

            set
            {
                this.maxUserCountIncreaseField = value;
            }
        }

        [XmlIgnore]
        public bool MaxUserCountIncreaseSpecified
        {
            get
            {
                return this.maxUserCountIncreaseFieldSpecified;
            }

            set
            {
                this.maxUserCountIncreaseFieldSpecified = value;
            }
        }

        [XmlIgnore]
        public bool MaxUserCountSpecified
        {
            get
            {
                return this.maxUserCountFieldSpecified;
            }

            set
            {
                this.maxUserCountFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int MaxUsers
        {
            get
            {
                return this.maxUsersField;
            }

            set
            {
                this.maxUsersField = value;
            }
        }

        [XmlIgnore]
        public bool MaxUsersSpecified
        {
            get
            {
                return this.maxUsersFieldSpecified;
            }

            set
            {
                this.maxUsersFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int MinTargetValue
        {
            get
            {
                return this.minTargetValueField;
            }

            set
            {
                this.minTargetValueField = value;
            }
        }

        [XmlIgnore]
        public bool MinTargetValueSpecified
        {
            get
            {
                return this.minTargetValueFieldSpecified;
            }

            set
            {
                this.minTargetValueFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int MinUserCount
        {
            get
            {
                return this.minUserCountField;
            }

            set
            {
                this.minUserCountField = value;
            }
        }

        [XmlIgnore]
        public bool MinUserCountSpecified
        {
            get
            {
                return this.minUserCountFieldSpecified;
            }

            set
            {
                this.minUserCountFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public string Pattern
        {
            get
            {
                return this.patternField;
            }

            set
            {
                this.patternField = value;
            }
        }

        [XmlAttribute]
        public int StepDuration
        {
            get
            {
                return this.stepDurationField;
            }

            set
            {
                this.stepDurationField = value;
            }
        }

        [XmlIgnore]
        public bool StepDurationSpecified
        {
            get
            {
                return this.stepDurationFieldSpecified;
            }

            set
            {
                this.stepDurationFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int StepRampTime
        {
            get
            {
                return this.stepRampTimeField;
            }

            set
            {
                this.stepRampTimeField = value;
            }
        }

        [XmlIgnore]
        public bool StepRampTimeSpecified
        {
            get
            {
                return this.stepRampTimeFieldSpecified;
            }

            set
            {
                this.stepRampTimeFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int StepUsers
        {
            get
            {
                return this.stepUsersField;
            }

            set
            {
                this.stepUsersField = value;
            }
        }

        [XmlIgnore]
        public bool StepUsersSpecified
        {
            get
            {
                return this.stepUsersFieldSpecified;
            }

            set
            {
                this.stepUsersFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public bool StopAdjustingAtGoal
        {
            get
            {
                return this.stopAdjustingAtGoalField;
            }

            set
            {
                this.stopAdjustingAtGoalField = value;
            }
        }

        [XmlIgnore]
        public bool StopAdjustingAtGoalSpecified
        {
            get
            {
                return this.stopAdjustingAtGoalFieldSpecified;
            }

            set
            {
                this.stopAdjustingAtGoalFieldSpecified = value;
            }
        }
    }
}