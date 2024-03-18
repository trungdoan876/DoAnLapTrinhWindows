namespace DoANLapTrinhWin
{
    partial class FTatCaSanPham
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
            this.panelTatCaSP = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelTatCaSP
            // 
            this.panelTatCaSP.Location = new System.Drawing.Point(0, -3);
            this.panelTatCaSP.Name = "panelTatCaSP";
            this.panelTatCaSP.Size = new System.Drawing.Size(912, 454);
            this.panelTatCaSP.TabIndex = 0;
            // 
            // FTatCaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.panelTatCaSP);
            this.Name = "FTatCaSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTatCaSanPham";
            this.Load += new System.EventHandler(this.FTatCaSanPham_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTatCaSP;
    }
}