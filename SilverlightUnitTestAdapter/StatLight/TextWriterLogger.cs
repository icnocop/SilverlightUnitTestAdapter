// <copyright file="TextWriterLogger.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.StatLight
{
    using System.IO;
    using System.Text;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;

    /// <summary>
    /// Text Writer Logger.
    /// </summary>
    /// <seealso cref="System.IO.TextWriter" />
    public class TextWriterLogger : TextWriter
    {
        private readonly IMessageLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="TextWriterLogger"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public TextWriterLogger(IMessageLogger logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets the character encoding in which the output is written.
        /// </summary>
        /// <value>The encoding.</value>
        public override Encoding Encoding => Encoding.Default;

        /// <summary>
        /// Writes the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public override void Write(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                this.logger.SendMessage(TestMessageLevel.Informational, message);
            }
        }

        /// <summary>
        /// Writes the specified message with a new line.
        /// </summary>
        /// <param name="message">The message.</param>
        public override void WriteLine(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                this.logger.SendMessage(TestMessageLevel.Informational, message);
            }
        }
    }
}