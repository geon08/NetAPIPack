using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace NetAPIPack
{
    public class Handle
    {
        // For Windows Mobile, replace user32.dll with coredll.dll
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);



        public Handle()
        {
        }
        public Handle(IntPtr Handle)
        {
            HandleID = Handle;
        }
        public Handle(string Title)
        {
            HandleID = FindWindow(null, Title);
        }
        public Handle(string ClassName)
        {
            HandleID = FindWindow(ClassName, null);
        }
        

        public IntPtr HandleID;



        public static Handle FindWindowByTitle(string Title)
        {
            return new Handle(FindWindow(null, Title));
        }

        public static Handle FindWindowByTitle(string ClassID)
        {
            return new Handle(FindWindow(ClassID, null));
        }

        public static Handle FindWindowHandle(string ClassID, string Title)
        {
            return new Handle(FindWindow(ClassID, Title));
        }
    }
}
