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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ucTextBox6 = new DoANLapTrinhWin.UCTextBox();
            this.dropdownMenu1 = new DoANLapTrinhWin.DropdownMenu(this.components);
            this.thanhToanKhiNhanHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyenKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dropdownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1411, 545);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(522, 678);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 84);
            this.button1.TabIndex = 46;
            this.button1.Text = "Thanh Toán";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 61;
            this.label1.Text = "Tổng số tiền";
            // 
            // ucTextBox6
            // 
            this.ucTextBox6.BackColor = System.Drawing.SystemColors.Window;
            this.ucTextBox6.BanKinhKhung = 15;
            this.ucTextBox6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ucTextBox6.GachChan = false;
            this.ucTextBox6.KichThuocKhung = 1;
            this.ucTextBox6.Location = new System.Drawing.Point(355, 595);
            this.ucTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.ucTextBox6.MauKhung = System.Drawing.Color.MediumVioletRed;
            this.ucTextBox6.Multiline = false;
            this.ucTextBox6.Name = "ucTextBox6";
            this.ucTextBox6.Padding = new System.Windows.Forms.Padding(9);
            this.ucTextBox6.Size = new System.Drawing.Size(677, 50);
            this.ucTextBox6.TabIndex = 60;
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
            this.dropdownMenu1.Size = new System.Drawing.Size(372, 162);
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
            // FGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 789);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucTextBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Name = "FGioHang";
            this.Text = "FGioHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dropdownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DropdownMenu dropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem thanhToanKhiNhanHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyenKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiNoToolStripMenuItem;
        private UCTextBox ucTextBox6;
        private System.Windows.Forms.Label label1;
    }
}