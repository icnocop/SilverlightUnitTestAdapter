// <copyright file="TestSettingsTypeExecutionBuckets.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class TestSettingsTypeExecutionBuckets
    {
        private int thresholdField;

        private int sizeField;

        [DefaultValue(200)]
        [XmlAttribute]
        public int size
        {
            get
            {
                return this.sizeField;
            }

            set
            {
                this.sizeField = value;
            }
        }

        [DefaultValue(1000)]
        [XmlAttribute]
        public int threshold
        {
            get
            {
                return this.thresholdField;
            }

            set
            {
                this.thresholdField = value;
            }
        }

        public TestSettingsTypeExecutionBuckets()
        {
            this.thresholdField = 1000;
            this.sizeField = 200;
        }
    }
}