// <copyright file="RedQueueType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class RedQueueType
    {
        private DropType dropTypeField;

        private UnitType queueModeField;

        private string minPacketField;

        private string maxPacketField;

        private string packetSizeField;

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

        [XmlElement(DataType="positiveInteger")]
        public string MaxPacket
        {
            get
            {
                return this.maxPacketField;
            }

            set
            {
                this.maxPacketField = value;
            }
        }

        [XmlElement(DataType="positiveInteger")]
        public string MinPacket
        {
            get
            {
                return this.minPacketField;
            }

            set
            {
                this.minPacketField = value;
            }
        }

        [XmlElement(DataType="positiveInteger")]
        public string PacketSize
        {
            get
            {
                return this.packetSizeField;
            }

            set
            {
                this.packetSizeField = value;
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
    }
}