using Desktop_Widgets.Widgets;
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

namespace Desktop_Widgets
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private readonly Hour hour = new Hour();
        private readonly SpaceDrives spDr = new SpaceDrives();
        private readonly CPURAM cpu = new CPURAM();
        private readonly Notes notes = new Notes();
        private bool move = true;
        public Main()
        {
            InitializeComponent();
            timer.Start();
        }
        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Website0_Click(object sender, EventArgs e)
        {
            Process.Start(@"https:\\marcoceccon.github.io\");
        }
        private void SettShow_Click(object sender, EventArgs e)
        {
            Show();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Hide_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void Tick(object sender, EventArgs e)
        {
            title.Location = new Point(title.Location.X + 5, title.Location.Y);

            if (title.Location.X > this.Width)
            {
                title.Location = new Point(0 - title.Width, title.Location.Y);
            }
        }
        private void ShowWid_Click(object sender, EventArgs e)
        {
            if (clock.Checked)
                hour.Show();
            else if (!clock.Checked)
                hour.Hide();
            if (hdspace.Checked)
                spDr.Show();
            else if (!hdspace.Checked)
                spDr.Hide();
            if (cpuRam.Checked)
                cpu.Show();
            else if (!cpuRam.Checked)
                cpu.Hide(); 
            if (note.Checked)
                notes.Show();
            else if (!note.Checked)
                notes.Hide();
        }
        private void LockWid_Click(object sender, EventArgs e)
        {
            if (move)
            {
                hour.move = false;
                cpu.move = false;
                notes.move = false;
                spDr.move = false;
                lockWid.Text = "Unlock all widgets";
                move = false;
            }
            else if (!move)
            {
                hour.move = true;
                cpu.move = true;
                notes.move = true;
                spDr.move = true;
                lockWid.Text = "Lock all widgets";
                move = true;
            }
        }
        private void Ex_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ClWid_Click(object sender, EventArgs e)
        {
            cpu.Hide();
            hour.Hide();
            notes.Hide();
            spDr.Hide();
        }
    }
}
