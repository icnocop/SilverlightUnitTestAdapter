// <copyright file="ProcessHelper.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Utils
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.InteropServices;

    public class ProcessHelper
    {
        //inner enum used only internally
        [Flags]
        private enum SnapshotFlags : uint
        {
            HeapList = 0x00000001,
            Process = 0x00000002,
            Thread = 0x00000004,
            Module = 0x00000008,
            Module32 = 0x00000010,
            Inherit = 0x80000000,
            All = 0x0000001F,
            NoHeaps = 0x40000000
        }

        public string DirectoryName
        {
            get
            {
                return Path.GetDirectoryName(this.GetParentProcess().MainModule.FileName);
            }
        }

        public string FileName
        {
            get
            {
                return Path.GetFileName(this.GetParentProcess().MainModule.FileName);
            }
        }

        public string FullPath
        {
            get
            {
                return this.GetParentProcess().MainModule.FileName;
            }
        }

        public int ProcessId
        {
            get
            {
                return this.GetParentProcess().Id;
            }
        }

        public string ProcessName
        {
            get
            {
                return this.GetParentProcess().ProcessName;
            }
        }

        private Process GetParentProcess()
        {
            int iCurrentPid = Process.GetCurrentProcess().Id;

            return this.GetParentProcess(iCurrentPid);
        }

        private Process GetParentProcess(int pid)
        {
            Process parentProc = null;
            IntPtr handleToSnapshot = IntPtr.Zero;
            try
            {
                PROCESSENTRY32 procEntry = new PROCESSENTRY32();
                procEntry.dwSize = (UInt32)Marshal.SizeOf(typeof(PROCESSENTRY32));
                handleToSnapshot = CreateToolhelp32Snapshot((uint)SnapshotFlags.Process, 0);
                if (Process32First(handleToSnapshot, ref procEntry))
                {
                    do
                    {
                        if (pid == procEntry.th32ProcessID)
                        {
                            parentProc = Process.GetProcessById((int)procEntry.th32ParentProcessID);
                            break;
                        }
                    } while (Process32Next(handleToSnapshot, ref procEntry));
                }
                else
                {
                    throw new ApplicationException($"Failed with win32 error code {Marshal.GetLastWin32Error()}");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Can't get the process.", ex);
            }
            finally
            {
                // Must clean up the snapshot object!
                CloseHandle(handleToSnapshot);
            }

            return parentProc;
        }


        //inner struct used only internally
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private struct PROCESSENTRY32
        {
            const int MAX_PATH = 260;
            internal UInt32 dwSize;
            internal readonly UInt32 cntUsage;
            internal readonly UInt32 th32ProcessID;
            internal readonly IntPtr th32DefaultHeapID;
            internal readonly UInt32 th32ModuleID;
            internal readonly UInt32 cntThreads;
            internal readonly UInt32 th32ParentProcessID;
            internal readonly Int32 pcPriClassBase;
            internal readonly UInt32 dwFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            internal readonly string szExeFile;
        }

        [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Auto)]
        static extern IntPtr CreateToolhelp32Snapshot([In]UInt32 dwFlags, [In]UInt32 th32ProcessID);

        [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool Process32First([In]IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

        [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool Process32Next([In]IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

        [DllImport("kernel32", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle([In] IntPtr hObject);
    }
}