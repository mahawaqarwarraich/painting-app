using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintPrac
{
    internal abstract class Shape
    {
        public int X1;
        public int Y1;
        public Color OutlineColor;
        public int OutlineSize;
        public Color FillColor;

        public abstract void Draw(Graphics g);
        public abstract void Fill(Graphics g);
      
    }
}
