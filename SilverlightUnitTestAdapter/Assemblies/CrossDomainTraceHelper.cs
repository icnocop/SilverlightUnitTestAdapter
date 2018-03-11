// <copyright file="CrossDomainTraceHelper.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Assemblies
{
    using System;
    using System.Diagnostics;
    using System.IO;

    /// <summary>
    /// Cross Domain Trace Helper.
    /// </summary>
    /// <seealso cref="System.MarshalByRefObject" />
    public class CrossDomainTraceHelper : MarshalByRefObject
    {
        private CrossDomainTraceHelper parentDomain;

        /// <summary>
        /// Starts listening for trace messages on the specified application domain.
        /// </summary>
        /// <param name="domain">The domain.</param>
        /// <param name="consoleWriter">The console writer.</param>
        public static void StartListening(AppDomain domain, TextWriter consoleWriter)
        {
            var listenerType = typeof(CrossDomainTraceHelper);

            // Create a remote instance
            var remoteHelper =
                (CrossDomainTraceHelper)domain.CreateInstanceAndUnwrap(
                    listenerType.Assembly.FullName,
                    listenerType.FullName);

            // Create a local instance
            var localHelper = new CrossDomainTraceHelper();

            // Register the local helper in the remote domain
            remoteHelper.Register(localHelper, consoleWriter);
        }

        /// <summary>
        /// Obtains a lifetime service object to control the lifetime policy for this instance.
        /// </summary>
        /// <returns>An object of type <see cref="T:System.Runtime.Remoting.Lifetime.ILease" /> used to control the lifetime policy for this instance. This is the current lifetime service object for this instance if one exists; otherwise, a new lifetime service object initialized to the value of the <see cref="P:System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime" /> property.</returns>
        public override object InitializeLifetimeService()
        {
            // avoid object disconnection and RemotingException by returning null
            return null;
        }

        private void Register(CrossDomainTraceHelper parentDomain, TextWriter parentConsoleWriter)
        {
            // Store the parent domain to pass messages to later
            this.parentDomain = parentDomain;

            // Create and register the delegate trace listener
            var traceListener = new DelegateTraceListener(this.TraceWrite, this.TraceWriteLine);

            Trace.Listeners.Add(traceListener);
            Console.SetOut(parentConsoleWriter);
        }

        private void TraceWrite(string message)
        {
            this.parentDomain.RemoteTraceWrite(message);
        }

        private void TraceWriteLine(string message)
        {
            this.parentDomain.RemoteTraceWriteLine(message);
        }

        private void RemoteTraceWrite(string message)
        {
            Trace.Write(message);
        }

        private void RemoteTraceWriteLine(string message)
        {
            Trace.WriteLine(message);
        }
    }
}
