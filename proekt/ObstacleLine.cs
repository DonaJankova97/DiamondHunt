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
        int length;
        public ObstacleLine(int width, int height)
        {
            r = new Random();
            length = 100;
            angle = r.Next(0, 360);
            x1 = r.Next(1, width);
            y1 = 0;
            x2 = x1 + Math.Cos(angle) * length;
            y2 = y1 + Math.Sin(angle) * length;

        }
        public void drawLine(double x1, double y1, double x2, double y2, Graphics g)
        {
            Pen pen = new Pen(Color.Green, 3);
            Point point1 = new Point((int)x1, (int)y1);
            Point point2 = new Point((int)x2, (int)y2);
            g.DrawLine(pen, point1, point2);
            pen.Dispose();

        }
        public void pomesti(Graphics g)
        {
            length++;
            double y1New = y1 + Math.Sin(angle) * length;
            double x1New = x1 + Math.Cos(angle) * length;
            double y2New = y2 + Math.Sin(angle) * length;
            double x2New = x2 + Math.Cos(angle) * length;

            drawLine((int)x1New, (int)y1New, (int)x2New, (int)y2New, g);
            this.x1 = (int)x1New;
            this.x2 = (int)x2New;
            this.y1 = (int)y1New;
            this.y2 = (int)y2New;
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
