namespace DoANLapTrinhWin
{
    partial class FSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSanPham));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTatCaSP = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnChuaDangBan = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDaDangBan = new Guna.UI2.WinForms.Guna2Button();
            this.panelThanSP = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTatCaSP);
            this.panel2.Location = new System.Drawing.Point(8, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 70);
            this.panel2.TabIndex = 1;
            // 
            // btnTatCaSP
            // 
            this.btnTatCaSP.Animated = true;
            this.btnTatCaSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTatCaSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTatCaSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTatCaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTatCaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTatCaSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTatCaSP.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCaSP.ForeColor = System.Drawing.Color.White;
            this.btnTatCaSP.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnTatCaSP.Image = ((System.Drawing.Image)(resources.GetObject("btnTatCaSP.Image")));
            this.btnTatCaSP.Location = new System.Drawing.Point(0, 0);
            this.btnTatCaSP.Name = "btnTatCaSP";
            this.btnTatCaSP.Size = new System.Drawing.Size(505, 70);
            this.btnTatCaSP.TabIndex = 38;
            this.btnTatCaSP.Text = "Tất cả sản phẩm";
            this.btnTatCaSP.Click += new System.EventHandler(this.btnTatCaSP_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnChuaDangBan);
            this.panel4.Location = new System.Drawing.Point(1030, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(505, 70);
            this.panel4.TabIndex = 3;
            // 
            // btnChuaDangBan
            // 
            this.btnChuaDangBan.Animated = true;
            this.btnChuaDangBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuaDangBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChuaDangBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChuaDangBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChuaDangBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuaDangBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChuaDangBan.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuaDangBan.ForeColor = System.Drawing.Color.White;
            this.btnChuaDangBan.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnChuaDangBan.Image = ((System.Drawing.Image)(resources.GetObject("btnChuaDangBan.Image")));
            this.btnChuaDangBan.Location = new System.Drawing.Point(0, -4);
            this.btnChuaDangBan.Name = "btnChuaDangBan";
            this.btnChuaDangBan.Size = new System.Drawing.Size(505, 74);
            this.btnChuaDangBan.TabIndex = 40;
            this.btnChuaDangBan.Text = "Chưa đăng bán";
            this.btnChuaDangBan.Click += new System.EventHandler(this.btnChuaDangBan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1573, 80);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDaDangBan);
            this.panel3.Location = new System.Drawing.Point(519, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 70);
            this.panel3.TabIndex = 41;
            // 
            // btnDaDangBan
            // 
            this.btnDaDangBan.Animated = true;
            this.btnDaDangBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaDangBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDaDangBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDaDangBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDaDangBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDaDangBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDaDangBan.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaDangBan.ForeColor = System.Drawing.Color.White;
            this.btnDaDangBan.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnDaDangBan.Image = ((System.Drawing.Image)(resources.GetObject("btnDaDangBan.Image")));
            this.btnDaDangBan.Location = new System.Drawing.Point(0, 0);
            this.btnDaDangBan.Name = "btnDaDangBan";
            this.btnDaDangBan.Size = new System.Drawing.Size(505, 70);
            this.btnDaDangBan.TabIndex = 39;
            this.btnDaDangBan.Text = "Đã đăng bán";
            this.btnDaDangBan.Click += new System.EventHandler(this.btnDaDangBan_Click);
            // 
            // panelThanSP
            // 
            this.panelThanSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThanSP.Location = new System.Drawing.Point(0, 80);
            this.panelThanSP.Name = "panelThanSP";
            this.panelThanSP.Size = new System.Drawing.Size(1573, 864);
            this.panelThanSP.TabIndex = 1;
            // 
            // FSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1573, 944);
            this.Controls.Add(this.panelThanSP);
            this.Controls.Add(this.panel1);
            this.Name = "FSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FSanPham";
            this.Load += new System.EventHandler(this.FSanPham_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnChuaDangBan;
        private Guna.UI2.WinForms.Guna2Button btnDaDangBan;
        private Guna.UI2.WinForms.Guna2Button btnTatCaSP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelThanSP;
    }
}