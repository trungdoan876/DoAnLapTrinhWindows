namespace DoANLapTrinhWin
{
    partial class FDaGiaoNM
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
            this.panelDaGiao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDaGiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDaGiao.Location = new System.Drawing.Point(0, 0);
            this.panelDaGiao.Name = "panelDaGiao";
            this.panelDaGiao.Size = new System.Drawing.Size(1399, 640);
            this.panelDaGiao.TabIndex = 0;
            // 
            // FDaGiaoNM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 640);
            this.Controls.Add(this.panelDaGiao);
            this.Name = "FDaGiaoNM";
            this.Text = "FDaGiaoNM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelDaGiao;
    }
}