using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;
<<<<<<< HEAD
=======
using System.Linq;
>>>>>>> upd

namespace ScreenshotCapturer
{
    public partial class Form1 : Form
    {
        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;
        DateTime dt;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Start();
            dt = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            // Create a graphics object from the bitmap
            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            // Take the screenshot from the upper left corner to the right bottom corner
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            // Save the screenshot to the specified path that the user has chosen
            bmpScreenshot.Save(@"C:\1\" + (DateTime.Now - dt).TotalMilliseconds + ".png", ImageFormat.Png);
            // Save the screenshot to the specified path that the user has chose
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToString());
            sb.Replace(":", "");
            MessageBox.Show(sb.ToString());
            bmpScreenshot.Save(@"C:\1\" + sb.ToString() + ".png", ImageFormat.Png);
        }
    }
}