// <copyright file="BaseTestTypeExecution.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class BaseTestTypeExecution
    {
        private string idField;

        private string parentIdField;

        private bool isRunOnRestartField;

        private int timeOutField;

        [DefaultValue("00000000-0000-0000-0000-000000000000")]
        [XmlAttribute]
        public string id
        {
            get
            {
                return this.idField;
            }

            set
            {
                this.idField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool isRunOnRestart
        {
            get
            {
                return this.isRunOnRestartField;
            }

            set
            {
                this.isRunOnRestartField = value;
            }
        }

        [DefaultValue("00000000-0000-0000-0000-000000000000")]
        [XmlAttribute]
        public string parentId
        {
            get
            {
                return this.parentIdField;
            }

            set
            {
                this.parentIdField = value;
            }
        }

        [DefaultValue(0)]
        [XmlAttribute]
        public int timeOut
        {
            get
            {
                return this.timeOutField;
            }

            set
            {
                this.timeOutField = value;
            }
        }

        public BaseTestTypeExecution()
        {
            this.idField = "00000000-0000-0000-0000-000000000000";
            this.parentIdField = "00000000-0000-0000-0000-000000000000";
            this.isRunOnRestartField = false;
            this.timeOutField = 0;
        }
    }
}