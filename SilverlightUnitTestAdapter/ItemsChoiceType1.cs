// <copyright file="ItemsChoiceType1.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.0.30319.17929")]
    [Serializable]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IncludeInSchema=false)]
    public enum ItemsChoiceType1
    {
        Buckets,
        CodeCoverage,
        Constraints,
        Deployment,
        Description,
        Execution,
        ExecutionThread,
        Hosts,
        NamingScheme,
        Plugins,
        Remote,
        Scripts,
        TestTypeSpecific,
        Timeouts
    }
}