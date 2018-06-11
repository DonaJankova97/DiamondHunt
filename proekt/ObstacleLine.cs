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
        public ObstacleLine(int width, int height)
        {
            r = new Random();
            x1 = r.Next(1, width);
            y1 = 0;
            x2 = r.Next(-10, width+10);
            y2 = r.Next(-50,1);
            


        }
        public void drawLine(double x1, double y1, double x2, double y2,Graphics g)
        {
            Pen pen = new Pen(Color.Green);
            Point point1 = new Point((int)x1,(int) y1);
            Point point2 = new Point((int)x2, (int)y2);
            g.DrawLine(pen, point1, point2);
            pen.Dispose();

        }
        public void pomesti(Graphics g)
        {
            double k = (y2 - y1) / (x2 - x1);
            double y1New = y1 + 1;
            double x1New = (y1New - y1) / k + x1;

            double y2New = y2 + 1;
            double x2New = (y2New - y2) / k + x2;

            drawLine((int)x1New, (int)y1New, (int)x2New, (int)y2New, g);
            this.x1 = (int)x1New;
            this.x2 = (int)x2New;
            this.y1 = (int)y1New;
            this.y2 = (int)y2New;
        }
    }
    
}
