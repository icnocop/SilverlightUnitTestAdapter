// <copyright file="ConsoleLogger.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.StatLight
{
    using System;
    using global::StatLight.Core.Common;

    /// <summary>
    /// Console Logger.
    /// </summary>
    public class ConsoleLogger : LoggerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleLogger" /> class.
        /// </summary>
        /// <param name="logChatterLevel">The log chatter level.</param>
        public ConsoleLogger(LogChatterLevels logChatterLevel)
            : base(logChatterLevel)
        {
        }

        /// <summary>
        /// Logs the specified message for debugging.
        /// </summary>
        /// <param name="message">The message.</param>
        public override void Debug(string message)
        {
            if (this.ShouldLog(LogChatterLevels.Debug))
            {
                this.Write("Debug", message);
            }
        }

        /// <summary>
        /// Logs the specified message for debugging.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="writeNewLine">if set to <c>true</c> writes a new line.</param>
        public override void Debug(string message, bool writeNewLine)
        {
            if (this.ShouldLog(LogChatterLevels.Debug))
            {
                this.Write("Debug", message);
            }
        }

        /// <summary>
        /// Logs the specified message for informational purposes.
        /// </summary>
        /// <param name="message">The message.</param>
        public override void Information(string message)
        {
            if (this.ShouldLog(LogChatterLevels.Information))
            {
                this.Write("Information", message);
            }
        }

        /// <summary>
        /// Logs the specified message as a warning.
        /// </summary>
        /// <param name="message">The message.</param>
        public override void Warning(string message)
        {
            if (this.ShouldLog(LogChatterLevels.Warning))
            {
                this.Write("Warning", message);
            }
        }

        /// <summary>
        /// Logs the specified message as an error.
        /// </summary>
        /// <param name="message">The message.</param>
        public override void Error(string message)
        {
            if (this.ShouldLog(LogChatterLevels.Error))
            {
                this.Write("Error", message);
            }
        }

        private void Write(string type, string message)
        {
            message = $"[{type}]: {message}";

            Console.WriteLine(message);
        }
    }
}
