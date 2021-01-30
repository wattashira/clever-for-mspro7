using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Clever
{
 public partial class Form1 : Form
 {
  protected override CreateParams CreateParams
  {
   get
   {
    CreateParams param = base.CreateParams;
    param.ExStyle |= 0x08000000;
    return param;

   }


  }





  private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
  private const UInt32 SWP_NOSIZE = 0x0001;
  private const UInt32 SWP_NOMOVE = 0x0002;
  private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

  [DllImport("user32.dll")]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

  public Form1()
  {
   InitializeComponent();
   SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

  }

 
  Point lastPoint;


  private void delBTN_Click(object sender, EventArgs e)
  {
  
  }

  private void delBTN_MouseDown(object sender, MouseEventArgs e)
  {
   SendKeys.Send("{DEL}");
  }

  private void button1_MouseDown(object sender, MouseEventArgs e)
  {

  ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files\HotVirtualKeyboard\hvk.exe");



   Process.Start(startInfo);




  }

  private void button2_MouseDown(object sender, MouseEventArgs e)
  {
   SendKeys.Send("^z");
  }

  private void button3_MouseDown(object sender, MouseEventArgs e)
  {
   SendKeys.Send("^y");

  }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {

            lastPoint = new Point(e.X, e.Y);

          
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            SendKeys.Send("^c");
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            SendKeys.Send("^v");
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }
    }
}
