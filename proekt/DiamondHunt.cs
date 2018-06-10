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
        public DiamondHunt()
        {
            InitializeComponent();
        }

        private void DiamondHunt_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            Panel panel1 = new Panel();
            Timer timer1 = new Timer();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Width = panel1.Width = width;
            this.Height = panel1.Height = height;
            diamond = new Diamond(new Point(500, 400));
            player = new Player();
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            diamond.diamondDraw(graphics);
            player.drawPinkPanther(movingPlayer, graphics);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            movingPlayer = e.Location;
            Invalidate(true);
        }
    }
}
