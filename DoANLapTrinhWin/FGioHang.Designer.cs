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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGioHang));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ucTextBox6 = new DoANLapTrinhWin.UCTextBox();
            this.dropdownMenu1 = new DoANLapTrinhWin.DropdownMenu(this.components);
            this.thanhToanKhiNhanHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyenKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTuyChinh1 = new DoANLapTrinhWin.ButtonTuyChinh();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dropdownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1411, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(88, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 58);
            this.label1.TabIndex = 61;
            this.label1.Text = "Tổng số tiền";
            // 
            // ucTextBox6
            // 
            this.ucTextBox6.BackColor = System.Drawing.SystemColors.Window;
            this.ucTextBox6.BanKinhKhung = 15;
            this.ucTextBox6.ChumoColor = System.Drawing.Color.DarkGray;
            this.ucTextBox6.ChumoText = "";
            this.ucTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTextBox6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ucTextBox6.GachChan = false;
            this.ucTextBox6.KichThuocKhung = 1;
            this.ucTextBox6.Location = new System.Drawing.Point(364, 561);
            this.ucTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.ucTextBox6.MauKhung = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucTextBox6.Multiline = false;
            this.ucTextBox6.Name = "ucTextBox6";
            this.ucTextBox6.Padding = new System.Windows.Forms.Padding(9);
            this.ucTextBox6.PasswordChar = false;
            this.ucTextBox6.Size = new System.Drawing.Size(450, 50);
            this.ucTextBox6.TabIndex = 60;
            this.ucTextBox6.Texts = "";
            // 
            // dropdownMenu1
            // 
            this.dropdownMenu1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.dropdownMenu1.IsMainMenu = false;
            this.dropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToanKhiNhanHangToolStripMenuItem,
            this.chuyenKhoanToolStripMenuItem,
            this.ghiNoToolStripMenuItem});
            this.dropdownMenu1.MenuItemHeight = 25;
            this.dropdownMenu1.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.dropdownMenu1.Name = "dropdownMenu1";
            this.dropdownMenu1.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.dropdownMenu1.Size = new System.Drawing.Size(372, 118);
            this.dropdownMenu1.Opening += new System.ComponentModel.CancelEventHandler(this.dropdownMenu1_Opening);
            // 
            // thanhToanKhiNhanHangToolStripMenuItem
            // 
            this.thanhToanKhiNhanHangToolStripMenuItem.Name = "thanhToanKhiNhanHangToolStripMenuItem";
            this.thanhToanKhiNhanHangToolStripMenuItem.Size = new System.Drawing.Size(371, 38);
            this.thanhToanKhiNhanHangToolStripMenuItem.Text = "Thanh toán khi nhận hàng";
            // 
            // chuyenKhoanToolStripMenuItem
            // 
            this.chuyenKhoanToolStripMenuItem.Name = "chuyenKhoanToolStripMenuItem";
            this.chuyenKhoanToolStripMenuItem.Size = new System.Drawing.Size(371, 38);
            this.chuyenKhoanToolStripMenuItem.Text = "Chuyển khoản";
            this.chuyenKhoanToolStripMenuItem.Click += new System.EventHandler(this.chuyenKhoanToolStripMenuItem_Click);
            // 
            // ghiNoToolStripMenuItem
            // 
            this.ghiNoToolStripMenuItem.Name = "ghiNoToolStripMenuItem";
            this.ghiNoToolStripMenuItem.Size = new System.Drawing.Size(371, 38);
            this.ghiNoToolStripMenuItem.Text = "Ghi nợ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(883, 403);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTuyChinh1
            // 
            this.buttonTuyChinh1.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonTuyChinh1.FlatAppearance.BorderSize = 0;
            this.buttonTuyChinh1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTuyChinh1.Font = new System.Drawing.Font("Palatino Linotype", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTuyChinh1.ForeColor = System.Drawing.Color.White;
            this.buttonTuyChinh1.Image = ((System.Drawing.Image)(resources.GetObject("buttonTuyChinh1.Image")));
            this.buttonTuyChinh1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTuyChinh1.Location = new System.Drawing.Point(948, 619);
            this.buttonTuyChinh1.Name = "buttonTuyChinh1";
            this.buttonTuyChinh1.Size = new System.Drawing.Size(292, 99);
            this.buttonTuyChinh1.TabIndex = 64;
            this.buttonTuyChinh1.Text = "Thanh toán";
            this.buttonTuyChinh1.UseVisualStyleBackColor = false;

            // 
            // FGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1415, 789);
            this.Controls.Add(this.buttonTuyChinh1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucTextBox6);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Name = "FGioHang";
            this.Text = "FGioHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dropdownMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DropdownMenu dropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem thanhToanKhiNhanHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyenKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiNoToolStripMenuItem;
        private UCTextBox ucTextBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ButtonTuyChinh buttonTuyChinh1;
    }
}