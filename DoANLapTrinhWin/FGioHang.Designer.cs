namespace DoANLapTrinhWin
{
    partial class FGioHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGioHang));
            this.label1 = new System.Windows.Forms.Label();
            this.ucTextBox6 = new DoANLapTrinhWin.UCTextBox();
            this.thanhToanKhiNhanHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyenKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMuaHang = new DoANLapTrinhWin.ButtonTuyChinh();
            this.panelGioHang = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(73, 526);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 45);
            this.label1.TabIndex = 61;
            this.label1.Text = "Tổng số tiền";
            // 
            // ucTextBox6
            // 
            this.ucTextBox6.BackColor = System.Drawing.SystemColors.Window;
            this.ucTextBox6.BanKinhKhung = 15;
            this.ucTextBox6.ChumoColor = System.Drawing.Color.DarkGray;
            this.ucTextBox6.ChumoText = "";
            this.ucTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTextBox6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ucTextBox6.GachChan = false;
            this.ucTextBox6.KichThuocKhung = 1;
            this.ucTextBox6.Location = new System.Drawing.Point(280, 533);
            this.ucTextBox6.MauKhung = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucTextBox6.Multiline = false;
            this.ucTextBox6.Name = "ucTextBox6";
            this.ucTextBox6.Padding = new System.Windows.Forms.Padding(7);
            this.ucTextBox6.PasswordChar = false;
            this.ucTextBox6.Size = new System.Drawing.Size(338, 40);
            this.ucTextBox6.TabIndex = 60;
            this.ucTextBox6.Texts = "";
            // 
            // thanhToanKhiNhanHangToolStripMenuItem
            // 
            this.thanhToanKhiNhanHangToolStripMenuItem.Name = "thanhToanKhiNhanHangToolStripMenuItem";
            this.thanhToanKhiNhanHangToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // chuyenKhoanToolStripMenuItem
            // 
            this.chuyenKhoanToolStripMenuItem.Name = "chuyenKhoanToolStripMenuItem";
            this.chuyenKhoanToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // ghiNoToolStripMenuItem
            // 
            this.ghiNoToolStripMenuItem.Name = "ghiNoToolStripMenuItem";
            this.ghiNoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // btnMuaHang
            // 
            this.btnMuaHang.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMuaHang.FlatAppearance.BorderSize = 0;
            this.btnMuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuaHang.Font = new System.Drawing.Font("Palatino Linotype", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaHang.ForeColor = System.Drawing.Color.White;
            this.btnMuaHang.Image = ((System.Drawing.Image)(resources.GetObject("btnMuaHang.Image")));
            this.btnMuaHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuaHang.Location = new System.Drawing.Point(717, 517);
            this.btnMuaHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnMuaHang.Name = "btnMuaHang";
            this.btnMuaHang.Size = new System.Drawing.Size(219, 69);
            this.btnMuaHang.TabIndex = 64;
            this.btnMuaHang.Text = "Mua hàng";
            this.btnMuaHang.UseVisualStyleBackColor = false;
            this.btnMuaHang.Click += new System.EventHandler(this.btnMuaHang_Click);
            // 
            // panelGioHang
            // 
            this.panelGioHang.AutoScroll = true;
            this.panelGioHang.Location = new System.Drawing.Point(-2, -2);
            this.panelGioHang.Name = "panelGioHang";
            this.panelGioHang.Size = new System.Drawing.Size(1180, 505);
            this.panelGioHang.TabIndex = 65;
            // 
            // FGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.panelGioHang);
            this.Controls.Add(this.btnMuaHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucTextBox6);
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FGioHang";
            this.Text = "FGioHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem thanhToanKhiNhanHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyenKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiNoToolStripMenuItem;
        private UCTextBox ucTextBox6;
        private System.Windows.Forms.Label label1;
        private ButtonTuyChinh btnMuaHang;
        private System.Windows.Forms.Panel panelGioHang;

    }
}