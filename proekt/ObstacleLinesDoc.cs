using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proekt
{
    class ObstacleLinesDoc
    {
        List<ObstacleLine> lines;

        public ObstacleLinesDoc()
        {
            lines = new List<ObstacleLine>();
        }
        public void addLine(ObstacleLine line)
        {
           // if (lines.Count <= 20)
                lines.Add(line);
        }
        public int NumberLines()
        {
            return lines.Count;
        }
        public void Draw(Graphics g)
        {
            foreach (ObstacleLine line in lines)
            {
                line.pomesti(g);
            }
        }
        public void checkLines(int width, int height)
        {
            foreach (ObstacleLine ol in lines)
                if (ol.removeLine(width, height))
                    lines.Remove(ol);
        }

    }
}
