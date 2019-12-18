namespace Desktop_Widgets
{
    partial class Hour
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tim = new System.Windows.Forms.Timer(this.components);
            this.timeLBL = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tim
            // 
            this.tim.Tick += new System.EventHandler(this.Tick);
            // 
            // timeLBL
            // 
            this.timeLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeLBL.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLBL.ForeColor = System.Drawing.Color.White;
            this.timeLBL.Location = new System.Drawing.Point(12, 9);
            this.timeLBL.Name = "timeLBL";
            this.timeLBL.Size = new System.Drawing.Size(327, 90);
            this.timeLBL.TabIndex = 0;
            this.timeLBL.Text = "time";
            this.timeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timeLBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.DodgerBlue;
            this.date.Location = new System.Drawing.Point(12, 74);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(327, 25);
            this.date.TabIndex = 1;
            this.date.Text = "date";
            this.date.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.date.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
            // 
            // Hour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(351, 108);
            this.Controls.Add(this.date);
            this.Controls.Add(this.timeLBL);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hour";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Time widget";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tim;
        private System.Windows.Forms.Label timeLBL;
        private System.Windows.Forms.Label date;
    }
}

