using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintPrac
{
    internal class Circle : Shape
    {
        
        int HDiameter;
        int VDiameter;
      
       
        public Circle()
        {

        }

        public Circle(int x1, int y1, int hDiameter, int vDiameter, int outlineSize, Color outlineColor, Color fillColor)
        {

            X1 = x1;
            Y1 = y1;
            HDiameter = hDiameter;
            VDiameter = vDiameter;
            OutlineColor = outlineColor;
            OutlineSize = outlineSize;
            FillColor = fillColor;


        }

        public override void Draw(Graphics g)
        {

            Pen pen = new Pen(OutlineColor, OutlineSize);
            g.DrawEllipse(pen, X1, Y1, HDiameter, VDiameter);



        }

        public override void Fill(Graphics g)
        {
            SolidBrush brush = new SolidBrush(FillColor);
            g.FillEllipse(brush, X1, Y1, HDiameter, VDiameter);
        }
    }
}
