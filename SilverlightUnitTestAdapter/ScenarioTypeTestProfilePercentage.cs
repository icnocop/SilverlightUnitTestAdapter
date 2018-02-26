// <copyright file="ScenarioTypeTestProfilePercentage.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class ScenarioTypeTestProfilePercentage
    {
        private int hiField;

        private int loField;

        private int midField;

        private int flagsField;

        [DefaultValue(0)]
        [XmlAttribute]
        public int flags
        {
            get
            {
                return this.flagsField;
            }

            set
            {
                this.flagsField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int hi
        {
            get
            {
                return this.hiField;
            }

            set
            {
                this.hiField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int lo
        {
            get
            {
                return this.loField;
            }

            set
            {
                this.loField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int mid
        {
            get
            {
                return this.midField;
            }

            set
            {
                this.midField = value;
            }
        }

        public ScenarioTypeTestProfilePercentage()
        {
            this.hiField = 0;
            this.loField = 0;
            this.midField = 0;
            this.flagsField = 0;
        }
    }
}