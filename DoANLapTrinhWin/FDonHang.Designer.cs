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
            this.btnChuaDangBan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDaDangBan = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTatCaSP = new System.Windows.Forms.Button();
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
            this.panel4.Controls.Add(this.btnChuaDangBan);
            this.panel4.Location = new System.Drawing.Point(354, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 55);
            this.panel4.TabIndex = 3;
            // 
            // btnChuaDangBan
            // 
            this.btnChuaDangBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChuaDangBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuaDangBan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChuaDangBan.Location = new System.Drawing.Point(-16, -15);
            this.btnChuaDangBan.Name = "btnChuaDangBan";
            this.btnChuaDangBan.Size = new System.Drawing.Size(205, 87);
            this.btnChuaDangBan.TabIndex = 4;
            this.btnChuaDangBan.Text = "Trả hàng/Hoàn tiền";
            this.btnChuaDangBan.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDaDangBan);
            this.panel3.Location = new System.Drawing.Point(177, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 55);
            this.panel3.TabIndex = 2;
            // 
            // btnDaDangBan
            // 
            this.btnDaDangBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDaDangBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaDangBan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDaDangBan.Location = new System.Drawing.Point(-16, -15);
            this.btnDaDangBan.Name = "btnDaDangBan";
            this.btnDaDangBan.Size = new System.Drawing.Size(205, 87);
            this.btnDaDangBan.TabIndex = 4;
            this.btnDaDangBan.Text = "Đã giao";
            this.btnDaDangBan.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnTatCaSP);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 55);
            this.panel5.TabIndex = 1;
            // 
            // btnTatCaSP
            // 
            this.btnTatCaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTatCaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCaSP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTatCaSP.Location = new System.Drawing.Point(-14, -25);
            this.btnTatCaSP.Name = "btnTatCaSP";
            this.btnTatCaSP.Size = new System.Drawing.Size(203, 104);
            this.btnTatCaSP.TabIndex = 3;
            this.btnTatCaSP.Text = "Đang thực hiện";
            this.btnTatCaSP.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Button btnChuaDangBan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDaDangBan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnTatCaSP;
    }
}