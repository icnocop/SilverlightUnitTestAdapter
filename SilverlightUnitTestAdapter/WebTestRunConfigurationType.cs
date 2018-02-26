// <copyright file="WebTestRunConfigurationType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class WebTestRunConfigurationType
    {
        private BrowserType browserField;

        private NetworkType networkField;

        private bool simulateThinkTimesField;

        private bool useNewCookieDefaultPathField;

        private bool automaticallyDecompressResponseField;

        private bool steppingField;

        private bool runUntilDataExhaustedField;

        private int iterationCountField;

        private string testTypeIdField;

        [DefaultValue(true)]
        [XmlAttribute]
        public bool AutomaticallyDecompressResponse
        {
            get
            {
                return this.automaticallyDecompressResponseField;
            }

            set
            {
                this.automaticallyDecompressResponseField = value;
            }
        }

        public BrowserType Browser
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

        [DefaultValue(1)]
        [XmlAttribute]
        public int iterationCount
        {
            get
            {
                return this.iterationCountField;
            }

            set
            {
                this.iterationCountField = value;
            }
        }

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

        [DefaultValue(false)]
        [XmlAttribute]
        public bool runUntilDataExhausted
        {
            get
            {
                return this.runUntilDataExhaustedField;
            }

            set
            {
                this.runUntilDataExhaustedField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool simulateThinkTimes
        {
            get
            {
                return this.simulateThinkTimesField;
            }

            set
            {
                this.simulateThinkTimesField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool stepping
        {
            get
            {
                return this.steppingField;
            }

            set
            {
                this.steppingField = value;
            }
        }

        [XmlAttribute]
        public string testTypeId
        {
            get
            {
                return this.testTypeIdField;
            }

            set
            {
                this.testTypeIdField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool UseNewCookieDefaultPath
        {
            get
            {
                return this.useNewCookieDefaultPathField;
            }

            set
            {
                this.useNewCookieDefaultPathField = value;
            }
        }

        public WebTestRunConfigurationType()
        {
            this.simulateThinkTimesField = false;
            this.useNewCookieDefaultPathField = false;
            this.automaticallyDecompressResponseField = true;
            this.steppingField = false;
            this.runUntilDataExhaustedField = false;
            this.iterationCountField = 1;
        }
    }
}