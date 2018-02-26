// <copyright file="LoadTestRunDescriptorType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class LoadTestRunDescriptorType
    {
        private GraphDescriptorType[] graphDescriptorsField;

        private bool isLegendPanelVisibleField;

        private bool isOverviewPanelVisibleField;

        private bool isCounterPanelVisibleField;

        private bool scrollingGraphField;

        private bool minMaxGraphField;

        private bool showHorizontalGridOnGraphField;

        private bool showThresholdsOnGraphField;

        private bool showComparisonField;

        private bool showZoomField;

        private bool lockZoomField;

        private LoadTestRunDescriptorViewType activeConsoleViewField;

        private string selectedGraphPanel1Field;

        private string selectedGraphPanel2Field;

        private string selectedGraphPanel3Field;

        private string selectedGraphPanel4Field;

        private PanelLayoutType graphPanelLayoutField;

        private PanelLayoutType tablePanelLayoutField;

        private string selectedTablePanel1Field;

        private string selectedTablePanel2Field;

        private string selectedTablePanel3Field;

        private string selectedTablePanel4Field;

        private string controllerNameField;

        private bool isLocalRunField;

        private string testRunIdField;

        private int repositoryRunIdField;

        [DefaultValue(LoadTestRunDescriptorViewType.Graph)]
        [XmlAttribute]
        public LoadTestRunDescriptorViewType activeConsoleView
        {
            get
            {
                return this.activeConsoleViewField;
            }

            set
            {
                this.activeConsoleViewField = value;
            }
        }

        [XmlAttribute]
        public string controllerName
        {
            get
            {
                return this.controllerNameField;
            }

            set
            {
                this.controllerNameField = value;
            }
        }

        [XmlArrayItem("GraphDescriptor", IsNullable=false)]
        public GraphDescriptorType[] GraphDescriptors
        {
            get
            {
                return this.graphDescriptorsField;
            }

            set
            {
                this.graphDescriptorsField = value;
            }
        }

        [DefaultValue(PanelLayoutType.FourGrid)]
        [XmlAttribute]
        public PanelLayoutType graphPanelLayout
        {
            get
            {
                return this.graphPanelLayoutField;
            }

            set
            {
                this.graphPanelLayoutField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool isCounterPanelVisible
        {
            get
            {
                return this.isCounterPanelVisibleField;
            }

            set
            {
                this.isCounterPanelVisibleField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool isLegendPanelVisible
        {
            get
            {
                return this.isLegendPanelVisibleField;
            }

            set
            {
                this.isLegendPanelVisibleField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool isLocalRun
        {
            get
            {
                return this.isLocalRunField;
            }

            set
            {
                this.isLocalRunField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool isOverviewPanelVisible
        {
            get
            {
                return this.isOverviewPanelVisibleField;
            }

            set
            {
                this.isOverviewPanelVisibleField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool lockZoom
        {
            get
            {
                return this.lockZoomField;
            }

            set
            {
                this.lockZoomField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool minMaxGraph
        {
            get
            {
                return this.minMaxGraphField;
            }

            set
            {
                this.minMaxGraphField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int repositoryRunId
        {
            get
            {
                return this.repositoryRunIdField;
            }

            set
            {
                this.repositoryRunIdField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool scrollingGraph
        {
            get
            {
                return this.scrollingGraphField;
            }

            set
            {
                this.scrollingGraphField = value;
            }
        }

        [XmlAttribute]
        public string selectedGraphPanel1
        {
            get
            {
                return this.selectedGraphPanel1Field;
            }

            set
            {
                this.selectedGraphPanel1Field = value;
            }
        }

        [XmlAttribute]
        public string selectedGraphPanel2
        {
            get
            {
                return this.selectedGraphPanel2Field;
            }

            set
            {
                this.selectedGraphPanel2Field = value;
            }
        }

        [XmlAttribute]
        public string selectedGraphPanel3
        {
            get
            {
                return this.selectedGraphPanel3Field;
            }

            set
            {
                this.selectedGraphPanel3Field = value;
            }
        }

        [XmlAttribute]
        public string selectedGraphPanel4
        {
            get
            {
                return this.selectedGraphPanel4Field;
            }

            set
            {
                this.selectedGraphPanel4Field = value;
            }
        }

        [DefaultValue("Tests")]
        [XmlAttribute]
        public string selectedTablePanel1
        {
            get
            {
                return this.selectedTablePanel1Field;
            }

            set
            {
                this.selectedTablePanel1Field = value;
            }
        }

        [DefaultValue("Errors")]
        [XmlAttribute]
        public string selectedTablePanel2
        {
            get
            {
                return this.selectedTablePanel2Field;
            }

            set
            {
                this.selectedTablePanel2Field = value;
            }
        }

        [DefaultValue("Thresholds")]
        [XmlAttribute]
        public string selectedTablePanel3
        {
            get
            {
                return this.selectedTablePanel3Field;
            }

            set
            {
                this.selectedTablePanel3Field = value;
            }
        }

        [DefaultValue("Transactions")]
        [XmlAttribute]
        public string selectedTablePanel4
        {
            get
            {
                return this.selectedTablePanel4Field;
            }

            set
            {
                this.selectedTablePanel4Field = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool showComparison
        {
            get
            {
                return this.showComparisonField;
            }

            set
            {
                this.showComparisonField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool showHorizontalGridOnGraph
        {
            get
            {
                return this.showHorizontalGridOnGraphField;
            }

            set
            {
                this.showHorizontalGridOnGraphField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool showThresholdsOnGraph
        {
            get
            {
                return this.showThresholdsOnGraphField;
            }

            set
            {
                this.showThresholdsOnGraphField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool showZoom
        {
            get
            {
                return this.showZoomField;
            }

            set
            {
                this.showZoomField = value;
            }
        }

        [DefaultValue(PanelLayoutType.TwoHorizontal)]
        [XmlAttribute]
        public PanelLayoutType tablePanelLayout
        {
            get
            {
                return this.tablePanelLayoutField;
            }

            set
            {
                this.tablePanelLayoutField = value;
            }
        }

        [XmlAttribute]
        public string testRunId
        {
            get
            {
                return this.testRunIdField;
            }

            set
            {
                this.testRunIdField = value;
            }
        }

        public LoadTestRunDescriptorType()
        {
            this.isLegendPanelVisibleField = true;
            this.isOverviewPanelVisibleField = true;
            this.isCounterPanelVisibleField = true;
            this.scrollingGraphField = false;
            this.minMaxGraphField = false;
            this.showHorizontalGridOnGraphField = true;
            this.showThresholdsOnGraphField = false;
            this.showComparisonField = true;
            this.showZoomField = true;
            this.lockZoomField = true;
            this.activeConsoleViewField = LoadTestRunDescriptorViewType.Graph;
            this.graphPanelLayoutField = PanelLayoutType.FourGrid;
            this.tablePanelLayoutField = PanelLayoutType.TwoHorizontal;
            this.selectedTablePanel1Field = "Tests";
            this.selectedTablePanel2Field = "Errors";
            this.selectedTablePanel3Field = "Thresholds";
            this.selectedTablePanel4Field = "Transactions";
            this.isLocalRunField = true;
            this.repositoryRunIdField = 0;
        }
    }
}