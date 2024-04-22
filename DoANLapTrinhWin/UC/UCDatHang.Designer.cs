namespace DoANLapTrinhWin
{
    partial class UCDatHang
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
            this.lblsoluong = new System.Windows.Forms.Label();
            this.lblthanhtien = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.picHinh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoluong.ForeColor = System.Drawing.Color.Black;
            this.lblsoluong.Location = new System.Drawing.Point(635, 80);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(75, 25);
            this.lblsoluong.TabIndex = 97;
            this.lblsoluong.Text = "soluong";
            // 
            // lblthanhtien
            // 
            this.lblthanhtien.AutoSize = true;
            this.lblthanhtien.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthanhtien.ForeColor = System.Drawing.Color.Black;
            this.lblthanhtien.Location = new System.Drawing.Point(828, 80);
            this.lblthanhtien.Name = "lblthanhtien";
            this.lblthanhtien.Size = new System.Drawing.Size(19, 25);
            this.lblthanhtien.TabIndex = 96;
            this.lblthanhtien.Text = "-";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.ForeColor = System.Drawing.Color.Red;
            this.lblGiaTien.Location = new System.Drawing.Point(447, 80);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(67, 25);
            this.lblGiaTien.TabIndex = 95;
            this.lblGiaTien.Text = "giatien";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.Black;
            this.lblTenSP.Location = new System.Drawing.Point(202, 67);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(106, 38);
            this.lblTenSP.TabIndex = 94;
            this.lblTenSP.Text = "Tên SP";
            // 
            // picHinh
            // 
            this.picHinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinh.Location = new System.Drawing.Point(17, 21);
            this.picHinh.Margin = new System.Windows.Forms.Padding(2);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(108, 138);
            this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinh.TabIndex = 93;
            this.picHinh.TabStop = false;
            // 
            // UCDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lblsoluong);
            this.Controls.Add(this.lblthanhtien);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.picHinh);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCDatHang";
            this.Size = new System.Drawing.Size(1186, 176);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblsoluong;
        public System.Windows.Forms.Label lblthanhtien;
        public System.Windows.Forms.Label lblGiaTien;
        public System.Windows.Forms.Label lblTenSP;
        public System.Windows.Forms.PictureBox picHinh;
    }
}
