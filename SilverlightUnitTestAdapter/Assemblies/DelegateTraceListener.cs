// <copyright file="DelegateTraceListener.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Assemblies
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Delegate Trace Listener.
    /// </summary>
    /// <seealso cref="System.Diagnostics.TraceListener" />
    internal class DelegateTraceListener : TraceListener
    {
        private readonly Action<string> write;
        private readonly Action<string> writeLine;

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateTraceListener"/> class.
        /// </summary>
        /// <param name="write">The write.</param>
        public DelegateTraceListener(Action<string> write)
            : this(write, write)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateTraceListener"/> class.
        /// </summary>
        /// <param name="write">The write.</param>
        /// <param name="writeLine">The write line.</param>
        public DelegateTraceListener(Action<string> write, Action<string> writeLine)
        {
            this.write = write;
            this.writeLine = writeLine;
        }

        /// <summary>
        /// When overridden in a derived class, writes the specified message to the listener you create in the derived class.
        /// </summary>
        /// <param name="message">A message to write.</param>
        public override void Write(string message)
        {
            this.write(message);
        }

        /// <summary>
        /// When overridden in a derived class, writes a message to the listener you create in the derived class, followed by a line terminator.
        /// </summary>
        /// <param name="message">A message to write.</param>
        public override void WriteLine(string message)
        {
            this.writeLine(message);
        }
    }
}
