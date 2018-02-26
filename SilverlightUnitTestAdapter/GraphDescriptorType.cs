// <copyright file="GraphDescriptorType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class GraphDescriptorType
    {
        private RangeType horizontalZoomRangeField;

        private RangeType verticalZoomRangeField;

        private PlotDescriptorType[] plotDescriptorsField;

        private string graphNameField;

        [XmlAttribute]
        public string graphName
        {
            get
            {
                return this.graphNameField;
            }

            set
            {
                this.graphNameField = value;
            }
        }

        public RangeType HorizontalZoomRange
        {
            get
            {
                return this.horizontalZoomRangeField;
            }

            set
            {
                this.horizontalZoomRangeField = value;
            }
        }

        [XmlArrayItem("PlotDescriptor", IsNullable=false)]
        public PlotDescriptorType[] PlotDescriptors
        {
            get
            {
                return this.plotDescriptorsField;
            }

            set
            {
                this.plotDescriptorsField = value;
            }
        }

        public RangeType VerticalZoomRange
        {
            get
            {
                return this.verticalZoomRangeField;
            }

            set
            {
                this.verticalZoomRangeField = value;
            }
        }
    }
}