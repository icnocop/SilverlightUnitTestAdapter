// <copyright file="ConsoleWriter.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Assemblies
{
    using System;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Console Writer.
    /// </summary>
    /// <seealso cref="System.IO.TextWriter" />
    [Serializable]
    public class ConsoleWriter : TextWriter
    {
        private readonly Action<char> write;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleWriter"/> class.
        /// </summary>
        /// <param name="write">The writer.</param>
        public ConsoleWriter(Action<char> write)
        {
            this.write = write;
        }

        /// <summary>
        /// Gets the character encoding in which the output is written.
        /// </summary>
        /// <value>The encoding.</value>
        public override Encoding Encoding => Encoding.Default;

        /// <summary>
        /// Writes a character to the text string or stream.
        /// </summary>
        /// <param name="value">The character to write to the text stream.</param>
        public override void Write(char value)
        {
            this.write(value);
        }
    }
}
