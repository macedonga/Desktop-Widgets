using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Widgets.Widgets
{
    public partial class CPURAM : Form
    {
        private static readonly PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private static readonly PerformanceCounter ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public bool move = true;
        public CPURAM()
        {
            InitializeComponent();
            cpuTIM.Start();
        }
        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && move)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CpuTIM_Tick(object sender, EventArgs e)
        {
            float fcpu = cpuCounter.NextValue();
            cpuPB.Value = Convert.ToInt32(fcpu) / 2;
            float fram = ramCounter.NextValue();
            string tmpRam = fram.ToString();
            tmpRam = tmpRam.Remove(tmpRam.IndexOf(','));
            ramPercentage.Text = tmpRam + "%";
            ramPB.Value = Convert.ToInt32(fram);
        }
    }
}
