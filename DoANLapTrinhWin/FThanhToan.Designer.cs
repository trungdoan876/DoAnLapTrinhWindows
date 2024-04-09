namespace DoANLapTrinhWin
{
    partial class FThanhToan
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
            this.components = new System.ComponentModel.Container();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.menuContainer = new System.Windows.Forms.Panel();
            this.btnTS = new DoANLapTrinhWin.ButtonTuyChinh();
            this.btnChonPTTT = new DoANLapTrinhWin.ButtonTuyChinh();
            this.btnCK = new DoANLapTrinhWin.ButtonTuyChinh();
            this.btnTTKNH = new DoANLapTrinhWin.ButtonTuyChinh();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblTGGiaoHang = new System.Windows.Forms.Label();
            this.lblGiaGoc = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTenNN = new System.Windows.Forms.Label();
            this.lblDCGH = new System.Windows.Forms.Label();
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.ucTBDC = new DoANLapTrinhWin.UCTextBox();
            this.ucTBTenNN = new DoANLapTrinhWin.UCTextBox();
            this.menuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 1;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // menuContainer
            // 
            this.menuContainer.Controls.Add(this.btnTS);
            this.menuContainer.Controls.Add(this.btnChonPTTT);
            this.menuContainer.Controls.Add(this.btnCK);
            this.menuContainer.Controls.Add(this.btnTTKNH);
            this.menuContainer.Location = new System.Drawing.Point(941, 36);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(173, 68);
            this.menuContainer.TabIndex = 3;
            // 
            // btnTS
            // 
            this.btnTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTS.FlatAppearance.BorderSize = 0;
            this.btnTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTS.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTS.ForeColor = System.Drawing.Color.White;
            this.btnTS.Location = new System.Drawing.Point(0, 205);
            this.btnTS.Margin = new System.Windows.Forms.Padding(0);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(173, 67);
            this.btnTS.TabIndex = 3;
            this.btnTS.Text = "Chọn Trả Sau";
            this.btnTS.UseVisualStyleBackColor = false;
            this.btnTS.Click += new System.EventHandler(this.btnTS_Click);
            // 
            // btnChonPTTT
            // 
            this.btnChonPTTT.BackColor = System.Drawing.Color.SeaGreen;
            this.btnChonPTTT.FlatAppearance.BorderSize = 0;
            this.btnChonPTTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonPTTT.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonPTTT.ForeColor = System.Drawing.Color.White;
            this.btnChonPTTT.Location = new System.Drawing.Point(0, -2);
            this.btnChonPTTT.Margin = new System.Windows.Forms.Padding(0);
            this.btnChonPTTT.Name = "btnChonPTTT";
            this.btnChonPTTT.Size = new System.Drawing.Size(173, 67);
            this.btnChonPTTT.TabIndex = 0;
            this.btnChonPTTT.Text = "Chọn phương thức thanh toán";
            this.btnChonPTTT.UseVisualStyleBackColor = false;
            this.btnChonPTTT.Click += new System.EventHandler(this.btnChonPTTT_Click);
            // 
            // btnCK
            // 
            this.btnCK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCK.FlatAppearance.BorderSize = 0;
            this.btnCK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCK.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCK.ForeColor = System.Drawing.Color.White;
            this.btnCK.Location = new System.Drawing.Point(0, 138);
            this.btnCK.Margin = new System.Windows.Forms.Padding(0);
            this.btnCK.Name = "btnCK";
            this.btnCK.Size = new System.Drawing.Size(173, 67);
            this.btnCK.TabIndex = 2;
            this.btnCK.Text = "Chuyển khoản";
            this.btnCK.UseVisualStyleBackColor = false;
            this.btnCK.Click += new System.EventHandler(this.btnCK_Click);
            // 
            // btnTTKNH
            // 
            this.btnTTKNH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTTKNH.FlatAppearance.BorderSize = 0;
            this.btnTTKNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTKNH.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTKNH.ForeColor = System.Drawing.Color.White;
            this.btnTTKNH.Location = new System.Drawing.Point(0, 67);
            this.btnTTKNH.Margin = new System.Windows.Forms.Padding(0);
            this.btnTTKNH.Name = "btnTTKNH";
            this.btnTTKNH.Size = new System.Drawing.Size(173, 71);
            this.btnTTKNH.TabIndex = 1;
            this.btnTTKNH.Text = "Thanh toán khi nhận hàng";
            this.btnTTKNH.UseVisualStyleBackColor = false;
            this.btnTTKNH.Click += new System.EventHandler(this.btnTTKNH_Click);
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(327, 21);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(217, 44);
            this.lblTenSP.TabIndex = 4;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // lblTGGiaoHang
            // 
            this.lblTGGiaoHang.AutoSize = true;
            this.lblTGGiaoHang.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTGGiaoHang.Location = new System.Drawing.Point(334, 229);
            this.lblTGGiaoHang.Name = "lblTGGiaoHang";
            this.lblTGGiaoHang.Size = new System.Drawing.Size(196, 27);
            this.lblTGGiaoHang.TabIndex = 7;
            this.lblTGGiaoHang.Text = "Thời gian giao hàng:";
            // 
            // lblGiaGoc
            // 
            this.lblGiaGoc.AutoSize = true;
            this.lblGiaGoc.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaGoc.Location = new System.Drawing.Point(477, 135);
            this.lblGiaGoc.Name = "lblGiaGoc";
            this.lblGiaGoc.Size = new System.Drawing.Size(79, 27);
            this.lblGiaGoc.TabIndex = 8;
            this.lblGiaGoc.Text = "Giá gốc";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.ForeColor = System.Drawing.Color.Red;
            this.lblGiaBan.Location = new System.Drawing.Point(474, 85);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(113, 37);
            this.lblGiaBan.TabIndex = 9;
            this.lblGiaBan.Text = "Giá Bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(334, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giá Bán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giá gốc:";
            // 
            // lblTenNN
            // 
            this.lblTenNN.AutoSize = true;
            this.lblTenNN.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNN.Location = new System.Drawing.Point(335, 282);
            this.lblTenNN.Name = "lblTenNN";
            this.lblTenNN.Size = new System.Drawing.Size(174, 29);
            this.lblTenNN.TabIndex = 13;
            this.lblTenNN.Text = "Tên người nhận:";
            // 
            // lblDCGH
            // 
            this.lblDCGH.AutoSize = true;
            this.lblDCGH.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDCGH.Location = new System.Drawing.Point(335, 351);
            this.lblDCGH.Name = "lblDCGH";
            this.lblDCGH.Size = new System.Drawing.Size(188, 29);
            this.lblDCGH.TabIndex = 15;
            this.lblDCGH.Text = "Địa chỉ giao hàng:";
            // 
            // picHinh
            // 
            this.picHinh.Location = new System.Drawing.Point(42, 57);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(221, 224);
            this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinh.TabIndex = 16;
            this.picHinh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Số lượng:";
            // 
            // btnTru
            // 
            this.btnTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTru.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTru.Location = new System.Drawing.Point(469, 174);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(40, 35);
            this.btnTru.TabIndex = 18;
            this.btnTru.Text = "-";
            this.btnTru.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnCong
            // 
            this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCong.Location = new System.Drawing.Point(576, 174);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(40, 37);
            this.btnCong.TabIndex = 19;
            this.btnCong.Text = "+";
            this.btnCong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(515, 180);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(55, 26);
            this.txtSL.TabIndex = 20;
            this.txtSL.Text = "1";
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ucTBDC
            // 
            this.ucTBDC.BackColor = System.Drawing.SystemColors.Window;
            this.ucTBDC.BanKinhKhung = 0;
            this.ucTBDC.ChumoColor = System.Drawing.Color.DarkGray;
            this.ucTBDC.ChumoText = "";
            this.ucTBDC.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ucTBDC.GachChan = false;
            this.ucTBDC.KichThuocKhung = 2;
            this.ucTBDC.Location = new System.Drawing.Point(548, 351);
            this.ucTBDC.MauKhung = System.Drawing.Color.Gray;
            this.ucTBDC.Multiline = false;
            this.ucTBDC.Name = "ucTBDC";
            this.ucTBDC.Padding = new System.Windows.Forms.Padding(7);
            this.ucTBDC.PasswordChar = false;
            this.ucTBDC.Size = new System.Drawing.Size(390, 38);
            this.ucTBDC.TabIndex = 14;
            this.ucTBDC.Texts = "";
            // 
            // ucTBTenNN
            // 
            this.ucTBTenNN.BackColor = System.Drawing.SystemColors.Window;
            this.ucTBTenNN.BanKinhKhung = 0;
            this.ucTBTenNN.ChumoColor = System.Drawing.Color.DarkGray;
            this.ucTBTenNN.ChumoText = "";
            this.ucTBTenNN.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ucTBTenNN.GachChan = false;
            this.ucTBTenNN.KichThuocKhung = 2;
            this.ucTBTenNN.Location = new System.Drawing.Point(548, 282);
            this.ucTBTenNN.MauKhung = System.Drawing.Color.Gray;
            this.ucTBTenNN.Multiline = false;
            this.ucTBTenNN.Name = "ucTBTenNN";
            this.ucTBTenNN.Padding = new System.Windows.Forms.Padding(7);
            this.ucTBTenNN.PasswordChar = false;
            this.ucTBTenNN.Size = new System.Drawing.Size(390, 38);
            this.ucTBTenNN.TabIndex = 12;
            this.ucTBTenNN.Texts = "";
            // 
            // FThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1123, 454);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picHinh);
            this.Controls.Add(this.lblDCGH);
            this.Controls.Add(this.ucTBDC);
            this.Controls.Add(this.lblTenNN);
            this.Controls.Add(this.ucTBTenNN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblGiaGoc);
            this.Controls.Add(this.lblTGGiaoHang);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.menuContainer);
            this.Name = "FThanhToan";
            this.Text = "FChuyenKhoan";
            this.menuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonTuyChinh btnChonPTTT;
        private ButtonTuyChinh btnTTKNH;
        private ButtonTuyChinh btnCK;
        private ButtonTuyChinh btnTS;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Panel menuContainer;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblTGGiaoHang;
        private System.Windows.Forms.Label lblGiaGoc;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private UCTextBox ucTBTenNN;
        private System.Windows.Forms.Label lblTenNN;
        private System.Windows.Forms.Label lblDCGH;
        private UCTextBox ucTBDC;
        private System.Windows.Forms.PictureBox picHinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.TextBox txtSL;
    }
}