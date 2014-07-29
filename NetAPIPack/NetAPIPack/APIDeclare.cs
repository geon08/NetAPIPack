using System;
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


        #region SendMessage

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage_Text(IntPtr hWnd, UInt32 Msg, IntPtr wParam, StringBuilder lParam);

        




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

        #region File System Management



        #endregion

        
    }
}
