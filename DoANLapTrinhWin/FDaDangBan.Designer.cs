﻿namespace DoANLapTrinhWin
{
    partial class FDaDangBan
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
            this.panelDangBan = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelDangBan
            // 
            this.panelDangBan.BackColor = System.Drawing.Color.White;
            this.panelDangBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDangBan.Location = new System.Drawing.Point(0, 0);
            this.panelDangBan.Name = "panelDangBan";
            this.panelDangBan.Size = new System.Drawing.Size(748, 485);
            this.panelDangBan.TabIndex = 0;
            // 
            // FDaDangBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 485);
            this.Controls.Add(this.panelDangBan);
            this.Name = "FDaDangBan";
            this.Text = "FDaDangBan";
            this.Load += new System.EventHandler(this.FDaDangBan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelDangBan;
    }
}