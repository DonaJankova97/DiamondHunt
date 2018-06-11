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
            Panel panel1 = new Panel();
            Timer timer1 = new Timer();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Width = panel1.Width = width;
            this.Height = panel1.Height = height;
            diamond = new Diamond(new Point(this.Width/2, this.Height));
            player = new Player();
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            laserTimer.Interval = 3;
            laserTimer.Start();
            time = 0;
            lines = new ObstacleLinesDoc();
        }

        private void DiamondHunt_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            diamond.diamondDraw(graphics);
            player.drawPinkPanther(movingPlayer, graphics);
            lines.Draw(graphics);

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            movingPlayer = e.Location;
            Invalidate(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void laserTimer_Tick(object sender, EventArgs e)
        {
            ObstacleLine line = new ObstacleLine(this.Width, this.Height);
            lines.addLine(line);
            //lines.checkLines(this.Width,this.Height);
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
