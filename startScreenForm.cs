using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class startScreenForm : Form
    {
        SoundPlayer menu = new SoundPlayer(Properties.Resources.menu_1038);
        bool sound = true;
        public startScreenForm()
        {
            InitializeComponent();
            menu.Play();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void panelControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void timerBgStart_Tick(object sender, EventArgs e)
        {
            int speedBgStart = 3;
            backgroundStart.Left -= speedBgStart;
            backgroundStart2.Left -= speedBgStart;
            if(backgroundStart.Left <= -750)
            {
                backgroundStart.Left = 0;
                backgroundStart2.Left = 750;
            }
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            label.Text = "Jumping Cat";
            label.BackColor = Color.Maroon;
            label.ForeColor = Color.White;
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            label.Text = "   START   ";
            label.BackColor = Color.Maroon;
            label.ForeColor = Color.White;
        }

        private void label_Click(object sender, EventArgs e)
        {
            menu.Stop();
            sound = false;
            this.Hide();
            Form1 gameForm = new Form1();
            gameForm.Show();
        }

        private void timerSound_Tick(object sender, EventArgs e)
        {
            if(sound == true)
            {
                menu.Play();
            }
        }
    }
}
