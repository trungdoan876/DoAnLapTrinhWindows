namespace DoANLapTrinhWin
{
    partial class UCTheoNB
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.picHinhNB = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbltenNB = new System.Windows.Forms.Label();
            this.panelSP = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhNB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.picHinhNB);
            this.panel1.Controls.Add(this.lbltenNB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1663, 77);
            this.panel1.TabIndex = 0;
            // 
            // picHinhNB
            // 
            this.picHinhNB.ImageRotate = 0F;
            this.picHinhNB.Location = new System.Drawing.Point(32, 7);
            this.picHinhNB.Name = "picHinhNB";
            this.picHinhNB.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picHinhNB.Size = new System.Drawing.Size(64, 64);
            this.picHinhNB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhNB.TabIndex = 1;
            this.picHinhNB.TabStop = false;
            // 
            // lbltenNB
            // 
            this.lbltenNB.AutoSize = true;
            this.lbltenNB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenNB.ForeColor = System.Drawing.Color.DimGray;
            this.lbltenNB.Location = new System.Drawing.Point(130, 22);
            this.lbltenNB.Name = "lbltenNB";
            this.lbltenNB.Size = new System.Drawing.Size(49, 32);
            this.lbltenNB.TabIndex = 0;
            this.lbltenNB.Text = "ten";
            // 
            // panelSP
            // 
            this.panelSP.AutoScroll = true;
            this.panelSP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSP.Location = new System.Drawing.Point(0, 77);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(1663, 440);
            this.panelSP.TabIndex = 4;
            // 
            // UCTheoNB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelSP);
            this.Controls.Add(this.panel1);
            this.Name = "UCTheoNB";
            this.Size = new System.Drawing.Size(1663, 517);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhNB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltenNB;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picHinhNB;
        public System.Windows.Forms.FlowLayoutPanel panelSP;
    }
}
