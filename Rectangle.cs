using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

namespace PaintPrac
{
    internal class Rectangle : Shape
    {
        
        int Width;
        int Height;
       
      
        public Rectangle()
        {
            X1 = 0;
            Y1 = 0;
            Width = 0;
            Height = 0;
            OutlineColor = Color.Black;
            OutlineSize = 2;
            FillColor = Color.Transparent;


        }

        public Rectangle(int x1, int y1, int width, int height, Color outlineColor, int outlineSize, Color fillColor)
        {
            X1 = x1;
            Y1 = y1;
            Width = width;
            Height = height;
            OutlineColor = outlineColor;
            OutlineSize = outlineSize;
            FillColor = fillColor;

        }

        public override void Draw(Graphics g)
        {
            
            Pen pen = new Pen(OutlineColor, OutlineSize);
            g.DrawRectangle(pen, X1, Y1, Width, Height);


         
        }

        public override void Fill(Graphics g)
        {
            SolidBrush brush = new SolidBrush(FillColor);

            g.FillRectangle(brush, X1, Y1, Width, Height);
          
            

        }
            


        

    }

    


}
