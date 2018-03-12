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
        /// <value>The character encoding in which the output is written.</value>
        public override Encoding Encoding => Encoding.Default;

        /// <summary>
        /// Writes a string to the text string or stream.
        /// </summary>
        /// <param name="value">The string to write.</param>
        public override void Write(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.logger.SendMessage(TestMessageLevel.Informational, value);
            }
        }

        /// <summary>
        /// Writes a string followed by a line terminator to the text string or stream.
        /// </summary>
        /// <param name="value">The string to write. If value is null, only the line terminator is written.</param>
        public override void WriteLine(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.logger.SendMessage(TestMessageLevel.Informational, value);
            }
        }
    }
}