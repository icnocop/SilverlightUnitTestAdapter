// <copyright file="LoadTestTypeScenariosScenarioBrowserMixBrowserProfile.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestTypeScenariosScenarioBrowserMixBrowserProfile
    {
        private LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowser browserField;

        private float percentageField;

        public LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowser Browser
        {
            get
            {
                return this.browserField;
            }

            set
            {
                this.browserField = value;
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