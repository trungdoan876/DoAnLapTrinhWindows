namespace DoANLapTrinhWin
{
    partial class UCSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSP));
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.lblGiaGoc = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.picHeart = new System.Windows.Forms.PictureBox();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.ForeColor = System.Drawing.Color.Red;
            this.lblGiaBan.Location = new System.Drawing.Point(12, 200);
            this.lblGiaBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(96, 32);
            this.lblGiaBan.TabIndex = 27;
            this.lblGiaBan.Text = "Giá bán";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTenSP.Location = new System.Drawing.Point(13, 152);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(71, 29);
            this.lblTenSP.TabIndex = 26;
            this.lblTenSP.Text = "tenSP";
            // 
            // picHinh
            // 
            this.picHinh.Location = new System.Drawing.Point(68, 11);
            this.picHinh.Margin = new System.Windows.Forms.Padding(2);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(138, 139);
            this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinh.TabIndex = 26;
            this.picHinh.TabStop = false;
            // 
            // lblGiaGoc
            // 
            this.lblGiaGoc.AutoSize = true;
            this.lblGiaGoc.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaGoc.Location = new System.Drawing.Point(142, 205);
            this.lblGiaGoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaGoc.Name = "lblGiaGoc";
            this.lblGiaGoc.Size = new System.Drawing.Size(79, 27);
            this.lblGiaGoc.TabIndex = 28;
            this.lblGiaGoc.Text = "Giá gốc";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiaChi.Location = new System.Drawing.Point(13, 244);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(76, 27);
            this.lblDiaChi.TabIndex = 29;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaSP.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblMaSP.Location = new System.Drawing.Point(217, 289);
            this.lblMaSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(44, 22);
            this.lblMaSP.TabIndex = 30;
            this.lblMaSP.Text = "MSP";
            // 
            // picHeart
            // 
            this.picHeart.Image = ((System.Drawing.Image)(resources.GetObject("picHeart.Image")));
            this.picHeart.Location = new System.Drawing.Point(218, 261);
            this.picHeart.Margin = new System.Windows.Forms.Padding(2);
            this.picHeart.Name = "picHeart";
            this.picHeart.Size = new System.Drawing.Size(43, 50);
            this.picHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeart.TabIndex = 47;
            this.picHeart.TabStop = false;
            this.picHeart.Click += new System.EventHandler(this.picHeart_Click);
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.Location = new System.Drawing.Point(18, 274);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.RatingColor = System.Drawing.Color.Gold;
            this.guna2RatingStar1.ReadOnly = true;
            this.guna2RatingStar1.Size = new System.Drawing.Size(163, 37);
            this.guna2RatingStar1.TabIndex = 48;
            this.guna2RatingStar1.Value = 4.5F;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // UCSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.guna2RatingStar1);
            this.Controls.Add(this.picHeart);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblGiaGoc);
            this.Controls.Add(this.picHinh);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblTenSP);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "UCSP";
            this.Size = new System.Drawing.Size(277, 327);
            this.Click += new System.EventHandler(this.UCSP_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTenSP;
        public System.Windows.Forms.Label lblGiaBan;
        public System.Windows.Forms.PictureBox picHinh;
        public System.Windows.Forms.Label lblGiaGoc;
        public System.Windows.Forms.Label lblDiaChi;
        public System.Windows.Forms.Label lblMaSP;
        public System.Windows.Forms.PictureBox picHeart;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
