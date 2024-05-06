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
            this.picHinhNB = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbltenNB = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panelSP = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhNB)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picHinhNB
            // 
            this.picHinhNB.BackColor = System.Drawing.Color.Transparent;
            this.picHinhNB.ImageRotate = 0F;
            this.picHinhNB.Location = new System.Drawing.Point(79, 7);
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
            this.lbltenNB.BackColor = System.Drawing.Color.Transparent;
            this.lbltenNB.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenNB.ForeColor = System.Drawing.Color.DimGray;
            this.lbltenNB.Location = new System.Drawing.Point(201, 14);
            this.lbltenNB.Name = "lbltenNB";
            this.lbltenNB.Size = new System.Drawing.Size(68, 45);
            this.lbltenNB.TabIndex = 0;
            this.lbltenNB.Text = "ten";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.picHinhNB);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbltenNB);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(166)))), ((int)(((byte)(189)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(172)))), ((int)(((byte)(139)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1826, 74);
            this.guna2CustomGradientPanel1.TabIndex = 6;
            // 
            // panelSP
            // 
            this.panelSP.BackColor = System.Drawing.Color.White;
            this.panelSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSP.Location = new System.Drawing.Point(0, 74);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(1826, 446);
            this.panelSP.TabIndex = 7;
            // 
            // UCTheoNB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelSP);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "UCTheoNB";
            this.Size = new System.Drawing.Size(1826, 520);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhNB)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbltenNB;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picHinhNB;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.FlowLayoutPanel panelSP;
    }
}
