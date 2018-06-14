using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt
{
    class Player
    {

        public Image pinkPanther { get; }
        public Point playerPosition { get; set; }

        public Player(Point point)
        {
            pinkPanther = proekt.Properties.Resources.pinkPanther;
            playerPosition = point;

        }
        public void drawPinkPanther(Graphics graphics)
        {
            graphics.DrawImageUnscaled(pinkPanther, playerPosition.X - pinkPanther.Size.Width / 2, playerPosition.Y - pinkPanther.Size.Height / 2);

        }
        public void movePlayer(Point point)
        {
            playerPosition = point;
        }

    }
}
