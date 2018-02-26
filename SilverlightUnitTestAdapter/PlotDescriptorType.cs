// <copyright file="PlotDescriptorType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class PlotDescriptorType
    {
        private CounterDescriptorType counterDescriptorField;

        private int colorArgbField;

        private int lineStyleField;

        private double fixedRangeField;

        private bool showOnGraphField;

        private bool isSelectedField;

        private string counterMetadataField;

        private string rangeGroupField;

        [XmlAttribute]
        public int colorArgb
        {
            get
            {
                return this.colorArgbField;
            }

            set
            {
                this.colorArgbField = value;
            }
        }

        public CounterDescriptorType CounterDescriptor
        {
            get
            {
                return this.counterDescriptorField;
            }

            set
            {
                this.counterDescriptorField = value;
            }
        }

        [XmlAttribute]
        public string counterMetadata
        {
            get
            {
                return this.counterMetadataField;
            }

            set
            {
                this.counterMetadataField = value;
            }
        }

        [XmlAttribute]
        public double fixedRange
        {
            get
            {
                return this.fixedRangeField;
            }

            set
            {
                this.fixedRangeField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool isSelected
        {
            get
            {
                return this.isSelectedField;
            }

            set
            {
                this.isSelectedField = value;
            }
        }

        [XmlAttribute]
        public int lineStyle
        {
            get
            {
                return this.lineStyleField;
            }

            set
            {
                this.lineStyleField = value;
            }
        }

        [XmlAttribute]
        public string rangeGroup
        {
            get
            {
                return this.rangeGroupField;
            }

            set
            {
                this.rangeGroupField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool showOnGraph
        {
            get
            {
                return this.showOnGraphField;
            }

            set
            {
                this.showOnGraphField = value;
            }
        }

        public PlotDescriptorType()
        {
            this.showOnGraphField = true;
            this.isSelectedField = false;
        }
    }
}