using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int scores = 0;
        SoundPlayer gameMusic = new SoundPlayer(Properties.Resources.game_14076);
        SoundPlayer loseSound = new SoundPlayer(Properties.Resources.loseSound);
        bool sound = true;
        bool soundGameOver = true;
        bool restartClick = false;
        public Form1()
        {
            InitializeComponent();
            panelLose.Visible = false;
            buttonLose.Visible = false;
            labelLose.Visible = false;
            finalScore.Visible = false;
            KeyPreview = true;
            gameMusic.Play();
            soundButton.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void panelControl_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void timerGround_Tick(object sender, EventArgs e)
        {
            int speed = 14;
            pictureGround.Left -= speed;
            pictureGround2.Left -= speed;
            if(pictureGround.Left <= -750)
            {
                pictureGround.Left = 0;
                pictureGround2.Left = 750;
            }
            bomb.Left -= speed;
            bomb2.Left -= speed;
            coin.Left -= speed;
            if(bomb.Left <= -1)
            {
                Random rand = new Random();
                bomb.Left = rand.Next(650, 1450);
            }
            if (bomb2.Left <= -1)
            {
                Random rand = new Random();
                bomb2.Left = rand.Next(650, 1450);
                if(((bomb2.Left - bomb.Left) < 160) || ((bomb2.Left - bomb.Left) < 160))
                {
                    bomb2.Left = rand.Next(650, 1450);
                }
            }
            if(coin.Left < -1)
            {
                coin.Visible = true;
                Random rand = new Random();
                coin.Left = rand.Next(650, 1450);
                if((coin.Left == bomb.Left) || (coin.Left == bomb2.Left) || (coin.Left == (bomb.Left + 20)) || (coin.Left == (bomb.Left - 20)) || (coin.Left == (bomb2.Left + 20)) || (coin.Left == (bomb2.Left - 20)) || ((coin.Left - bomb.Left) < 75) || ((bomb2.Left - coin.Left) < 75))
                {
                    coin.Left = rand.Next(650, 1450);
                }
            }
            if (player.Bounds.IntersectsWith(coin.Bounds))
            {
                coin.Left = -2;
                scores++;
                countScores.Text = ": " + scores.ToString();
                coin.Visible = false;
            }
            if((player.Bounds.IntersectsWith(bomb.Bounds)) || (player.Bounds.IntersectsWith(bomb2.Bounds)))
            {
               restartClick = false;
               timerGround.Enabled = false;
               gameMusic.Stop();
               sound = false;
               timerSound.Enabled = false;
               if(soundGameOver == true)
                {
                    loseSound.Play();
                }
               panelLose.Visible = true;
               buttonLose.Visible = true;
               labelLose.Visible = true;
               finalScore.Text = "Score:   " + scores.ToString();
               finalScore.Visible = true;
               scores = 0;
            }
        }
        int countJump = 0;
        int speedJump = 70;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && (player.Top > 550))
            {
                player.Top -= speedJump;
                countJump++;
            }
        }

        private void timerFall_Tick(object sender, EventArgs e)
        {
            countJump = countJump * 2;
            if ((countJump != 0) && (player.Top != 554))
             {
                player.Top += (speedJump / 2);
                countJump--;
             }
        }

        private void buttonLose_Click(object sender, EventArgs e)
        {
            restartClick = true;
            scores = 0;
            countScores.Text = ": " + scores.ToString();
            player.Top = 554;
            player.Left = 100;
            bomb.Left = 350;
            bomb2.Left = 560;
            coin.Left = 455;
            if(soundOffButton.Visible == true)
            {
                sound = true;
                gameMusic.Play();
            }
            timerSound.Enabled = true;
            panelLose.Visible = false;
            buttonLose.Visible = false;
            labelLose.Visible = false;
            timerGround.Enabled = true;
            finalScore.Visible = false;

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            restartClick = false;
            gameMusic.Stop();
            sound = false;
            timerSound.Enabled= false;
            scores = 0;
            countScores.Text = ": " + scores.ToString();
            player.Top = 554;
            player.Left = 100;
            bomb.Left = 350;
            bomb2.Left = 560;
            coin.Left = 455;
            if (soundOffButton.Visible == true)
            {
                sound = true;
                gameMusic.Play();
            }
            timerSound.Enabled = true;
            panelLose.Visible = false;
            buttonLose.Visible = false;
            labelLose.Visible = false;
            timerGround.Enabled = true;
            finalScore.Visible = false;
        }

        private void buttonLose_MouseEnter(object sender, EventArgs e)
        {
            buttonLose.BackColor = Color.FromArgb(54,0,0);
        }

        private void buttonLose_MouseLeave(object sender, EventArgs e)
        {
            buttonLose.BackColor = Color.Black;
        }

        private void timerSound_Tick(object sender, EventArgs e)
        {
            if(sound == true)
            {
                gameMusic.Play();
            }

        }

        private void soundOffButton_Click(object sender, EventArgs e)
        {
            soundGameOver = false;
            sound = false;
            gameMusic.Stop();
            timerSound.Stop();
            soundOffButton.Visible = false;
            soundButton.Visible = true;
        }

        private void soundButton_Click(object sender, EventArgs e)
        {
            soundGameOver = true;
            sound = true;
            if (restartClick == true)
            {
                gameMusic.Play();
                timerSound.Start();
            }
            soundButton.Visible = false;
            soundOffButton.Visible = true;
        }
    }
}
