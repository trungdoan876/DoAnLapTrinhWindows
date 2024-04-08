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
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaSP = new DoANLapTrinhWin.ButtonTuyChinh();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // picHinh
            // 
            this.picHinh.Location = new System.Drawing.Point(53, 19);
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
            this.lblGiaTien.Location = new System.Drawing.Point(68, 205);
            this.lblGiaTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(64, 20);
            this.lblGiaTien.TabIndex = 32;
            this.lblGiaTien.Text = "Giá tiền";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTenSP.Location = new System.Drawing.Point(32, 170);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(53, 20);
            this.lblTenSP.TabIndex = 31;
            this.lblTenSP.Text = "tenSP";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(109, 256);
            this.lblMaSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(37, 20);
            this.lblMaSP.TabIndex = 34;
            this.lblMaSP.Text = "SPx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Giá tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.SeaGreen;
            this.btnXoaSP.FlatAppearance.BorderSize = 0;
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSP.Image")));
            this.btnXoaSP.Location = new System.Drawing.Point(204, 247);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(40, 39);
            this.btnXoaSP.TabIndex = 33;
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // UCSPBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.picHinh);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.lblTenSP);
            this.Name = "UCSPBan";
            this.Size = new System.Drawing.Size(247, 289);
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
        private ButtonTuyChinh btnXoaSP;
        public System.Windows.Forms.Label lblMaSP;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}
