using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace NetAPIPack.Windows
{
    public class Window
    {

        public static bool SetWindowFocus(Handle Hwnd)
        {
            return APIDeclare.SetForegroundWindow(Hwnd.HandleID);
        }

        


    }
}
