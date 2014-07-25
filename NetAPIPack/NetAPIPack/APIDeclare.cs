﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace NetAPIPack
{
    public class APIDeclare
    {

        #region Handle


        [DllImport("user32.dll", SetLastError = true)] // http://blog.hubeen.kr/220049282448
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)] // http://blog.hubeen.kr/220050374033
        public static extern IntPtr FindWindowEx (IntPtr parentHandle, IntPtr childAfter, string className,  string windowTitle);

        #endregion


        #region Windows

        [DllImport("user32.dll")] // http://blog.hubeen.kr/220070818714
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)] // http://blog.hubeen.kr/220067336267
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder Ipstring, int nMaxCount);

        #endregion

        #region Windows Class & Module

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)] // http://blog.hubeen.kr/220071858298
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        #endregion

        #region Text

        [DllImport("user32.dll", CharSet = CharSet.Auto)] // http://blog.hubeen.kr/220068633546
        public static extern string CharUpper([In,Out] StringBuilder Ipsz);

        [DllImport("user32.dll", CharSet = CharSet.Auto)] // http://blog.hubeen.kr/220068294200
        public static extern string CharLower([In, Out] StringBuilder Ipsz);

        #endregion

        #region System

        [DllImport("kernel32.dll")] // http://blog.hubeen.kr/220054328883
        public static extern uint GetSystemWindowsDirectory([Out] StringBuilder IpBuffer, uint uSize);

        [DllImport("advapi32.dll", SetLastError = true)] // http://blog.hubeen.kr/220066157791
        public static extern bool GetUserName(StringBuilder sb, ref Int32 length);

        #endregion

        #region Mouse&Icon

        [DllImport("user32.dll")] // http://blog.hubeen.kr/220064758268
        public static extern bool SwapMouseButton(bool bswap);

        #endregion

        #region Directory & File & Drive

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)] // http://blog.hubeen.kr/220070298785
        public static extern bool CopyFile(string lpExistingFileName, string lpNewFileName, bool bFailIfExists);

        [DllImport("kernel32.dll")] // http://blog.hubeen.kr/220048162592
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectory(string lpPathName,IntPtr lpSecurityAttributes);

        [DllImport("kernel32.dll", SetLastError = true)] // http://blog.hubeen.kr/220054361323
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFile(string lpFileName);

        #endregion

        
    }
}
