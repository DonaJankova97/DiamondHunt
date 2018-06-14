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
    public partial class DiamondHunt : Form
    {
        enum DIRECTION { up, down, left, right }
        DIRECTION direction;
        bool up, down, right, left;
        Diamond diamond;
        Player player;
        Point movingPlayer;
        static int width = 1000;
        static int height = 500;
        int time;
        ObstacleLinesDoc lines;

        public DiamondHunt()
        {
            InitializeComponent();
            direction = DIRECTION.right;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Width = panel1.Width = width;
            this.Height = panel1.Height = height;
            diamond = new Diamond(new Point(this.Width / 2, this.Height));
            movingPlayer = new Point(this.Width - 5, this.Height / 2);
            player = new Player(movingPlayer);
            timer1.Interval = 100;
            timer1.Start();
            timer1.Tick += timer1_Tick;
            laserTimer.Interval = 100;
            laserTimer.Start();
            time = 0;
            lines = new ObstacleLinesDoc();
            pictureBox1.Width = pictureBox1.Image.Width;
            pictureBox1.Height = pictureBox1.Image.Height;


        }

        private void DiamondHunt_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            // if(player.pinkPanther.)
            if (direction == DIRECTION.left && left) pinkPanther.Left -= 5;// pinkPanther.Location = new Point(pinkPanther.Location.X-5,pinkPanther.Location.Y); //player.movePlayer(new Point(movingPlayer.X - 50, movingPlayer.Y));
            else if (direction == DIRECTION.right && right) pinkPanther.Left += 5; //pinkPanther.Location = new Point(pinkPanther.Location.X + 5, pinkPanther.Location.Y);// player.movePlayer(new Point(movingPlayer.X + 5, movingPlayer.Y));
            else if (direction == DIRECTION.up && up) pinkPanther.Top -= 5; //pinkPanther.Location = new Point(pinkPanther.Location.X , pinkPanther.Location.Y-5);//player.movePlayer(new Point(movingPlayer.X, movingPlayer.Y - 5));
            else if (direction == DIRECTION.down && down) pinkPanther.Top += 5; //pinkPanther.Location = new Point(pinkPanther.Location.X , pinkPanther.Location.Y+5);//player.movePlayer(new Point(movingPlayer.X, movingPlayer.Y + 5));


            Invalidate(true);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            diamond.diamondDraw(graphics);
            player.drawPinkPanther(graphics);

            if (time % 100 == 0)
                lines.Move(graphics);
            else
                lines.Draw(graphics);

            this.SuspendLayout();
            pictureBox1.Location = new Point( -pictureBox1.Image.Width+ time, 0);
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //player.movePlayer(e.Location);
            //Invalidate(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pinkPanther_Click(object sender, EventArgs e)
        {

        }

        private void laserTimer_Tick(object sender, EventArgs e)
        {
            ObstacleLine line = new ObstacleLine(this.Width, this.Height);
            lines.addLine(line);
            //lines.checkLines(this.Width,this.Height);
            Invalidate(true);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = String.Format("NumberLines: {0}", lines.NumberLines());

        }
    }
}

