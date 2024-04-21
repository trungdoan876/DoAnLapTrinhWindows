namespace DoANLapTrinhWin
{
    partial class UCSPBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSPBan));
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaSP = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // picHinh
            // 
            this.picHinh.Location = new System.Drawing.Point(78, 17);
            this.picHinh.Margin = new System.Windows.Forms.Padding(2);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(138, 139);
            this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinh.TabIndex = 30;
            this.picHinh.TabStop = false;
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(103, 219);
            this.lblGiaTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(91, 29);
            this.lblGiaTien.TabIndex = 32;
            this.lblGiaTien.Text = "Giá tiền";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTenSP.Location = new System.Drawing.Point(5, 170);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(71, 29);
            this.lblTenSP.TabIndex = 31;
            this.lblTenSP.Text = "tenSP";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMaSP.Location = new System.Drawing.Point(5, 267);
            this.lblMaSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(49, 29);
            this.lblMaSP.TabIndex = 34;
            this.lblMaSP.Text = "SPx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Giá tiền:";
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnXoaSP.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnXoaSP.HoverState.ImageSize = new System.Drawing.Size(37, 37);
            this.btnXoaSP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSP.Image")));
            this.btnXoaSP.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnXoaSP.ImageRotate = 0F;
            this.btnXoaSP.ImageSize = new System.Drawing.Size(37, 37);
            this.btnXoaSP.Location = new System.Drawing.Point(212, 258);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnXoaSP.Size = new System.Drawing.Size(64, 54);
            this.btnXoaSP.TabIndex = 36;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click_1);
            // 
            // UCSPBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.picHinh);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.lblTenSP);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCSPBan";
            this.Size = new System.Drawing.Size(279, 324);
            this.Load += new System.EventHandler(this.UCSPBan_Load);
            this.Click += new System.EventHandler(this.UCSPBan_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox picHinh;
        public System.Windows.Forms.Label lblGiaTien;
        public System.Windows.Forms.Label lblTenSP;
        public System.Windows.Forms.Label lblMaSP;
        public System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnXoaSP;
    }
}
