namespace Desktop_Widgets
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.IconCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.info = new System.Windows.Forms.ToolStripMenuItem();
            this.website0 = new System.Windows.Forms.ToolStripMenuItem();
            this.settShow = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.hide = new System.Windows.Forms.Button();
            this.clWid = new System.Windows.Forms.Button();
            this.lockWid = new System.Windows.Forms.Button();
            this.showWid = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.note = new System.Windows.Forms.CheckBox();
            this.hdspace = new System.Windows.Forms.CheckBox();
            this.cpuRam = new System.Windows.Forms.CheckBox();
            this.clock = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ex = new System.Windows.Forms.Button();
            this.IconCMS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.ContextMenuStrip = this.IconCMS;
            this.icon.Icon = ((System.Drawing.Icon)(resources.GetObject("icon.Icon")));
            this.icon.Text = "Desktop Widgets";
            this.icon.Visible = true;
            // 
            // IconCMS
            // 
            this.IconCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info,
            this.website0,
            this.settShow,
            this.exit});
            this.IconCMS.Name = "IconCMS";
            this.IconCMS.Size = new System.Drawing.Size(212, 92);
            // 
            // info
            // 
            this.info.Enabled = false;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(211, 22);
            this.info.Text = "Created by Marco Ceccon";
            this.info.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // website0
            // 
            this.website0.Name = "website0";
            this.website0.Size = new System.Drawing.Size(211, 22);
            this.website0.Text = "Go to my website";
            this.website0.Click += new System.EventHandler(this.Website0_Click);
            // 
            // settShow
            // 
            this.settShow.Name = "settShow";
            this.settShow.Size = new System.Drawing.Size(211, 22);
            this.settShow.Text = "Show menu";
            this.settShow.Click += new System.EventHandler(this.SettShow_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(211, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // hide
            // 
            this.hide.Cursor = System.Windows.Forms.Cursors.Default;
            this.hide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hide.ForeColor = System.Drawing.Color.White;
            this.hide.Location = new System.Drawing.Point(339, 104);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(147, 23);
            this.hide.TabIndex = 0;
            this.hide.Text = "Hide window";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // clWid
            // 
            this.clWid.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.clWid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.clWid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clWid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clWid.ForeColor = System.Drawing.Color.Red;
            this.clWid.Location = new System.Drawing.Point(12, 138);
            this.clWid.Name = "clWid";
            this.clWid.Size = new System.Drawing.Size(147, 23);
            this.clWid.TabIndex = 1;
            this.clWid.Text = "Close all widgets";
            this.clWid.UseVisualStyleBackColor = true;
            this.clWid.Click += new System.EventHandler(this.ClWid_Click);
            // 
            // lockWid
            // 
            this.lockWid.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lockWid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.lockWid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lockWid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lockWid.ForeColor = System.Drawing.Color.White;
            this.lockWid.Location = new System.Drawing.Point(339, 138);
            this.lockWid.Name = "lockWid";
            this.lockWid.Size = new System.Drawing.Size(147, 23);
            this.lockWid.TabIndex = 2;
            this.lockWid.Text = "Lock all widgets";
            this.lockWid.UseVisualStyleBackColor = true;
            this.lockWid.Click += new System.EventHandler(this.LockWid_Click);
            // 
            // showWid
            // 
            this.showWid.Cursor = System.Windows.Forms.Cursors.Default;
            this.showWid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.showWid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.showWid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showWid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showWid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.showWid.Location = new System.Drawing.Point(165, 104);
            this.showWid.Name = "showWid";
            this.showWid.Size = new System.Drawing.Size(168, 57);
            this.showWid.TabIndex = 3;
            this.showWid.Text = "Open selected widgets!";
            this.showWid.UseVisualStyleBackColor = true;
            this.showWid.Click += new System.EventHandler(this.ShowWid_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.note);
            this.groupBox1.Controls.Add(this.hdspace);
            this.groupBox1.Controls.Add(this.cpuRam);
            this.groupBox1.Controls.Add(this.clock);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Location = new System.Drawing.Point(367, 31);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(56, 17);
            this.note.TabIndex = 5;
            this.note.Text = "Notes";
            this.note.UseVisualStyleBackColor = true;
            // 
            // hdspace
            // 
            this.hdspace.AutoSize = true;
            this.hdspace.Location = new System.Drawing.Point(264, 31);
            this.hdspace.Name = "hdspace";
            this.hdspace.Size = new System.Drawing.Size(97, 17);
            this.hdspace.TabIndex = 4;
            this.hdspace.Text = "HD free space";
            this.hdspace.UseVisualStyleBackColor = true;
            // 
            // cpuRam
            // 
            this.cpuRam.AutoSize = true;
            this.cpuRam.Location = new System.Drawing.Point(161, 31);
            this.cpuRam.Name = "cpuRam";
            this.cpuRam.Size = new System.Drawing.Size(97, 17);
            this.cpuRam.TabIndex = 2;
            this.cpuRam.Text = "CPU and RAM";
            this.cpuRam.UseVisualStyleBackColor = true;
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(52, 31);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(103, 17);
            this.clock.TabIndex = 0;
            this.clock.Text = "Clock and date";
            this.clock.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 25);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(10, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(96, 13);
            this.title.TabIndex = 0;
            this.title.Text = "Desktop Widgets";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // timer
            // 
            this.timer.Interval = 75;
            this.timer.Tick += new System.EventHandler(this.Tick);
            // 
            // ex
            // 
            this.ex.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ex.ForeColor = System.Drawing.Color.Red;
            this.ex.Location = new System.Drawing.Point(12, 104);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(147, 23);
            this.ex.TabIndex = 6;
            this.ex.Text = "Exit and close all widgets";
            this.ex.UseVisualStyleBackColor = true;
            this.ex.Click += new System.EventHandler(this.Ex_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(498, 173);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showWid);
            this.Controls.Add(this.lockWid);
            this.Controls.Add(this.clWid);
            this.Controls.Add(this.hide);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop Widgets - Created by Marco Ceccon";
            this.IconCMS.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon icon;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.ContextMenuStrip IconCMS;
        private System.Windows.Forms.ToolStripMenuItem info;
        private System.Windows.Forms.ToolStripMenuItem website0;
        private System.Windows.Forms.ToolStripMenuItem settShow;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.Button clWid;
        private System.Windows.Forms.Button lockWid;
        private System.Windows.Forms.Button showWid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox note;
        private System.Windows.Forms.CheckBox hdspace;
        private System.Windows.Forms.CheckBox cpuRam;
        private System.Windows.Forms.CheckBox clock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button ex;
    }
}