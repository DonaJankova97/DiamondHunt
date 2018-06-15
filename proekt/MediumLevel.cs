using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt
{
    public partial class MediumLevel : Form
    {
        
        enum pozicija
        {
            up,
            down,
            left,
            right
        }
        bool left;
        bool right;
        bool down;
        bool up;
        pozicija position;
        public MediumLevel()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();
            laser.Visible = false;
            left = false;
            right = false;
            down = false;
            up = false;
            position = pozicija.right;
            boxOpened1.Visible = false;
            boxOpened2.Visible = false;
            boxOpened3.Visible = false;
            diamond.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top >= this.Height) pictureBox1.Top = -361;
            else pictureBox1.Top += 5;

            if (pictureBox6.Top >= this.Height) pictureBox6.Top = -361;
            else pictureBox6.Top += 5;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Top <= -361) pictureBox2.Top = this.Height;
            else pictureBox2.Top -= 5;

            if (pictureBox7.Top <= -361) pictureBox7.Top = this.Height;
            else pictureBox7.Top -= 5;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Top >= this.Height) pictureBox3.Top = -361;
            else pictureBox3.Top += 5;

            if (pictureBox8.Top >= this.Height) pictureBox8.Top = -361;
            else pictureBox8.Top += 5;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Top <= -361) pictureBox4.Top = this.Height;
            else pictureBox4.Top -= 5;

            if (pictureBox9.Top <= -361) pictureBox9.Top = this.Height;
            else pictureBox9.Top -= 5;

            if (laser.Visible)
            {
                if (laser.Top >= this.Height) laser.Top = -195;
                else laser.Top += 5;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (pictureBox5.Top >= this.Height) pictureBox5.Top = -361;
            else pictureBox5.Top += 5;

            if (pictureBox10.Top >= this.Height) pictureBox10.Top = -361;
            else pictureBox10.Top += 5;
        }

        private void MediumLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                position = pozicija.right;
                right = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                position = pozicija.left;
                left = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                position = pozicija.up;
                up = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                position = pozicija.down;
                down = true;
            }

        }

        public void endGame()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            this.Hide();
            LoseGame l = new LoseGame();
            l.losetext2.Visible = false;
            l.Show();

        }

        private void MediumLevel_KeyUp(object sender, KeyEventArgs e)
        {
            left = false;
            right = false;
            down = false;
            up = false;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (position == pozicija.left && left) pinkPanter.Left -= 5;
            else if (position == pozicija.right && right) pinkPanter.Left += 5;
            else if (position == pozicija.up && up) pinkPanter.Top -= 5;
            else if (position == pozicija.down && down) pinkPanter.Top += 5;

            if (pinkPanter.Bounds.IntersectsWith(pictureBox1.Bounds)) endGame();
            else if (pinkPanter.Bounds.IntersectsWith(pictureBox2.Bounds)) endGame();
            else if (pinkPanter.Bounds.IntersectsWith(pictureBox3.Bounds)) endGame();
            else if (pinkPanter.Bounds.IntersectsWith(pictureBox4.Bounds)) endGame();
            else if (pinkPanter.Bounds.IntersectsWith(pictureBox5.Bounds)) endGame();
            else if (pinkPanter.Bounds.IntersectsWith(pictureBox6.Bounds)) endGame();
            else if (pinkPanter.Bounds.IntersectsWith(pictureBox7.Bounds)) endGame();
            else if (pinkPanter.Bounds.IntersectsWith(pictureBox8.Bounds)) endGame();
            else if (pinkPanter.Bounds.IntersectsWith(pictureBox9.Bounds)) endGame();
            else if (pinkPanter.Bounds.IntersectsWith(pictureBox10.Bounds)) endGame();
            else if (laser.Visible && pinkPanter.Bounds.IntersectsWith(laser.Bounds)) endGame();
            else if (boxClosed1.Visible && pinkPanter.Bounds.IntersectsWith(boxClosed1.Bounds))
            {
                left = false;
                right = false;
                down = false;
                up = false;
                pinkPanter.Location = new Point(494, 86);
                boxClosed1.Visible = false;
                boxOpened1.Visible = true;
                NextStep n = new NextStep("Go ist, to the center,\nthat is where another box\nyou will find!");
                n.Show();
                
            }
            else if (boxOpened1.Visible && pinkPanter.Bounds.IntersectsWith(boxOpened1.Bounds))
            {
                left = false;
                right = false;
                down = false;
                up = false;
                pinkPanter.Location = new Point(494, 86);
                NextStep n = new NextStep("Go east, to the center,\nthat is where another box\nyou will find!");
                n.Show();
            }
            else if (boxOpened1.Visible && pinkPanter.Bounds.IntersectsWith(boxOpened2.Bounds))
            {
                left = false;
                right = false;
                down = false;
                up = false;
                pinkPanter.Location = new Point(792, 213);
                boxOpened2.Visible = true;
                NextStep n = new NextStep("After the first block,\nat the bottom\nis where you need to go!");
                n.Show();
            }
            else if (boxOpened2.Visible && pinkPanter.Bounds.IntersectsWith(boxOpened2.Bounds))
            {
                left = false;
                right = false;
                down = false;
                up = false;
                pinkPanter.Location = new Point(792, 213);
                NextStep n = new NextStep("After the first block,\nat the bottom\nis where you need to go!");
                n.Show();
            }
            else if (boxOpened2.Visible && pinkPanter.Bounds.IntersectsWith(boxOpened3.Bounds))
            {
                boxOpened3.Visible = true;
                diamond.Visible = true;
                laser.Visible = true;
                left = false;
                right = false;
                down = false;
                up = false;
                pinkPanter.Location = new Point(195, 308);
                NextStep n = new NextStep("Watch out\nfor the laser\n and\nget the diamond!");
                n.Show();
            }
            else if (boxOpened3.Visible && pinkPanter.Bounds.IntersectsWith(boxOpened3.Bounds))
            {
                left = false;
                right = false;
                down = false;
                up = false;
                pinkPanter.Location = new Point(195, 308);
                NextStep n = new NextStep("Watch out\nfor the laser\n and\nget the diamond!");
                n.Show();
            }
            else if (diamond.Visible && pinkPanter.Bounds.IntersectsWith(diamond.Bounds))
            {
                diamond.Visible = false;
                timer1.Start();
                timer2.Start();
                timer3.Start();
                timer4.Start();
                timer5.Start();
                timer6.Start();
                this.Hide();
                WinGame w = new WinGame();
                w.Show();
            }

        }

        private void MediumLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
