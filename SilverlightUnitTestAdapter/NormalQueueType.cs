// <copyright file="NormalQueueType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class NormalQueueType
    {
        private UnitType queueModeField;

        private string sizeField;

        private DropType dropTypeField;

        public DropType DropType
        {
            get
            {
                return this.dropTypeField;
            }

            set
            {
                this.dropTypeField = value;
            }
        }

        public UnitType QueueMode
        {
            get
            {
                return this.queueModeField;
            }

            set
            {
                this.queueModeField = value;
            }
        }

        [XmlElement(DataType="positiveInteger")]
        public string Size
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
    }
}