// <copyright file="IPlugin.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Plugin
{
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;

    /// <summary>
    /// Plugin.
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Transforms the test result.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="testResult">The test result.</param>
        void TransformTestResult(IMessageLogger logger, TestResult testResult);
    }
}
