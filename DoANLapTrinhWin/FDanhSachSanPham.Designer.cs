namespace DoANLapTrinhWin
{
    partial class FDanhSachSanPham
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
            this.btnThemSP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelTatCaSP
            // 
            this.panelTatCaSP.AutoScroll = true;
            this.panelTatCaSP.Location = new System.Drawing.Point(0, -3);
            this.panelTatCaSP.Name = "panelTatCaSP";
            this.panelTatCaSP.Size = new System.Drawing.Size(1330, 511);
            this.panelTatCaSP.TabIndex = 0;
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemSP.Location = new System.Drawing.Point(456, 514);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(189, 67);
            this.btnThemSP.TabIndex = 5;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // FDanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1330, 593);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.panelTatCaSP);
            this.Name = "FDanhSachSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTatCaSanPham";
            this.Load += new System.EventHandler(this.FTatCaSanPham_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTatCaSP;
        private System.Windows.Forms.Button btnThemSP;
    }
}