namespace DoANLapTrinhWin
{
    partial class FMuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMuaHang));
            this.ucTextBox1 = new DoANLapTrinhWin.UCTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMuaHang = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucTextBox1
            // 
            this.ucTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.ucTextBox1.BanKinhKhung = 15;
            this.ucTextBox1.ChumoColor = System.Drawing.Color.DarkGray;
            this.ucTextBox1.ChumoText = "";
            this.ucTextBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ucTextBox1.GachChan = false;
            this.ucTextBox1.KichThuocKhung = 1;
            this.ucTextBox1.Location = new System.Drawing.Point(10, 10);
            this.ucTextBox1.MauKhung = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucTextBox1.Multiline = false;
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.ucTextBox1.PasswordChar = false;
            this.ucTextBox1.Size = new System.Drawing.Size(492, 40);
            this.ucTextBox1.TabIndex = 21;
            this.ucTextBox1.Texts = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(507, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sách",
            "Áo ",
            "Quần"});
            this.comboBox1.Location = new System.Drawing.Point(622, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 37);
            this.comboBox1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(634, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Phân loại";
            // 
            // panelMuaHang
            // 
            this.panelMuaHang.Location = new System.Drawing.Point(1, 69);
            this.panelMuaHang.Name = "panelMuaHang";
            this.panelMuaHang.Size = new System.Drawing.Size(1040, 531);
            this.panelMuaHang.TabIndex = 27;
            // 
            // FMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 634);
            this.Controls.Add(this.panelMuaHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucTextBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FMuaHang";
            this.Text = "FMuaHang";
            this.Load += new System.EventHandler(this.FMuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCTextBox ucTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMuaHang;
    }
}