// <copyright file="Bandwidth.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlRoot(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable=false)]
    [XmlType(AnonymousType=true, Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class Bandwidth
    {
        private SpeedType speedField;

        private BandwidthQueueManagement queueManagementField;

        public BandwidthQueueManagement QueueManagement
        {
            get
            {
                return this.queueManagementField;
            }

            set
            {
                this.queueManagementField = value;
            }
        }

        public SpeedType Speed
        {
            get
            {
                return this.speedField;
            }

            set
            {
                this.speedField = value;
            }
        }
    }
}