namespace DoANLapTrinhWin
{
    partial class UCDonHangNB
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaDH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(44, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoEllipsis = true;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(24)))), ((int)(((byte)(112)))));
            this.lblTenSP.Location = new System.Drawing.Point(212, 97);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(858, 34);
            this.lblTenSP.TabIndex = 109;
            this.lblTenSP.Text = "tensp";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTrangThai.Location = new System.Drawing.Point(1455, 97);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(86, 25);
            this.lblTrangThai.TabIndex = 108;
            this.lblTrangThai.Text = "trangthai";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(24)))), ((int)(((byte)(112)))));
            this.lblTongTien.Location = new System.Drawing.Point(1132, 97);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(104, 25);
            this.lblTongTien.TabIndex = 107;
            this.lblTongTien.Text = "tongtienDH";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 304;
            this.label1.Text = "Mã đơn hàng:";
            // 
            // lblMaDH
            // 
            this.lblMaDH.AutoSize = true;
            this.lblMaDH.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaDH.Location = new System.Drawing.Point(158, 12);
            this.lblMaDH.Name = "lblMaDH";
            this.lblMaDH.Size = new System.Drawing.Size(66, 27);
            this.lblMaDH.TabIndex = 303;
            this.lblMaDH.Text = "Madh";
            // 
            // UCDonHangNB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(225)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaDH);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblTongTien);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UCDonHangNB";
            this.Size = new System.Drawing.Size(1666, 203);
            this.Click += new System.EventHandler(this.UCDonHangNB_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblTenSP;
        public System.Windows.Forms.Label lblTrangThai;
        public System.Windows.Forms.Label lblTongTien;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaDH;
    }
}
