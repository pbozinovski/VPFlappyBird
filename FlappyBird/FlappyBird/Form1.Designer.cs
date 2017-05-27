namespace FlappyBird
{
    partial class FlappyBird
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
            this.PipeTimer = new System.Windows.Forms.Timer(this.components);
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblStart = new System.Windows.Forms.Label();
            this.lblRestart = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbEnd = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.pbEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PipeTimer
            // 
            this.PipeTimer.Interval = 2000;
            this.PipeTimer.Tick += new System.EventHandler(this.PipeTimer_Tick);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 10;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Chiller", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(292, 186);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(271, 43);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Press \'Space\' to start";
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.BackColor = System.Drawing.Color.Transparent;
            this.lblRestart.Font = new System.Drawing.Font("Chiller", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.ForeColor = System.Drawing.Color.Black;
            this.lblRestart.Location = new System.Drawing.Point(94, 194);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(240, 38);
            this.lblRestart.TabIndex = 5;
            this.lblRestart.Text = "Press \'Enter\' to restart\r\n";
            this.lblRestart.Click += new System.EventHandler(this.label1_Click);
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-10, 416);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(846, 131);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::FlappyBird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(138, 182);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(43, 35);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            this.bird.Tag = "bird";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Chiller", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(123, 140);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 38);
            this.lblScore.TabIndex = 7;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEnd
            // 
            this.pbEnd.BackColor = System.Drawing.Color.Khaki;
            this.pbEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEnd.Controls.Add(this.pictureBox1);
            this.pbEnd.Controls.Add(this.lblScore);
            this.pbEnd.Controls.Add(this.lblRestart);
            this.pbEnd.Location = new System.Drawing.Point(221, 28);
            this.pbEnd.Name = "pbEnd";
            this.pbEnd.Size = new System.Drawing.Size(426, 253);
            this.pbEnd.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlappyBird.Properties.Resources.GameOver;
            this.pictureBox1.Location = new System.Drawing.Point(53, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(829, 462);
            this.Controls.Add(this.pbEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bird);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(845, 501);
            this.MinimumSize = new System.Drawing.Size(845, 501);
            this.Name = "FlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.pbEnd.ResumeLayout(false);
            this.pbEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Timer PipeTimer;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblRestart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Panel pbEnd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

