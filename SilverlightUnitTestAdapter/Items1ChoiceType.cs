// <copyright file="Items1ChoiceType.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
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
    public enum Items1ChoiceType
    {
        ByteArrayCache,
        TestRunConfiguration,
        TestSettings,
        WebRequestResults,
        WebTestRecordedResultFilePath,
        WebTestResultDetails,
        WebTestResultFilePath
    }
}