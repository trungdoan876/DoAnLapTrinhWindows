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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMuaHang = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.panelGioHang = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(102, 133);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMuaHang);
            this.panel1.Controls.Add(this.lblTongTien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1710, 362);
            this.panel1.TabIndex = 0;
            // 
            // btnMuaHang
            // 
            this.btnMuaHang.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMuaHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuaHang.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMuaHang.Image = ((System.Drawing.Image)(resources.GetObject("btnMuaHang.Image")));
            this.btnMuaHang.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMuaHang.ImageRotate = 0F;
            this.btnMuaHang.Location = new System.Drawing.Point(1317, 96);
            this.btnMuaHang.Name = "btnMuaHang";
            this.btnMuaHang.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMuaHang.Size = new System.Drawing.Size(214, 104);
            this.btnMuaHang.TabIndex = 65;
            this.btnMuaHang.Click += new System.EventHandler(this.btnMuaHang_Click_1);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(358, 128);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(60, 45);
            this.lblTongTien.TabIndex = 66;
            this.lblTongTien.Text = "0đ";
            // 
            // panelGioHang
            // 
            this.panelGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGioHang.Location = new System.Drawing.Point(0, 0);
            this.panelGioHang.Name = "panelGioHang";
            this.panelGioHang.Size = new System.Drawing.Size(1710, 282);
            this.panelGioHang.TabIndex = 1;
            // 
            // FGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 644);
            this.Controls.Add(this.panelGioHang);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FGioHang";
            this.Text = "FGioHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem thanhToanKhiNhanHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyenKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiNoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnMuaHang;
        private System.Windows.Forms.Label lblTongTien;
        public System.Windows.Forms.Panel panelGioHang;
    }
}