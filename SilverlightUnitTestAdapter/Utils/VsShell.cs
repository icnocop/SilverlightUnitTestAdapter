// <copyright file="VsShell.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Utils
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.InteropServices.ComTypes;
    using EnvDTE;
    using EnvDTE80;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
    using IServiceProvider = Microsoft.VisualStudio.OLE.Interop.IServiceProvider;

    internal class VsShell
    {
        private const string silverlightProjectTypeGuid = "{A1591282-1198-4647-A2B1-27E5FF5F6F3B}";

        private DTE2 shell;

        private readonly IMessageLogger logger;

        private readonly ProcessHelper processHelper;

        public VsShell(IMessageLogger logger = null)
        {
            this.logger = logger;
            this.processHelper = new ProcessHelper();
        }

        public OutputWindowPane OutputWindowPanel { get; set; }

        [DllImport("ole32.dll", CharSet=CharSet.None, ExactSpelling=false)]
        private static extern void CreateBindCtx(int reserved, out IBindCtx ppbc);

        internal DTE2 GetCurrentShell()
        {
            IRunningObjectTable rot;
            IEnumMoniker enumMoniker;
            IBindCtx bindCtx;
            string displayName;
            object comObject;
            DTE2 dTE2;

            int processId = this.processHelper.ProcessId;
            string rotEntry = $"!VisualStudio.DTE.14.0:{processId}";
            GetRunningObjectTable(0, out rot);
            if (rot != null)
            {
                rot.EnumRunning(out enumMoniker);
                if (enumMoniker != null)
                {
                    enumMoniker.Reset();
                    IntPtr fetched = IntPtr.Zero;
                    IMoniker[] moniker = new IMoniker[1];
                    while (enumMoniker.Next(1, moniker, fetched) == 0)
                    {
                        CreateBindCtx(0, out bindCtx);
                        moniker[0].GetDisplayName(bindCtx, null, out displayName);

                        if (displayName == rotEntry)
                        {
                            rot.GetObject(moniker[0], out comObject);
                            dTE2 = (DTE2)comObject;
                            return dTE2;
                        }
                    }
                }
            }

            dTE2 = null;
            return dTE2;
        }

        [DllImport("ole32.dll", CharSet=CharSet.None, ExactSpelling=false)]
        private static extern void GetRunningObjectTable(int reserved, out IRunningObjectTable prot);

        public object GetService(object serviceProvider, Type type)
        {
            return this.GetService(serviceProvider, type.GUID);
        }

        public object GetService(object serviceProviderObject, Guid guid)
        {
            IntPtr serviceIntPtr;
            object service = null;
            IServiceProvider serviceProvider = null;
            int hr = 0;
            Guid SIDGuid = guid;
            Guid IIDGuid = SIDGuid;
            serviceProvider = (IServiceProvider)serviceProviderObject;
            Guid guid1 = SIDGuid;
            Guid guid2 = IIDGuid;
            hr = serviceProvider.QueryService(ref guid1, ref guid2, out serviceIntPtr);
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
        }

        internal OutputWindowPane GetWindowPane(OutputWindow outputWindow, string item)
        {
            OutputWindowPane outputWindowPane;
            foreach (OutputWindowPane panel in outputWindow.OutputWindowPanes)
            {
                if (panel.Name == item)
                {
                    outputWindowPane = panel;
                    return outputWindowPane;
                }
            }

            outputWindowPane = outputWindow.OutputWindowPanes.Add(item);
            return outputWindowPane;
        }

        public void Initialize()
        {
            if (this.shell == null)
            {
                this.shell = this.GetCurrentShell();
            }

            if (this.shell != null)
            {
                Windows windows = this.shell.Windows;
                if (windows == null ? false : windows.Count > 0)
                {
                    Window window = windows.Item("{34E76E81-EE4A-11D0-AE2E-00A0C90FFFC3}");
                    window.Visible = true;
                    OutputWindow outputWindow = (OutputWindow)window.Object;
                    this.OutputWindowPanel = this.GetWindowPane(outputWindow, "Silverlight Unit Test Adapter");
                }
            }
        }

        public void Trace(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }

            if (this.OutputWindowPanel != null)
            {
                if (!string.IsNullOrEmpty(message))
                {
                    try
                    {
                        int retryCount = 0;
                        int maxRetryCount = 10;

                        while (retryCount <= maxRetryCount)
                        {
                            try
                            {
                                if (message.EndsWith("\r"))
                                {
                                    this.OutputWindowPanel.OutputString(message);
                                }
                                else
                                {
                                    this.OutputWindowPanel.OutputString(string.Concat(message, "\r"));
                                }

                                break;
                            }
                            catch (Exception)
                            {
                                // ex. Exception: The message filter indicated that the application is busy.
                                if (retryCount >= maxRetryCount)
                                {
                                    throw;
                                }

                                System.Threading.Thread.Sleep(1000);
                            }

                            retryCount++;
                        }
                    }
                    catch (Exception exception)
                    {
                        if (this.logger != null)
                        {
                            this.logger.SendMessage(0, string.Concat("Error occured while trying to write some output: ", exception.ToString()));
                        }

                        this.Initialize();
                    }
                }
            }
            else if (this.logger != null)
            {
                this.logger.SendMessage(0, message);
            }
        }
    }
}