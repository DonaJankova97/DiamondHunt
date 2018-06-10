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
        Image pinkPanther;
        Graphics graphics;
        public Player()
        {
            pinkPanther = proekt.Properties.Resources.pinkPanther;
            
        }
        public void drawPinkPanther(Point point,Graphics graphics)
        {
           graphics.DrawImageUnscaled(pinkPanther, point.X-pinkPanther.Size.Width/2,point.Y-pinkPanther.Size.Height/2);
            
        }
    }
}
