// <copyright file="VsShell.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Helpers
{
    using System;
    using System.Collections;
    using System.Runtime.InteropServices;
    using System.Runtime.InteropServices.ComTypes;
    using EnvDTE;
    using EnvDTE80;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
    using IServiceProvider = Microsoft.VisualStudio.OLE.Interop.IServiceProvider;

    /// <summary>
    /// Visual Studio Shell.
    /// </summary>
    internal class VsShell : IVsShell
    {
        private readonly IMessageLogger logger;

        private DTE2 shell;

        private OutputWindowPane outputWindowPanel;

        /// <summary>
        /// Initializes a new instance of the <see cref="VsShell"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public VsShell(IMessageLogger logger = null)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <param name="serviceProviderObject">The service provider object.</param>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>The service.</returns>
        public static object GetService(object serviceProviderObject, Guid guid)
        {
            return RetryHelper.Retry(() =>
            {
                IntPtr serviceIntPtr;
                object service = null;
                Guid sidGuid = guid;
                Guid iidGuid = sidGuid;
                var serviceProvider = (IServiceProvider)serviceProviderObject;
                Guid guid1 = sidGuid;
                Guid guid2 = iidGuid;
                var hr = serviceProvider.QueryService(ref guid1, ref guid2, out serviceIntPtr);
                if (hr != 0)
                {
                    Marshal.ThrowExceptionForHR(hr);
                }
                else if (!serviceIntPtr.Equals(IntPtr.Zero))
                {
                    service = Marshal.GetObjectForIUnknown(serviceIntPtr);
                    Marshal.Release(serviceIntPtr);
                }

                return service;
            });
        }

        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="type">The type.</param>
        /// <returns>The service.</returns>
        public static object GetService(object serviceProvider, Type type)
        {
            return GetService(serviceProvider, type.GUID);
        }

        /// <summary>
        /// Initializes the fields in this instance.
        /// </summary>
        /// <param name="clearOutput">if set to <c>true</c> [clear output].</param>
        public void Initialize(bool clearOutput = false)
        {
            RetryHelper.Retry(() =>
            {
                if (this.shell == null)
                {
                    this.shell = GetCurrentShell();
                }

                if (this.shell != null)
                {
                    Windows windows = this.shell.Windows;
                    if (windows != null && windows.Count > 0)
                    {
                        Window window = windows.Item("{34E76E81-EE4A-11D0-AE2E-00A0C90FFFC3}");
                        OutputWindow outputWindow = (OutputWindow)window.Object;
                        this.outputWindowPanel = GetWindowPane(outputWindow, "Silverlight Unit Test Adapter");
                    }

                    if (clearOutput)
                    {
                        this.outputWindowPanel?.Clear();
                    }
                }
            });
        }

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Trace(string message)
        {
            RetryHelper.Retry(() =>
            {
                if (string.IsNullOrEmpty(message))
                {
                    return;
                }

                if (this.outputWindowPanel != null)
                {
                    try
                    {
                        if (message.EndsWith("\r"))
                        {
                            this.outputWindowPanel.OutputString(message);
                        }
                        else
                        {
                            this.outputWindowPanel.OutputString(string.Concat(message, "\r"));
                        }
                    }
                    catch (Exception exception)
                    {
                        this.logger?.SendMessage(0, string.Concat("Error occurred while trying to write some output: ", exception.ToString()));

                        this.Initialize();
                    }
                }
                else
                {
                    this.logger?.SendMessage(0, message);
                }
            });
        }

        /// <summary>
        /// Gets the output window pane.
        /// </summary>
        /// <param name="outputWindow">The output window.</param>
        /// <param name="item">The item.</param>
        /// <returns>The output window pane.</returns>
        internal static OutputWindowPane GetWindowPane(OutputWindow outputWindow, string item)
        {
            return RetryHelper.Retry(() =>
            {
                IEnumerator enumerator = outputWindow.OutputWindowPanes.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    OutputWindowPane panel = (OutputWindowPane)enumerator.Current;
                    if (panel != null && panel.Name == item)
                    {
                        return panel;
                    }
                }

                return outputWindow.OutputWindowPanes.Add(item);
            });
        }

        /// <summary>
        /// Gets the current shell.
        /// </summary>
        /// <returns>The debugger shell.</returns>
        internal static DTE2 GetCurrentShell()
        {
            return RetryHelper.Retry(() =>
            {
                int processId = ProcessHelper.ProcessId;
                string rotEntry = $"!VisualStudio.DTE.14.0:{processId}";

                IRunningObjectTable rot;
                int hResult = NativeMethods.GetRunningObjectTable(0, out rot);
                if (hResult == NativeMethods.S_OK && rot != null)
                {
                    IEnumMoniker enumMoniker;
                    rot.EnumRunning(out enumMoniker);
                    if (enumMoniker != null)
                    {
                        enumMoniker.Reset();
                        IntPtr fetched = IntPtr.Zero;
                        IMoniker[] moniker = new IMoniker[1];
                        while (enumMoniker.Next(1, moniker, fetched) == 0)
                        {
                            IBindCtx bindCtx;
                            hResult = NativeMethods.CreateBindCtx(0, out bindCtx);
                            if (hResult == NativeMethods.S_OK && bindCtx != null)
                            {
                                string displayName;
                                moniker[0].GetDisplayName(bindCtx, null, out displayName);

                                if (displayName == rotEntry)
                                {
                                    object comObject;
                                    hResult = rot.GetObject(moniker[0], out comObject);
                                    if (hResult == NativeMethods.S_OK && comObject != null)
                                    {
                                        return (DTE2)comObject;
                                    }
                                }
                            }
                        }
                    }
                }

                return null;
            });
        }
    }
}