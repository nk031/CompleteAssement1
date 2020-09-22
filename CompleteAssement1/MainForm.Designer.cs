namespace CompleteAssement1
{
    partial class MainForm
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
            this.GunShootBt = new System.Windows.Forms.Button();
            this.BackgroundPic = new System.Windows.Forms.PictureBox();
            this.ShootAwayBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPic)).BeginInit();
            this.SuspendLayout();
            // 
            // GunShootBt
            // 
            this.GunShootBt.Location = new System.Drawing.Point(58, 40);
            this.GunShootBt.Name = "GunShootBt";
            this.GunShootBt.Size = new System.Drawing.Size(168, 72);
            this.GunShootBt.TabIndex = 1;
            this.GunShootBt.Text = "GunShoot";
            this.GunShootBt.UseVisualStyleBackColor = true;
            this.GunShootBt.Click += new System.EventHandler(this.GunShootBt_Click);
            // 
            // BackgroundPic
            // 
            this.BackgroundPic.Image = global::CompleteAssement1.Properties.Resources.AngerPic;
            this.BackgroundPic.Location = new System.Drawing.Point(24, 12);
            this.BackgroundPic.Name = "BackgroundPic";
            this.BackgroundPic.Size = new System.Drawing.Size(661, 408);
            this.BackgroundPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackgroundPic.TabIndex = 0;
            this.BackgroundPic.TabStop = false;
            // 
            // ShootAwayBt
            // 
            this.ShootAwayBt.Location = new System.Drawing.Point(58, 140);
            this.ShootAwayBt.Name = "ShootAwayBt";
            this.ShootAwayBt.Size = new System.Drawing.Size(168, 72);
            this.ShootAwayBt.TabIndex = 2;
            this.ShootAwayBt.Text = "ShootAway";
            this.ShootAwayBt.UseVisualStyleBackColor = true;
            this.ShootAwayBt.Click += new System.EventHandler(this.ShootAwayBt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.ShootAwayBt);
            this.Controls.Add(this.GunShootBt);
            this.Controls.Add(this.BackgroundPic);
            this.Name = "MainForm";
            this.Text = " MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackgroundPic;
        private System.Windows.Forms.Button GunShootBt;
        private System.Windows.Forms.Button ShootAwayBt;
    }
}

