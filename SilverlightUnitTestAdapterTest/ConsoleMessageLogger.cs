// <copyright file="ConsoleMessageLogger.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapterTest
{
    using System;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;

    /// <summary>
    /// Console Message Logger.
    /// </summary>
    /// <seealso cref="Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.IMessageLogger" />
    [Serializable]
    public class ConsoleMessageLogger : IMessageLogger
    {
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="testMessageLevel">The test message level.</param>
        /// <param name="message">The message.</param>
        public void SendMessage(TestMessageLevel testMessageLevel, string message)
        {
            switch (testMessageLevel)
            {
                case TestMessageLevel.Informational:
                    Console.Out.WriteLine(message);
                    break;
                case TestMessageLevel.Warning:
                case TestMessageLevel.Error:
                    Console.Error.WriteLine(message);
                    break;
                default:
                    throw new NotSupportedException($"TestMessageLevel: {testMessageLevel}");
            }
        }
    }
}
