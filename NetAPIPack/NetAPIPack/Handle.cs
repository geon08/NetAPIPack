using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace NetAPIPack
{
    public class Handle
    {
        



        public Handle()
        {
        }
        public Handle(IntPtr Handle)
        {
            HandleID = Handle;
        }
        //public Handle(string Title, string ClassName)
        //{
        //    HandleID = APIDeclare.FindWindow(ClassName, Title);
            
        //}
        
        

        public IntPtr HandleID;

        public bool IsNullHandle
        {
            get
            {
                return HandleID.ToInt64() == 0;
            }
        }



        enum FindType
        {
            Title, ClassName
        }




        public static Handle FindWindowByTitle(string Title)
        {
            return new Handle(APIDeclare.FindWindow(null, Title));
        }

        public static Handle FindWindowByClassName(string ClassID)
        {
            return new Handle(APIDeclare.FindWindow(ClassID, null));
        }

        public static Handle FindWindowHandle(string ClassID, string Title)
        {
            return new Handle(APIDeclare.FindWindow(ClassID, Title));
        }

    }
}
