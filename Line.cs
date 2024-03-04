using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintPrac
{
    internal class Line  : Shape
    {
        int X2;
        int Y2;
        public Line()
        {

        }

        public Line(int x1, int y1, int x2, int y2, int outlineSize, Color outlineColor)
        {

            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;

            OutlineColor = outlineColor;
            OutlineSize = outlineSize;
          


        }

        public override void Draw(Graphics g)
        {

            Pen pen = new Pen(OutlineColor, OutlineSize);
            g.DrawLine(pen, X1, Y1, X2, Y2);



        }

        public override void Fill(Graphics g)
        {
        }

        }
}
