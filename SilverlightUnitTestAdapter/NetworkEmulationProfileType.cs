// <copyright file="NetworkEmulationProfileType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    [XmlRoot("NetworkEmulationProfile", Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable=false)]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class NetworkEmulationProfileType
    {
        private NetworkEmulationProfileTypeEmulation emulationField;

        private string nameField;

        private string bandwidthInKbpsField;

        [XmlAttribute]
        public string bandwidthInKbps
        {
            get
            {
                return this.bandwidthInKbpsField;
            }

            set
            {
                this.bandwidthInKbpsField = value;
            }
        }

        public NetworkEmulationProfileTypeEmulation Emulation
        {
            get
            {
                return this.emulationField;
            }

            set
            {
                this.emulationField = value;
            }
        }

        [XmlAttribute]
        public string name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }
    }
}