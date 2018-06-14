using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt
{
    class Diamond
    {
        Image diamond;
        Point positionDiamond;
       
        static int squareWidth=150;
    
        public Diamond(Point position)
        {
            diamond= proekt.Properties.Resources.Diamond;
            positionDiamond = new Point(position.X,position.Y);
            
           
        }
        public void diamondDraw(Graphics graphics)
        {
            
            graphics.DrawImageUnscaled(diamond, positionDiamond.X,positionDiamond.Y-diamond.Height,diamond.Width,diamond.Height);
     
            
        }
       
    }
}
