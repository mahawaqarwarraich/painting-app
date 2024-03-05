using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintPrac
{
    internal class Pentagon : Shape
    {
        Point Vertex1;
        Point Vertex2;
        Point Vertex3;
        Point Vertex4;
        Point Vertex5;



        public Pentagon()
        {

            OutlineColor = Color.Black;
            OutlineSize = 2;
            FillColor = Color.Transparent;


        }

        public Pentagon(Point vertex1, Point vertex2, Point vertex3, Point vertex4, Point vertex5, int outlineSize, Color outlineColor, Color fillColor)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
            Vertex3 = vertex3;
            Vertex4 = vertex4;
            Vertex5 = vertex5;
            OutlineColor = outlineColor;
            OutlineSize = outlineSize;
            FillColor = fillColor;

        }

        public override void Draw(Graphics g)
        {

            Pen pen = new Pen(OutlineColor, OutlineSize);
            Point[] pentagonPoints = { Vertex1, Vertex2, Vertex3, Vertex4, Vertex5 };
            g.DrawPolygon(pen, pentagonPoints);


        }

        public override void Fill(Graphics g)
        {
            SolidBrush brush = new SolidBrush(FillColor);
            Point[] pentagonPoints = { Vertex1, Vertex2, Vertex3, Vertex4, Vertex5 };
            g.FillPolygon(brush, pentagonPoints);


        }



    }
}
