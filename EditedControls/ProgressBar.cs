using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class ProgressBar: UserControl
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        int min = 0;
        int max = 100;
        int val = 0;
        Color BarColor = Color.Blue;
        protected override void OnResize(EventArgs e)
        {
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(BarColor);
            float percent = (float)(val - min) / (float)(max - min);
            Rectangle rect = this.ClientRectangle;
            rect.Width = (int)((float)rect.Width * percent);
            g.FillRectangle(brush, rect);
            brush.Dispose();
            g.Dispose();
        }
        public int Minimum
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0)
                {
                    min = 0;
                }
                if (value > max)
                {
                    min = value;
                    min = value;
                }
                if (val < min)
                {
                    val = min;
                }
                this.Invalidate();
            }
        }
        public int Maximum
        {
            get
            {
                return max;
            }
            set
            {
                if (value < min)
                {
                    min = value;
                }
                max = value;
                if (val > max)
                {
                    val = max;
                }
                this.Invalidate();
            }
        }
        public int Value
        {
            get
            {
                return val;
            }
            set
            {
                int oldValue = val;
                if (value < min)
                {
                    val = min;
                }
                else if (value > max)
                {
                    val = max;
                }
                else
                {
                    val = value;
                }
                float percent;
                Rectangle newValueRect = this.ClientRectangle;
                Rectangle oldValueRect = this.ClientRectangle;
                percent = (float)(val - min) / (float)(max - min);
                newValueRect.Width = (int)((float)newValueRect.Width * percent);
                percent = (float)(oldValue - min) / (float)(max - min);
                oldValueRect.Width = (int)((float)oldValueRect.Width * percent);
                Rectangle updateRect = new Rectangle();
                if (newValueRect.Width > oldValueRect.Width)
                {
                    updateRect.X = oldValueRect.Size.Width;
                    updateRect.Width = newValueRect.Width - oldValueRect.Width;
                }
                else
                {
                    updateRect.X = newValueRect.Size.Width;
                    updateRect.Width = oldValueRect.Width - newValueRect.Width;
                }
                updateRect.Height = this.Height;
                this.Invalidate(updateRect);
            }
        }
        public Color ProgressBarColor
        {
            get
            {
                return BarColor;
            }
            set
            {
                BarColor = value;
                this.Invalidate();
            }
        }
    }
}
