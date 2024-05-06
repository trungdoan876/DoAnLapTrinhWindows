namespace DoANLapTrinhWin
{
    partial class UCDanhGiaCT
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
            this.lblTenNM = new System.Windows.Forms.Label();
            this.ratingsao = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblnhanxet = new System.Windows.Forms.Label();
            this.panelHinh = new System.Windows.Forms.Panel();
            this.picHinhNM = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.dtpNgayDG = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhNM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenNM
            // 
            this.lblTenNM.AutoEllipsis = true;
            this.lblTenNM.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNM.Location = new System.Drawing.Point(115, 15);
            this.lblTenNM.Name = "lblTenNM";
            this.lblTenNM.Size = new System.Drawing.Size(469, 32);
            this.lblTenNM.TabIndex = 0;
            this.lblTenNM.Text = "label1";
            // 
            // ratingsao
            // 
            this.ratingsao.Location = new System.Drawing.Point(143, 55);
            this.ratingsao.Name = "ratingsao";
            this.ratingsao.RatingColor = System.Drawing.Color.Gold;
            this.ratingsao.Size = new System.Drawing.Size(262, 40);
            this.ratingsao.TabIndex = 1;
            // 
            // lblnhanxet
            // 
            this.lblnhanxet.AutoSize = true;
            this.lblnhanxet.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhanxet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblnhanxet.Location = new System.Drawing.Point(17, 108);
            this.lblnhanxet.Name = "lblnhanxet";
            this.lblnhanxet.Size = new System.Drawing.Size(51, 21);
            this.lblnhanxet.TabIndex = 2;
            this.lblnhanxet.Text = "label1";
            // 
            // panelHinh
            // 
            this.panelHinh.Location = new System.Drawing.Point(21, 173);
            this.panelHinh.Name = "panelHinh";
            this.panelHinh.Size = new System.Drawing.Size(852, 100);
            this.panelHinh.TabIndex = 3;
            // 
            // picHinhNM
            // 
            this.picHinhNM.ImageRotate = 0F;
            this.picHinhNM.Location = new System.Drawing.Point(31, 3);
            this.picHinhNM.Name = "picHinhNM";
            this.picHinhNM.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picHinhNM.Size = new System.Drawing.Size(66, 62);
            this.picHinhNM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhNM.TabIndex = 4;
            this.picHinhNM.TabStop = false;
            // 
            // dtpNgayDG
            // 
            this.dtpNgayDG.BorderRadius = 10;
            this.dtpNgayDG.Checked = true;
            this.dtpNgayDG.Enabled = false;
            this.dtpNgayDG.FillColor = System.Drawing.Color.HotPink;
            this.dtpNgayDG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayDG.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayDG.Location = new System.Drawing.Point(627, 15);
            this.dtpNgayDG.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayDG.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayDG.Name = "dtpNgayDG";
            this.dtpNgayDG.Size = new System.Drawing.Size(256, 39);
            this.dtpNgayDG.TabIndex = 5;
            this.dtpNgayDG.Value = new System.DateTime(2024, 5, 3, 3, 56, 24, 586);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // UCDanhGiaCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.dtpNgayDG);
            this.Controls.Add(this.picHinhNM);
            this.Controls.Add(this.panelHinh);
            this.Controls.Add(this.lblnhanxet);
            this.Controls.Add(this.ratingsao);
            this.Controls.Add(this.lblTenNM);
            this.Name = "UCDanhGiaCT";
            this.Size = new System.Drawing.Size(902, 286);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhNM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenNM;
        private Guna.UI2.WinForms.Guna2RatingStar ratingsao;
        private System.Windows.Forms.Label lblnhanxet;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picHinhNM;
        public System.Windows.Forms.Panel panelHinh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayDG;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
