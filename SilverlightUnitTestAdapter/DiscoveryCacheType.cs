// <copyright file="DiscoveryCacheType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlRoot("DiscoveryCache", Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable=false)]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class DiscoveryCacheType
    {
        private DiscoveryCacheTypeController[] remoteAgentsField;

        [XmlArrayItem("Controller", IsNullable=false)]
        public DiscoveryCacheTypeController[] RemoteAgents
        {
            get
            {
                return this.remoteAgentsField;
            }

            set
            {
                this.remoteAgentsField = value;
            }
        }
    }
}