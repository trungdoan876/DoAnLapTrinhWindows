namespace DoANLapTrinhWin
{
    partial class FDaGiaoNB
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
            this.panelDaGiao = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelDaGiao
            // 
            this.panelDaGiao.AutoScroll = true;
            this.panelDaGiao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDaGiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDaGiao.Location = new System.Drawing.Point(0, 0);
            this.panelDaGiao.Name = "panelDaGiao";
            this.panelDaGiao.Size = new System.Drawing.Size(1495, 698);
            this.panelDaGiao.TabIndex = 0;
            // 
            // FDaGiaoNB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 698);
            this.Controls.Add(this.panelDaGiao);
            this.Name = "FDaGiaoNB";
            this.Text = "FDaGiaoNB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelDaGiao;
    }
}