// <copyright file="ProcessExtensions.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Helpers
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Management;

    /// <summary>
    /// Process Extensions.
    /// </summary>
    public static class ProcessExtensions
    {
        /// <summary>
        /// Gets the parent process.
        /// </summary>
        /// <param name="process">The process.</param>
        /// <returns>The parent proocess.</returns>
        public static Process Parent(this Process process)
        {
            if (process == null)
            {
                throw new ArgumentNullException(nameof(process));
            }

            try
            {
                using (var query = new ManagementObjectSearcher(
                    $"SELECT ParentProcessId FROM Win32_Process WHERE ProcessId = {process.Id}"))
                {
                    return query.Get().OfType<ManagementObject>()
                        .Select(p => Process.GetProcessById((int)(uint)p["ParentProcessId"]))
                        .FirstOrDefault();
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
