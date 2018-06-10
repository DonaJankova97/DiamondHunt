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
        Point squareAngle;
        static int squareWidth=150;
    
        public Diamond(Point position)
        {
            diamond= proekt.Properties.Resources.Diamond;
            positionDiamond = new Point(position.X,position.Y);
            squareAngle = new Point(positionDiamond.X-60, positionDiamond.Y-70 );
           
        }
        public void diamondDraw(Graphics graphics)
        {
            SolidBrush solidBrush = new SolidBrush(Color.LightGray);
            Pen pen = new Pen(solidBrush,10);
            graphics.DrawImageUnscaled(diamond, positionDiamond.X,positionDiamond.Y,diamond.Width,diamond.Height);
            graphics.DrawRectangle(pen, squareAngle.X, squareAngle.Y, squareWidth, squareWidth);
            pen.Dispose();
        }
       
    }
}
