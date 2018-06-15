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
    public partial class EasyLevel : Form
    {
        enum DIRECTION { up, down, left, right }
        DIRECTION direction;
        bool up, down, right, left;
        static int width = 1000;
        static int height = 500;
        int time;
        int n1, n2, n3, n4;
        ObstacleLinesDoc lines;
        int points;
        public EasyLevel()
        {
            InitializeComponent();
            direction = DIRECTION.right;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Width = panel1.Width = width;
            this.Height = panel1.Height = height;
            Random r = new Random();
            timer1.Interval = 50;
           
           
            time = 0;
            lines = new ObstacleLinesDoc();
            pictureBox1.Width = pictureBox1.Image.Width;
            pictureBox1.Height = pictureBox1.Image.Height;
            n1 = n2 = n3 = n4 = 1;
            laser1.Left = r.Next(0, this.Width - laser1.Width);
            laser2.Left = r.Next(0, this.Width - laser2.Width);
            laser3.Left = r.Next(0, this.Width - laser3.Width);
            laser4.Left = r.Next(0, this.Width - laser4.Width);
            trap1.Left = r.Next(0, this.Width - trap1.Width);
            trap2.Left = r.Next(0, this.Width - trap2.Width);
            trap3.Left = r.Next(0, this.Width - trap3.Width);
            trap1.Visible = trap2.Visible = trap3.Visible = true;
            goalDiamond.Visible = false;
            points = 0;
        }
        public void TimerStart()
        {
            timer1.Start();
            laserTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (direction == DIRECTION.left && left) pinkPanther.Left -= 5;
            else if (direction == DIRECTION.right && right) pinkPanther.Left += 5; 
            else if (direction == DIRECTION.up && up) pinkPanther.Top -= 5; 
            else if (direction == DIRECTION.down && down) pinkPanther.Top += 5; 
            

            if (diamond11.Bounds.IntersectsWith(pinkPanther.Bounds)) { points++; diamond11.Visible = false; }
            if (diamond22.Bounds.IntersectsWith(pinkPanther.Bounds)) { points++; diamond22.Visible = false; }
            if (diamond33.Bounds.IntersectsWith(pinkPanther.Bounds)) { points++; diamond33.Visible = false; }

            if (!diamond11.Visible && !diamond22.Visible && !diamond33.Visible)
                goalDiamond.Visible = true;
            if (pinkPanther.Bounds.IntersectsWith(goalDiamond.Bounds) && goalDiamond.Visible) winGame();
            

            if (pictureBox1.Location.X == 0) { endGame(); return; }
            else if(pictureBox1.Bounds.IntersectsWith(diamond11.Bounds)) { endGame(); return; }
            else if (pictureBox1.Bounds.IntersectsWith(diamond22.Bounds)) { endGame(); return; }
            else if (pictureBox1.Bounds.IntersectsWith(diamond33.Bounds)) { endGame(); return; }
            else if (pinkPanther.Bounds.IntersectsWith(pictureBox1.Bounds)) { endGame(); return; }
            else if (pinkPanther.Bounds.IntersectsWith(laser1.Bounds)) { endGame(); return; }
            else if (pinkPanther.Bounds.IntersectsWith(laser2.Bounds)) { endGame(); return; }
            else if (pinkPanther.Bounds.IntersectsWith(laser3.Bounds)) { endGame(); return; }
            else if (pinkPanther.Bounds.IntersectsWith(laser4.Bounds)) { endGame(); return; }
            else if (trap1.Bounds.IntersectsWith(pinkPanther.Bounds)) { trap1.Visible = true; endGame(); return; }
            else if (trap2.Bounds.IntersectsWith(pinkPanther.Bounds)) { trap2.Visible = true; endGame(); return; }
            else if (trap3.Bounds.IntersectsWith(pinkPanther.Bounds)) { trap3.Visible = true; endGame(); return; }
            //else Invalidate(true);


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (time % 100 == 0)
                lines.Move(graphics);
            else
                lines.Draw(graphics);

            this.SuspendLayout();
            pictureBox1.Location = new Point(-pictureBox1.Image.Width + time, 0);
            this.ResumeLayout();

        }
        private void DiamondHunt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                direction = DIRECTION.right;
                right = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                direction = DIRECTION.left;
                left = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                direction = DIRECTION.up;
                up = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                direction = DIRECTION.down;
                down = true;
            }
            Invalidate(true);

        }
        private void DiamondHunt_KeyUp(object sender, KeyEventArgs e)
        {
            up = right = down = left = false;

        }
       
        private void DiamondHunt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void laserTimer_Tick(object sender, EventArgs e)
        {
            ObstacleLine line = new ObstacleLine(this.Width, this.Height);
            lines.addLine(line);
            if (laser1.Location.X == this.Width - laser1.Width || laser1.Location.X == 0)
                n1 = n1 * (-1);
            if (laser2.Location.X == this.Width - laser2.Width || laser2.Location.X == 0)
                n2 = n2 * (-1);
            if (laser3.Location.X == this.Width - laser3.Width || laser3.Location.X == 0)
                n3 = n3 * (-1);
            if (laser4.Location.X == this.Width - laser4.Width || laser4.Location.X == 0)
                n4 = n4 * (-1);
            laser1.Left = laser1.Location.X + 1 * n1;
            laser2.Left = laser2.Location.X + 1 * n2;
            laser3.Left = laser3.Location.X + 1 * n3;
            laser4.Left = laser4.Location.X + 1 * n4;
            Invalidate(true);
        }
        
        public void endGame()
        {
            timer1.Stop();
            laserTimer.Stop();
            this.Hide();      
            LoseGame l = new LoseGame();
            l.losetext2.Visible = false;
            l.Show();

        }
        public void winGame()
        {
            timer1.Stop();
            this.Hide();
            WinGame w = new WinGame();
            w.Show();

        }
    }
}

