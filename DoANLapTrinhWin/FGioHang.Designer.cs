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
            this.thanhToanKhiNhanHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyenKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.panelGioHang = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MuaHang = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 38);
            this.label1.TabIndex = 61;
            this.label1.Text = "Tổng thanh toán:";
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
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(336, 38);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(60, 45);
            this.lblTongTien.TabIndex = 66;
            this.lblTongTien.Text = "0đ";
            // 
            // panelGioHang
            // 
            this.panelGioHang.AutoScroll = true;
            this.panelGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGioHang.Location = new System.Drawing.Point(0, 0);
            this.panelGioHang.Name = "panelGioHang";
            this.panelGioHang.Size = new System.Drawing.Size(1710, 570);
            this.panelGioHang.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MuaHang);
            this.panel1.Controls.Add(this.lblTongTien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 570);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1710, 252);
            this.panel1.TabIndex = 2;
            // 
            // MuaHang
            // 
            this.MuaHang.BackColor = System.Drawing.Color.Transparent;
            this.MuaHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MuaHang.Image = ((System.Drawing.Image)(resources.GetObject("MuaHang.Image")));
            this.MuaHang.Location = new System.Drawing.Point(1067, 38);
            this.MuaHang.Name = "MuaHang";
            this.MuaHang.Size = new System.Drawing.Size(183, 110);
            this.MuaHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MuaHang.TabIndex = 68;
            this.MuaHang.TabStop = false;
            this.MuaHang.Click += new System.EventHandler(this.MuaHang_Click);
            // 
            // FGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 822);
            this.Controls.Add(this.panelGioHang);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FGioHang";
            this.Text = "FGioHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MuaHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem thanhToanKhiNhanHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyenKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiNoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTongTien;
        public System.Windows.Forms.Panel panelGioHang;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MuaHang;
    }
}