// <copyright file="LoadTestTypeScenariosScenarioNetworkMixNetworkProfile.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestTypeScenariosScenarioNetworkMixNetworkProfile
    {
        private NetworkType networkField;

        private float percentageField;

        public NetworkType Network
        {
            get
            {
                return this.networkField;
            }

            set
            {
                this.networkField = value;
            }
        }

        [XmlAttribute]
        public float Percentage
        {
            get
            {
                return this.percentageField;
            }

            set
            {
                this.percentageField = value;
            }
        }
    }
}