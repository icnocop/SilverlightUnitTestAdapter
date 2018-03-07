// <copyright file="FrameworkHelper.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Helpers
{
    using Microsoft.Win32;

    /// <summary>
    /// Framewor kHelper.
    /// </summary>
    internal static class FrameworkHelper
    {
        private static string silverlight5AssemblyPath;

        /// <summary>
        /// Gets the Silverlight 5 assembly path.
        /// </summary>
        /// <value>The Silverlight 5 assembly path.</value>
        internal static string Silverlight5AssemblyPath
        {
            get
            {
                if (string.IsNullOrWhiteSpace(silverlight5AssemblyPath))
                {
                    silverlight5AssemblyPath = GetSilverlight5AssembliesPath();
                }

                return silverlight5AssemblyPath;
            }
        }

        private static string GetSilverlight5AssembliesPath()
        {
            string installRoot = ReadKey("SOFTWARE\\Microsoft\\Microsoft SDKs\\Silverlight\\v5.0\\ReferenceAssemblies", "SLRuntimeInstallPath");
            return string.IsNullOrWhiteSpace(installRoot) ? string.Empty : installRoot;
        }

        private static string ReadKey(string path, string key)
        {
            string str;
            string value64 = string.Empty;
            string value32 = string.Empty;
            using (RegistryKey localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey subKey = localKey.OpenSubKey(path))
                {
                    if (subKey != null)
                    {
                        value64 = subKey.GetValue(key).ToString();
                    }
                }
            }

            using (RegistryKey localKey32 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
            {
                using (RegistryKey subKey = localKey32.OpenSubKey(path))
                {
                    if (subKey != null)
                    {
                        value32 = subKey.GetValue(key).ToString();
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(value64))
            {
                str = string.IsNullOrWhiteSpace(value32) ? string.Empty : value32;
            }
            else
            {
                str = value64;
            }

            return str;
        }
    }
}