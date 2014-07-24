using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetAPIPack;

namespace TestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void SetWindowForeground_Click(object sender, EventArgs e)
        {
            NetAPIPack.Handle hwnd = new NetAPIPack.Handle();
            hwnd = NetAPIPack.Handle.FindWindowByTitle(Param.Text);
            if (hwnd.IsNullHandle)
            {
                MessageBox.Show("Window Title Name " + Param.Text + " dosen't exist.");
                return;
            }
            
            NetAPIPack.Windows.Window.SetWindowFocus(hwnd);

        }
    }
}
