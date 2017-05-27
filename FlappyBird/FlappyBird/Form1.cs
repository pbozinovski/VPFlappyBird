using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class FlappyBird : Form
    {
        public FlappyBird()
        {
            InitializeComponent();
        }

        int score;
        int speed = 3;
        int G = 12;
        int force;

        private void Form1_Load(object sender, EventArgs e)
        {

            lblScore.Visible = false;
            pbEnd.Visible = false;
            MakePipes();
            lblRestart.Visible = false;
           
        }

        //funckija za pravenje cevki
        private void MakePipes()
        {
            PictureBox botPipe = new PictureBox();
            PictureBox topPipe = new PictureBox();
            botPipe.Image = Properties.Resources.bottompipe;
            topPipe.Image = Properties.Resources.toppipe;
            topPipe.SizeMode = PictureBoxSizeMode.StretchImage;
            botPipe.SizeMode = PictureBoxSizeMode.StretchImage;
            botPipe.Size = new Size(100, 450);
            topPipe.Size = new Size(100, 450);  
            Random rnd = new Random();
            var value = rnd.Next(-380, -200);
            topPipe.Location = new Point(800, value);
            botPipe.Location = new Point(800, 590 + value);
            botPipe.Tag = "botP";
            topPipe.Tag = "topP";
            this.Controls.Add(botPipe);
            this.Controls.Add(topPipe);
        }

        //timer za cevki
        private void PipeTimer_Tick(object sender, EventArgs e)
        {
            MakePipes();
        }

        //glaven timer
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //Dvizenje na cevkite vo levo
            foreach (Control i in this.Controls)
            {
                if (i is PictureBox && i.Tag == "topP")
                {
                    i.Left -= speed;
                    //brishenje na cevki
                    if (((PictureBox)i).Left < this.Width - 950)
                    {
                        this.Controls.Remove(i);
                        //poeni
                        score++;
                    }
                    //proveruva dali udira pticata vo cevka
                    if (i.Bounds.IntersectsWith(bird.Bounds))
                    {
                        GameOver();
                    }
                }

            }

            //Dvizenje na cevkite vo levo
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "botP")
                {
                    j.Left -= speed;
                    //brishenje na cevki
                    if (((PictureBox)j).Left < this.Width - 950)
                    {
                        this.Controls.Remove(j);
                    }
                    //proveruva dali udira pticata vo cevka
                    if (j.Bounds.IntersectsWith(bird.Bounds))
                    {
                        GameOver();
                    }
                }

            }
            //proveruva dali udira pticata vo zemja
            if (bird.Bounds.IntersectsWith(ground.Bounds))
            {
                GameOver();
            }

            //ogranicuvanje na pticata nagore
            if (bird.Top < this.Height-500)
            {
                bird.Location = new Point(138, 8);
            }

            //skokanje na pticata
            bird.Top -= force;
            if (force > -8)
            {
                force -= 1;
            }
            else
            {
                force = -8;
            }
            //display na score na forma
            this.Text = string.Format("FlappyBird - Score: {0}", score);

            Invalidate();

        }

        //funkcija za kraj na igrata
        private void GameOver()
        {
            
            PipeTimer.Stop();
            GameTimer.Stop();
            lblRestart.Visible = true;
            lblScore.Text = "Your score is: "+score;
            lblScore.Visible = true;
            pbEnd.Visible = true;
           

        }

        //funkcija za start na click
        private void lblStart_Click(object sender, EventArgs e)
        {
            force = G;
            lblStart.Visible = false;
            PipeTimer.Start();
            GameTimer.Start();
        }

        private void Restart()
        {
            
            GameTimer.Stop();
            PipeTimer.Stop();

            //Brishenje na cevkite posle restart
            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix] is PictureBox && this.Controls[ix].Tag == "topP")
                {
                    this.Controls[ix].Dispose();
                }
                else if (this.Controls[ix] is PictureBox && this.Controls[ix].Tag == "botP") this.Controls[ix].Dispose();
            }

            bird.Location = new Point(138, 182);
            score = 0;
            pbEnd.Visible = false;
            force = G;
            lblRestart.Visible = false;
            lblScore.Visible = false;
            lblStart.Visible = true;
            speed = 3;
            PipeTimer.Interval = 2000;
            MakePipes();

        }

        private void FlappyBird_KeyDown(object sender, KeyEventArgs e)
        {
            //Start na igrata na kopce Space, skokanje na Space
            if(e.KeyCode == Keys.Space)
            {
                if (!GameTimer.Enabled && pbEnd.Visible == false)
                {
                    GameTimer.Start();
                    force = G;
                    lblStart.Visible = false;
                    PipeTimer.Start();
                    
                }
                
                force = G;
            }

            //Resetiranje na igrata na kopce Enter
            if(e.KeyCode == Keys.Enter)
            {
                if (!GameTimer.Enabled && pbEnd.Visible == true)
                {
                    Restart();
                }
            }

            //Zgolemuvanje na brzina na dvizenje na cevkite i interval
            if (score == 10)
            {
                speed += 1;
                PipeTimer.Interval = 1000;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Restart();
        }

     
    }
}
