// <copyright file="TestOutcome.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [GeneratedCode("xsd", "4.0.30319.17929")]
    [Serializable]
    [XmlType(Namespace="http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum TestOutcome
    {
        Error,
        Failed,
        Timeout,
        Aborted,
        Inconclusive,
        PassedButRunAborted,
        NotRunnable,
        NotExecuted,
        Disconnected,
        Warning,
        Passed,
        Completed,
        InProgress,
        Pending
    }
}