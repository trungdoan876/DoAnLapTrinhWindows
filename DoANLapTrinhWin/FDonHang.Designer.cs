namespace DoANLapTrinhWin
{
    partial class FDonHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTraHang = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDaGiao = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDangThucHien = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 764);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1387, 55);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnTraHang);
            this.panel4.Location = new System.Drawing.Point(354, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 55);
            this.panel4.TabIndex = 3;
            // 
            // btnTraHang
            // 
            this.btnTraHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTraHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraHang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTraHang.Location = new System.Drawing.Point(-16, -15);
            this.btnTraHang.Name = "btnTraHang";
            this.btnTraHang.Size = new System.Drawing.Size(205, 87);
            this.btnTraHang.TabIndex = 4;
            this.btnTraHang.Text = "Trả hàng/Hoàn tiền";
            this.btnTraHang.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDaGiao);
            this.panel3.Location = new System.Drawing.Point(177, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 55);
            this.panel3.TabIndex = 2;
            // 
            // btnDaGiao
            // 
            this.btnDaGiao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDaGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaGiao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDaGiao.Location = new System.Drawing.Point(-16, -15);
            this.btnDaGiao.Name = "btnDaGiao";
            this.btnDaGiao.Size = new System.Drawing.Size(205, 87);
            this.btnDaGiao.TabIndex = 4;
            this.btnDaGiao.Text = "Đã giao";
            this.btnDaGiao.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDangThucHien);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 55);
            this.panel5.TabIndex = 1;
            // 
            // btnDangThucHien
            // 
            this.btnDangThucHien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDangThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangThucHien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDangThucHien.Location = new System.Drawing.Point(-14, -25);
            this.btnDangThucHien.Name = "btnDangThucHien";
            this.btnDangThucHien.Size = new System.Drawing.Size(203, 104);
            this.btnDangThucHien.TabIndex = 3;
            this.btnDangThucHien.Text = "Đang thực hiện";
            this.btnDangThucHien.UseVisualStyleBackColor = false;
            this.btnDangThucHien.Click += new System.EventHandler(this.btnDangThucHien_Click);
            // 
            // FDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 819);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FDonHang";
            this.Text = "FDonHang";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTraHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDaGiao;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDangThucHien;
    }
}