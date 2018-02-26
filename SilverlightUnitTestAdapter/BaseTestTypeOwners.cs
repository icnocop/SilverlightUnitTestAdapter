// <copyright file="BaseTestTypeOwners.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public class BaseTestTypeOwners
    {
        private BaseTestTypeOwnersOwner ownerField;

        public BaseTestTypeOwnersOwner Owner
        {
            get
            {
                return this.ownerField;
            }

            set
            {
                this.ownerField = value;
            }
        }
    }
}