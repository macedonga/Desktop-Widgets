namespace Desktop_Widgets.Widgets
{
    partial class CPURAM
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
            this.cpuTIM = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ramPercentage = new System.Windows.Forms.Label();
            this.ramPB = new ProgressBar.ProgressBar();
            this.cpuPB = new ProgressBar.ProgressBar();
            this.SuspendLayout();
            // 
            // cpuTIM
            // 
            this.cpuTIM.Tick += new System.EventHandler(this.CpuTIM_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RAM";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // ramPercentage
            // 
            this.ramPercentage.AutoSize = true;
            this.ramPercentage.BackColor = System.Drawing.Color.Transparent;
            this.ramPercentage.ForeColor = System.Drawing.Color.White;
            this.ramPercentage.Location = new System.Drawing.Point(305, 33);
            this.ramPercentage.Name = "ramPercentage";
            this.ramPercentage.Size = new System.Drawing.Size(32, 13);
            this.ramPercentage.TabIndex = 4;
            this.ramPercentage.Text = "100%";
            this.ramPercentage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // ramPB
            // 
            this.ramPB.Location = new System.Drawing.Point(45, 36);
            this.ramPB.Maximum = 100;
            this.ramPB.Minimum = 0;
            this.ramPB.Name = "ramPB";
            this.ramPB.ProgressBarColor = System.Drawing.Color.DodgerBlue;
            this.ramPB.Size = new System.Drawing.Size(254, 10);
            this.ramPB.TabIndex = 5;
            this.ramPB.Value = 0;
            this.ramPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // cpuPB
            // 
            this.cpuPB.Location = new System.Drawing.Point(45, 12);
            this.cpuPB.Maximum = 100;
            this.cpuPB.Minimum = 0;
            this.cpuPB.Name = "cpuPB";
            this.cpuPB.ProgressBarColor = System.Drawing.Color.DodgerBlue;
            this.cpuPB.Size = new System.Drawing.Size(292, 10);
            this.cpuPB.TabIndex = 6;
            this.cpuPB.Value = 0;
            this.cpuPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // CPURAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(351, 56);
            this.Controls.Add(this.cpuPB);
            this.Controls.Add(this.ramPB);
            this.Controls.Add(this.ramPercentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CPURAM";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CPU and RAM widget";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer cpuTIM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ramPercentage;
        private ProgressBar.ProgressBar ramPB;
        private ProgressBar.ProgressBar cpuPB;
    }
}