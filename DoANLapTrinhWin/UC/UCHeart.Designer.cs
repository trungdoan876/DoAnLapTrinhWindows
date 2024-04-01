namespace DoANLapTrinhWin
{
    partial class UCHeart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHeart));
            this.picHeart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).BeginInit();
            this.SuspendLayout();
            // 
            // picHeart
            // 
            this.picHeart.Image = ((System.Drawing.Image)(resources.GetObject("picHeart.Image")));
            this.picHeart.Location = new System.Drawing.Point(2, 0);
            this.picHeart.Margin = new System.Windows.Forms.Padding(2);
            this.picHeart.Name = "picHeart";
            this.picHeart.Size = new System.Drawing.Size(43, 50);
            this.picHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeart.TabIndex = 45;
            this.picHeart.TabStop = false;
            this.picHeart.Click += new System.EventHandler(this.picHeart_Click);
            // 
            // UCHeart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picHeart);
            this.Name = "UCHeart";
            this.Size = new System.Drawing.Size(48, 52);
            this.Load += new System.EventHandler(this.UCHeart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeart;
    }
}
