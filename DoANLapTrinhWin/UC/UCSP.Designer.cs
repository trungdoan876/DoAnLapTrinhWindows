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
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblGiaGoc = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.ucHeart1 = new DoANLapTrinhWin.UCHeart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.ForeColor = System.Drawing.Color.Red;
            this.lblGiaBan.Location = new System.Drawing.Point(23, 187);
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
            this.lblTenSP.Location = new System.Drawing.Point(11, 143);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(71, 29);
            this.lblTenSP.TabIndex = 26;
            this.lblTenSP.Text = "tenSP";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(71, 2);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(138, 139);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // lblGiaGoc
            // 
            this.lblGiaGoc.AutoSize = true;
            this.lblGiaGoc.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaGoc.Location = new System.Drawing.Point(160, 191);
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
            this.lblDiaChi.Location = new System.Drawing.Point(24, 231);
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
            this.lblMaSP.Location = new System.Drawing.Point(245, 269);
            this.lblMaSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(44, 22);
            this.lblMaSP.TabIndex = 30;
            this.lblMaSP.Text = "MSP";
            // 
            // ucHeart1
            // 
            this.ucHeart1.Location = new System.Drawing.Point(240, 214);
            this.ucHeart1.Name = "ucHeart1";
            this.ucHeart1.Size = new System.Drawing.Size(48, 52);
            this.ucHeart1.TabIndex = 31;
            this.ucHeart1.Load += new System.EventHandler(this.ucHeart1_Load);
            // 
            // UCSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ucHeart1);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblGiaGoc);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblTenSP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCSP";
            this.Size = new System.Drawing.Size(291, 291);
            this.Load += new System.EventHandler(this.UCSP_Load);
            this.Click += new System.EventHandler(this.UCSP_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTenSP;
        public System.Windows.Forms.Label lblGiaBan;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Label lblGiaGoc;
        public System.Windows.Forms.Label lblDiaChi;
        public System.Windows.Forms.Label lblMaSP;
        private UCHeart ucHeart1;
    }
}
