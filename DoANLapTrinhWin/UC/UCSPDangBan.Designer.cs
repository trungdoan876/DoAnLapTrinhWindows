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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.btnGoSp = new DoANLapTrinhWin.ButtonTuyChinh();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Giá tiền:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(137, 262);
            this.lblMaSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(37, 20);
            this.lblMaSP.TabIndex = 41;
            this.lblMaSP.Text = "SPx";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(56, 16);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(140, 152);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Location = new System.Drawing.Point(96, 224);
            this.lblGiaTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(64, 20);
            this.lblGiaTien.TabIndex = 39;
            this.lblGiaTien.Text = "Giá tiền";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTenSP.Location = new System.Drawing.Point(39, 188);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(53, 20);
            this.lblTenSP.TabIndex = 38;
            this.lblTenSP.Text = "tenSP";
            // 
            // btnGoSp
            // 
            this.btnGoSp.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGoSp.FlatAppearance.BorderSize = 0;
            this.btnGoSp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoSp.ForeColor = System.Drawing.Color.White;
            this.btnGoSp.Location = new System.Drawing.Point(66, 285);
            this.btnGoSp.Name = "btnGoSp";
            this.btnGoSp.Size = new System.Drawing.Size(140, 40);
            this.btnGoSp.TabIndex = 45;
            this.btnGoSp.Text = "Gỡ sản phẩm";
            this.btnGoSp.UseVisualStyleBackColor = false;
            this.btnGoSp.Click += new System.EventHandler(this.btnGoSp_Click);
            // 
            // UCSPDangBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnGoSp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.lblTenSP);
            this.Name = "UCSPDangBan";
            this.Size = new System.Drawing.Size(261, 333);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblMaSP;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Label lblGiaTien;
        public System.Windows.Forms.Label lblTenSP;
        private ButtonTuyChinh btnGoSp;
    }
}
