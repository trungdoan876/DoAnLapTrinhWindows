﻿namespace DoANLapTrinhWin
{
    partial class UCTheoNB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltenNB = new System.Windows.Forms.Label();
            this.panelSP = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbltenNB);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 72);
            this.panel1.TabIndex = 0;
            // 
            // lbltenNB
            // 
            this.lbltenNB.AutoSize = true;
            this.lbltenNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenNB.Location = new System.Drawing.Point(19, 24);
            this.lbltenNB.Name = "lbltenNB";
            this.lbltenNB.Size = new System.Drawing.Size(71, 25);
            this.lbltenNB.TabIndex = 0;
            this.lbltenNB.Text = "tenNB";
            // 
            // panelSP
            // 
            this.panelSP.AutoScroll = true;
            this.panelSP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSP.Location = new System.Drawing.Point(3, 81);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(1054, 190);
            this.panelSP.TabIndex = 1;
            // 
            // UCTheoNB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSP);
            this.Controls.Add(this.panel1);
            this.Name = "UCTheoNB";
            this.Size = new System.Drawing.Size(1060, 287);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltenNB;
        public System.Windows.Forms.Panel panelSP;
    }
}