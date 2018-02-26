// <copyright file="LinkRule.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LinkRule
    {
        private Latency latencyField;

        private Error errorField;

        private Loss lossField;

        private Bandwidth bandwidthField;

        private BackgroundTraffic backgroundTrafficField;

        private Reorder reorderField;

        private Disconnection disconnectionField;

        private LinkRuleDir dirField;

        public BackgroundTraffic BackgroundTraffic
        {
            get
            {
                return this.backgroundTrafficField;
            }

            set
            {
                this.backgroundTrafficField = value;
            }
        }

        public Bandwidth Bandwidth
        {
            get
            {
                return this.bandwidthField;
            }

            set
            {
                this.bandwidthField = value;
            }
        }

        [XmlAttribute]
        public LinkRuleDir dir
        {
            get
            {
                return this.dirField;
            }

            set
            {
                this.dirField = value;
            }
        }

        public Disconnection Disconnection
        {
            get
            {
                return this.disconnectionField;
            }

            set
            {
                this.disconnectionField = value;
            }
        }

        public Error Error
        {
            get
            {
                return this.errorField;
            }

            set
            {
                this.errorField = value;
            }
        }

        public Latency Latency
        {
            get
            {
                return this.latencyField;
            }

            set
            {
                this.latencyField = value;
            }
        }

        public Loss Loss
        {
            get
            {
                return this.lossField;
            }

            set
            {
                this.lossField = value;
            }
        }

        public Reorder Reorder
        {
            get
            {
                return this.reorderField;
            }

            set
            {
                this.reorderField = value;
            }
        }
    }
}