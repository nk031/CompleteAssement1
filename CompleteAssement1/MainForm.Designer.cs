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
            this.ShootAwayBt = new System.Windows.Forms.Button();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.ScoreLable = new System.Windows.Forms.Label();
            this.LoadBt = new System.Windows.Forms.Button();
            this.SpinBt = new System.Windows.Forms.Button();
            this.GunShootBt = new System.Windows.Forms.Button();
            this.BackgroundPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ShootAwayBt
            // 
            this.ShootAwayBt.Location = new System.Drawing.Point(515, 137);
            this.ShootAwayBt.Name = "ShootAwayBt";
            this.ShootAwayBt.Size = new System.Drawing.Size(168, 72);
            this.ShootAwayBt.TabIndex = 2;
            this.ShootAwayBt.Text = "ShootAway";
            this.ShootAwayBt.UseVisualStyleBackColor = true;
            this.ShootAwayBt.Click += new System.EventHandler(this.ShootAwayBt_Click);
            // 
            // ScoreBox
            // 
            this.ScoreBox.Location = new System.Drawing.Point(324, 389);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(138, 26);
            this.ScoreBox.TabIndex = 3;
            this.ScoreBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ScoreLable
            // 
            this.ScoreLable.AutoSize = true;
            this.ScoreLable.Location = new System.Drawing.Point(360, 354);
            this.ScoreLable.Name = "ScoreLable";
            this.ScoreLable.Size = new System.Drawing.Size(51, 20);
            this.ScoreLable.TabIndex = 4;
            this.ScoreLable.Text = "Score";
            // 
            // LoadBt
            // 
            this.LoadBt.Location = new System.Drawing.Point(27, 194);
            this.LoadBt.Name = "LoadBt";
            this.LoadBt.Size = new System.Drawing.Size(168, 72);
            this.LoadBt.TabIndex = 5;
            this.LoadBt.Text = "Load The Weapon";
            this.LoadBt.UseVisualStyleBackColor = true;
            this.LoadBt.Click += new System.EventHandler(this.LoadBt_Click);
            // 
            // SpinBt
            // 
            this.SpinBt.Location = new System.Drawing.Point(27, 302);
            this.SpinBt.Name = "SpinBt";
            this.SpinBt.Size = new System.Drawing.Size(168, 72);
            this.SpinBt.TabIndex = 6;
            this.SpinBt.Text = "Spin";
            this.SpinBt.UseVisualStyleBackColor = true;
            this.SpinBt.Click += new System.EventHandler(this.SpinBt_Click);
            // 
            // GunShootBt
            // 
            this.GunShootBt.Location = new System.Drawing.Point(515, 26);
            this.GunShootBt.Name = "GunShootBt";
            this.GunShootBt.Size = new System.Drawing.Size(168, 84);
            this.GunShootBt.TabIndex = 1;
            this.GunShootBt.Text = "GunShoot";
            this.GunShootBt.UseVisualStyleBackColor = true;
            this.GunShootBt.Click += new System.EventHandler(this.GunShootBt_Click);
            // 
            // BackgroundPic
            // 
            this.BackgroundPic.Image = global::CompleteAssement1.Properties.Resources.GunBc;
            this.BackgroundPic.Location = new System.Drawing.Point(12, -7);
            this.BackgroundPic.Name = "BackgroundPic";
            this.BackgroundPic.Size = new System.Drawing.Size(706, 445);
            this.BackgroundPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundPic.TabIndex = 0;
            this.BackgroundPic.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.SpinBt);
            this.Controls.Add(this.LoadBt);
            this.Controls.Add(this.ScoreLable);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.ShootAwayBt);
            this.Controls.Add(this.GunShootBt);
            this.Controls.Add(this.BackgroundPic);
            this.Name = "MainForm";
            this.Text = " MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackgroundPic;
        private System.Windows.Forms.Button GunShootBt;
        private System.Windows.Forms.Button ShootAwayBt;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.Label ScoreLable;
        private System.Windows.Forms.Button LoadBt;
        private System.Windows.Forms.Button SpinBt;
    }
}

