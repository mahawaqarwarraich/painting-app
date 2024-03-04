using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintPrac
{
    internal class Triangle : Shape
    {
        Point Vertex1;
        Point Vertex2;
        Point Vertex3;
        

       
        public Triangle()
        {
            OutlineColor = Color.Black;
            OutlineSize = 2;
            FillColor = Color.Transparent;


        }

        public Triangle(Point vertex1, Point vertex2, Point vertex3, int outlineSize, Color outlineColor, Color fillColor)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
            Vertex3 = vertex3;
            OutlineColor = outlineColor;
            OutlineSize = outlineSize;
            FillColor = fillColor;

        }

        public override void Draw(Graphics g)
        {

            Pen pen = new Pen(OutlineColor, OutlineSize);
            Point[] trianglePoints = { Vertex1, Vertex2, Vertex3 };
            g.DrawPolygon(pen, trianglePoints);

  
        }

        public override void Fill(Graphics g)
        {
            SolidBrush brush = new SolidBrush(FillColor);
            Point[] trianglePoints = { Vertex1, Vertex2, Vertex3 };
            g.FillPolygon(brush, trianglePoints);


        }



    }
}
