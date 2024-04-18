namespace DoANLapTrinhWin
{
    partial class FDanhSachSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDanhSachSanPham));
            this.panelTatCaSP = new System.Windows.Forms.Panel();
            this.panelThem = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnThemSanPham = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelTatCaSP.SuspendLayout();
            this.panelThem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTatCaSP
            // 
            this.panelTatCaSP.AutoScroll = true;
            this.panelTatCaSP.Controls.Add(this.panelThem);
            this.panelTatCaSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTatCaSP.Location = new System.Drawing.Point(0, 0);
            this.panelTatCaSP.Margin = new System.Windows.Forms.Padding(10);
            this.panelTatCaSP.Name = "panelTatCaSP";
            this.panelTatCaSP.Size = new System.Drawing.Size(1824, 787);
            this.panelTatCaSP.TabIndex = 0;
            // 
            // panelThem
            // 
            this.panelThem.BorderThickness = 1;
            this.panelThem.Controls.Add(this.bunifuCustomLabel1);
            this.panelThem.Controls.Add(this.btnThemSanPham);
            this.panelThem.FillColor = System.Drawing.Color.BlueViolet;
            this.panelThem.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.panelThem.FillColor3 = System.Drawing.Color.Orange;
            this.panelThem.FillColor4 = System.Drawing.Color.Gold;
            this.panelThem.Location = new System.Drawing.Point(0, 0);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(267, 326);
            this.panelThem.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(43, 278);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(168, 32);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Thêm sản phẩm";
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemSanPham.HoverState.ImageSize = new System.Drawing.Size(150, 150);
            this.btnThemSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSanPham.Image")));
            this.btnThemSanPham.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnThemSanPham.ImageRotate = 0F;
            this.btnThemSanPham.ImageSize = new System.Drawing.Size(100, 100);
            this.btnThemSanPham.Location = new System.Drawing.Point(3, 3);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemSanPham.Size = new System.Drawing.Size(261, 317);
            this.btnThemSanPham.TabIndex = 1;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // FDanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1824, 787);
            this.Controls.Add(this.panelTatCaSP);
            this.Name = "FDanhSachSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTatCaSanPham";
            this.Load += new System.EventHandler(this.FTatCaSanPham_Load);
            this.panelTatCaSP.ResumeLayout(false);
            this.panelThem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTatCaSP;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelThem;
        private Guna.UI2.WinForms.Guna2ImageButton btnThemSanPham;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}