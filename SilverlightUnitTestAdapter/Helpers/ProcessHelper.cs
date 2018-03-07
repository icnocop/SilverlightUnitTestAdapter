// <copyright file="ProcessHelper.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Helpers
{
    using System.Diagnostics;
    using System.IO;

    /// <summary>
    /// Process Helper.
    /// </summary>
    public static class ProcessHelper
    {
        /// <summary>
        /// Gets the name of the directory.
        /// </summary>
        /// <value>The name of the directory.</value>
        public static string DirectoryName => Path.GetDirectoryName(GetParentProcess().MainModule.FileName);

        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        public static string FileName => Path.GetFileName(GetParentProcess().MainModule.FileName);

        /// <summary>
        /// Gets the full path.
        /// </summary>
        /// <value>The full path.</value>
        public static string FullPath => GetParentProcess().MainModule.FileName;

        /// <summary>
        /// Gets the process identifier.
        /// </summary>
        /// <value>The process identifier.</value>
        public static int ProcessId => GetParentProcess().Id;

        /// <summary>
        /// Gets the name of the process.
        /// </summary>
        /// <value>The name of the process.</value>
        public static string ProcessName => GetParentProcess().ProcessName;

        private static Process GetParentProcess(int pid)
        {
            Process process = Process.GetProcessById(pid);

            return process.Parent();
        }

        private static Process GetParentProcess()
        {
            int iCurrentPid = Process.GetCurrentProcess().Id;

            return GetParentProcess(iCurrentPid);
        }
    }
}