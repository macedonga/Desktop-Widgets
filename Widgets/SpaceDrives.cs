using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Widgets.Widgets
{
    public partial class SpaceDrives : Form
    {
        readonly DriveInfo dInfo = new DriveInfo("C");
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public bool move = true;
        public SpaceDrives()
        {
            InitializeComponent();
            timer.Start();
        }
        private string ConvertSize(double size)
        {
            //https://social.msdn.microsoft.com/Forums/sqlserver/en-US/68ecd276-ef2f-4f49-8352-2f9c23af6a74/convert-from-bytes-to-gb?forum=winforms
            string[] units = new string[] { "B", "KB", "MB", "GB", "TB", "PB" };
            double mod = 1024.0;
            int i = 0;
            while (size >= mod)
            {
                size /= mod;
                i++;
            }
            return Math.Round(size) + units[i];
        }
        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && move)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Tick(object sender, EventArgs e)
        {
            percDrive.Value = Convert.ToInt32(100 * (double)dInfo.TotalFreeSpace / dInfo.TotalSize);
            freeSpace.Text = @"C:\ " + ConvertSize(Convert.ToDouble(dInfo.AvailableFreeSpace));
            fullSpace.Text = "free of " + ConvertSize(Convert.ToDouble(dInfo.TotalSize));
        }
    }
}