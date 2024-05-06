namespace DoANLapTrinhWin
{
    partial class UCSPDangBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSPDangBan));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.GoDangBan = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDangBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Giá tiền:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblMaSP.Location = new System.Drawing.Point(2, 287);
            this.lblMaSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(44, 27);
            this.lblMaSP.TabIndex = 41;
            this.lblMaSP.Text = "SPx";
            // 
            // picHinh
            // 
            this.picHinh.Location = new System.Drawing.Point(63, 12);
            this.picHinh.Margin = new System.Windows.Forms.Padding(2);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(140, 152);
            this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinh.TabIndex = 37;
            this.picHinh.TabStop = false;
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(103, 217);
            this.lblGiaTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(83, 27);
            this.lblGiaTien.TabIndex = 39;
            this.lblGiaTien.Text = "Giá tiền";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoEllipsis = true;
            this.lblTenSP.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTenSP.Location = new System.Drawing.Point(7, 180);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(257, 27);
            this.lblTenSP.TabIndex = 38;
            this.lblTenSP.Text = "tenSP";
            // 
            // GoDangBan
            // 
            this.GoDangBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoDangBan.Image = ((System.Drawing.Image)(resources.GetObject("GoDangBan.Image")));
            this.GoDangBan.Location = new System.Drawing.Point(192, 263);
            this.GoDangBan.Name = "GoDangBan";
            this.GoDangBan.Size = new System.Drawing.Size(74, 69);
            this.GoDangBan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoDangBan.TabIndex = 46;
            this.GoDangBan.TabStop = false;
            this.GoDangBan.Click += new System.EventHandler(this.GoDangBan_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // UCSPDangBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(201)))));
            this.Controls.Add(this.GoDangBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.picHinh);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.lblTenSP);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCSPDangBan";
            this.Size = new System.Drawing.Size(266, 335);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDangBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblMaSP;
        public System.Windows.Forms.PictureBox picHinh;
        public System.Windows.Forms.Label lblGiaTien;
        public System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.PictureBox GoDangBan;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
