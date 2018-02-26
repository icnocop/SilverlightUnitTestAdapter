// <copyright file="ScenarioTypeThinkProfile.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class ScenarioTypeThinkProfile
    {
        private int patternField;

        private double valueField;

        [DefaultValue(0)]
        [XmlAttribute]
        public int pattern
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

        [DefaultValue(0)]
        [XmlAttribute]
        public double value
        {
            get
            {
                return this.valueField;
            }

            set
            {
                this.valueField = value;
            }
        }

        public ScenarioTypeThinkProfile()
        {
            this.patternField = 0;
            this.valueField = 0;
        }
    }
}