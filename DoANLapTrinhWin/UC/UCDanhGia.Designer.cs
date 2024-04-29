namespace DoANLapTrinhWin
{
    partial class UCDanhGia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDanhGia));
            this.picHinh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblTrangthai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // picHinh
            // 
            this.picHinh.Image = ((System.Drawing.Image)(resources.GetObject("picHinh.Image")));
            this.picHinh.ImageRotate = 0F;
            this.picHinh.Location = new System.Drawing.Point(31, 18);
            this.picHinh.Margin = new System.Windows.Forms.Padding(5);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(133, 112);
            this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinh.TabIndex = 0;
            this.picHinh.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTenSP.Location = new System.Drawing.Point(256, 57);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(93, 38);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "tenSP";
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.AutoSize = true;
            this.lblTrangthai.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthai.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTrangthai.Location = new System.Drawing.Point(609, 57);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(20, 28);
            this.lblTrangthai.TabIndex = 2;
            this.lblTrangthai.Text = "-";
            // 
            // UCDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.lblTrangthai);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.picHinh);
            this.Name = "UCDanhGia";
            this.Size = new System.Drawing.Size(713, 130);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Label lblTrangthai;
        public Guna.UI2.WinForms.Guna2PictureBox picHinh;
        public System.Windows.Forms.Label lblTenSP;
    }
}
