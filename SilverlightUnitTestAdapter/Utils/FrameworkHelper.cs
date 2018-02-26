// <copyright file="FrameworkHelper.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Utils
{
    using Microsoft.Win32;

    internal class FrameworkHelper
    {
        private static string silverlight5AssemblyPath;

        private static FrameworkHelper instance;

        public static FrameworkHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FrameworkHelper();
                }

                return instance;
            }
        }

        internal string Silverlight5AssemblyPath
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

        private FrameworkHelper()
        {
        }

        private static string GetSilverlight5AssembliesPath()
        {
            string str;
            string installRoot = ReadKey("SOFTWARE\\Microsoft\\Microsoft SDKs\\Silverlight\\v5.0\\ReferenceAssemblies", "SLRuntimeInstallPath");
            str = string.IsNullOrWhiteSpace(installRoot) ? string.Empty : installRoot;
            return str;
        }

        private static string ReadKey(string path, string key)
        {
            string str;
            string value64 = string.Empty;
            string value32 = string.Empty;
            RegistryKey localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            localKey = localKey.OpenSubKey(path);
            if (localKey != null)
            {
                value64 = localKey.GetValue(key).ToString();
            }

            RegistryKey localKey32 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
            localKey32 = localKey32.OpenSubKey(path);
            if (localKey32 != null)
            {
                value32 = localKey32.GetValue(key).ToString();
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