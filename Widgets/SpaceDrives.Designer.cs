using ProgressBar;

namespace Desktop_Widgets.Widgets
{
    partial class SpaceDrives
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.freeSpace = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.fullSpace = new System.Windows.Forms.Label();
            this.percDrive = new ProgressBar.ProgressBar();
            this.SuspendLayout();
            // 
            // freeSpace
            // 
            this.freeSpace.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeSpace.ForeColor = System.Drawing.Color.White;
            this.freeSpace.Location = new System.Drawing.Point(12, 9);
            this.freeSpace.Name = "freeSpace";
            this.freeSpace.Size = new System.Drawing.Size(103, 19);
            this.freeSpace.TabIndex = 0;
            this.freeSpace.Text = "C:\\ 9999 TB";
            this.freeSpace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.freeSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Tick);
            // 
            // fullSpace
            // 
            this.fullSpace.AutoSize = true;
            this.fullSpace.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullSpace.Location = new System.Drawing.Point(100, 13);
            this.fullSpace.Name = "fullSpace";
            this.fullSpace.Size = new System.Drawing.Size(80, 13);
            this.fullSpace.TabIndex = 2;
            this.fullSpace.Text = "free of 9999 TB";
            this.fullSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // percDrive
            // 
            this.percDrive.Location = new System.Drawing.Point(-2, 33);
            this.percDrive.Maximum = 100;
            this.percDrive.Minimum = 0;
            this.percDrive.Name = "percDrive";
            this.percDrive.ProgressBarColor = System.Drawing.Color.DodgerBlue;
            this.percDrive.Size = new System.Drawing.Size(355, 5);
            this.percDrive.TabIndex = 3;
            this.percDrive.Value = 50;
            this.percDrive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // SpaceDrives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(351, 35);
            this.Controls.Add(this.percDrive);
            this.Controls.Add(this.fullSpace);
            this.Controls.Add(this.freeSpace);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpaceDrives";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Drive usage widget";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label freeSpace;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label fullSpace;
        private ProgressBar.ProgressBar percDrive;
    }
}