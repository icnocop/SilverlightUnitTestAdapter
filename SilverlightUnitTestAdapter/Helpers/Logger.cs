// <copyright file="Logger.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Helpers
{
    using System;
    using SilverlightUnitTestAdapter.Plugin;

    /// <summary>
    /// Logger.
    /// </summary>
    /// <seealso cref="SilverlightUnitTestAdapter.Plugin.ILogger" />
    public class Logger : ILogger
    {
        private readonly IVsShell shell;

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        /// <param name="shell">The shell.</param>
        internal Logger(IVsShell shell)
        {
            this.shell = shell;
        }

        /// <summary>
        /// Writes the message to the console output.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Information(string message)
        {
            this.Output(message);
        }

        /// <summary>
        /// Writes the message to the console output.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Debug(string message)
        {
            this.Output(message);
        }

        /// <summary>
        /// Write the message to the console output.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Warning(string message)
        {
            this.Output(message);
        }

        /// <summary>
        /// Writes the exception to the console error.
        /// </summary>
        /// <param name="ex">The exception.</param>
        internal void Error(Exception ex)
        {
            this.Error(ex.ToString());
        }

        private void Output(string message)
        {
            this.shell.Trace(message);
        }

        private void Error(string message)
        {
            this.shell.Trace(message);
        }
    }
}
