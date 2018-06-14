using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt
{

    class ObstacleLine
    {
        Random r;
        double x1, x2, y1, y2;
        double angle;
        Image laser;
        public ObstacleLine(int width, int height)
        {
            r = new Random();
            laser = proekt.Properties.Resources.laserline;
            angle = r.Next(0, 360);
            int[] x1pos = new int[] { 1, width / 4, width / 3, 3 * width / 4, width };
            x1 = x1pos[r.Next(0, x1pos.Length - 1)];
            y1 = 0;
            x2 = x1 + Math.Cos(angle);
            y2 = y1 + Math.Sin(angle);

        }
        public void drawLine(Graphics g)
        {
            //Pen pen = new Pen(Color.Green, 3);
            //Point point1 = new Point((int)x1, (int)y1);
            //Point point2 = new Point((int)x2, (int)y2);
            //g.DrawLine(pen, point1, point2);
            //pen.Dispose();
            g.DrawImageUnscaled(laser, (int)x1, (int)y1, (int)x2, (int)y2);
        }
        public void pomesti(Graphics g)
        {

            double y1New = y1 + Math.Sin(angle) * laser.Height / 2;
            double x1New = x1 + Math.Cos(angle) * laser.Height / 2;
            double y2New = y2 + Math.Sin(angle) * laser.Height / 2;
            double x2New = x2 + Math.Cos(angle) * laser.Height / 2;


            this.x1 = (int)x1New;
            this.x2 = (int)x2New;
            this.y1 = (int)y1New;
            this.y2 = (int)y2New;
            drawLine(g);
        }
        public bool removeLine(int width, int height)
        {
            if (x1 < 0 || x1 > width || y1 > height)
                return true;
            else
                return false;
        }
    }

}
