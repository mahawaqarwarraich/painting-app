using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintPrac
{
    public enum SELECTEDTOOL
    {
        SELECT,
        RECTANGLE,
        CIRCLE,
        LINE,
        TRIANGLE,
        RIGHTTRIANGLE,
        PENTAGON

    }
    public partial class Form1 : Form
    {
        int X1, Y1, X2, Y2;
        SELECTEDTOOL SelectedTool = SELECTEDTOOL.SELECT;
        Color OutlineColor = Color.Black;
        int OutlineSize = 2;
        Color FillColor = Color.Transparent;
        bool IsDrawing = false;
        List<Shape> Shapes = new List<Shape>();
       
        Point TriangleVertex1;
        Point TriangleVertex2;
        Point TriangleVertex3;


        Point RightTriangleVertex1;
        Point RightTriangleVertex2;
        Point RightTriangleVertex3;


        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void rightTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedTool = SELECTEDTOOL.RIGHTTRIANGLE;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedTool = SELECTEDTOOL.RECTANGLE;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedTool = SELECTEDTOOL.CIRCLE;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedTool = SELECTEDTOOL.LINE;
        }
        
        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedTool = SELECTEDTOOL.TRIANGLE;
          
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in Shapes)
            {
               
                shape.Fill(e.Graphics);
                shape.Draw(e.Graphics);
            }

            if (IsDrawing)
            {
              


                switch (SelectedTool)
                {
                    case SELECTEDTOOL.RECTANGLE:

                        /*Rectangle rect = new Rectangle(X1, Y1, X2 - X1, Y2 - Y1, OutlineColor, OutlineSize, FillColor);
                        rect.Draw(e.Graphics);*/
                        Pen pen = new Pen(OutlineColor, OutlineSize);
                        e.Graphics.DrawRectangle(pen, X1, Y1, X2 - X1, Y2 - Y1);

                        break;
                    case SELECTEDTOOL.CIRCLE:
                        Circle circle = new Circle(X1, Y1, X2 - X1, Y2 - Y1, OutlineSize, OutlineColor, FillColor);
                        circle.Draw(e.Graphics);

                        break;
                    case SELECTEDTOOL.LINE:
                        Line line = new Line(X1, Y1, X2, Y2, OutlineSize, OutlineColor);
                        line.Draw(e.Graphics);
                        break;
                    case SELECTEDTOOL.TRIANGLE:
                       Triangle triangle = new Triangle(TriangleVertex1, TriangleVertex2, TriangleVertex3, OutlineSize, OutlineColor, FillColor);
                        triangle.Draw(e.Graphics);
 ;
                        break;
                    case SELECTEDTOOL.RIGHTTRIANGLE:
                        break;
                    case SELECTEDTOOL.PENTAGON:
                        break;
                    case SELECTEDTOOL.SELECT:
                        break;
                    default:
                        break;
                }




            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
           
            IsDrawing = false;
            Invalidate();

            switch (SelectedTool)
            {
                case SELECTEDTOOL.RECTANGLE:

                    Rectangle rect = new Rectangle(X1, Y1, X2 - X1, Y2 - Y1, OutlineColor, OutlineSize, FillColor);

                    Shapes.Add(rect);
                    break;
                case SELECTEDTOOL.CIRCLE:
                    Circle circle = new Circle(X1, Y1, X2 - X1, Y2 - Y1, OutlineSize, OutlineColor, FillColor);

                    Shapes.Add(circle);
                    break;
                case SELECTEDTOOL.LINE:
                    Line line = new Line(X1, Y1, X2, Y2, OutlineSize, OutlineColor);

                    Shapes.Add(line);
                    break;
                case SELECTEDTOOL.TRIANGLE:
                    Triangle triangle = new Triangle(TriangleVertex1, TriangleVertex2, TriangleVertex3, OutlineSize, OutlineColor, FillColor);
                    Shapes.Add(triangle);
                    break;

                   
                case SELECTEDTOOL.RIGHTTRIANGLE:
                    break;
                case SELECTEDTOOL.PENTAGON:
                    break;
                case SELECTEDTOOL.SELECT:
                    break;
                default:
                    break;
            }


        }

        private void pxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeOutlineSize(1);

        }

        private void pxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeOutlineSize(2);
        }

        private void pxToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ChangeOutlineSize(3);
        }

        private void pxToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ChangeOutlineSize(4);
        }

        private void pxToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ChangeOutlineSize(5);
        }

        public void ChangeOutlineSize(int size)
        {
            OutlineSize = size;
            if (Shapes.Any())
            {
                Shape lastShape = Shapes.Last();
                
                lastShape.OutlineSize = size;
                Invalidate();
               
            }
        }

        private void outlineColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (Shapes.Any())
                {
                    Shape lastShape = Shapes.Last();

                    lastShape.OutlineColor = colorDialog.Color;
                    Invalidate();

                }
            }

        }

        private void fileColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (Shapes.Any())
                {
                    Shape lastShape = Shapes.LastOrDefault();

                    lastShape.FillColor = colorDialog.Color;
                    Invalidate();

                }
            }
        }

        private void pentagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedTool = SELECTEDTOOL.PENTAGON;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing)
            {
                X2 = e.X;
                Y2 = e.Y;
                switch (SelectedTool)
                {
                    case SELECTEDTOOL.TRIANGLE:
                        
                        TriangleVertex1 = new Point(X1 + (X2 - X1) / 2, Y1);
                        TriangleVertex2 = new Point(X1, Y2);
                        TriangleVertex3 = new Point(X2, Y2);

                        break;
                    case SELECTEDTOOL.RIGHTTRIANGLE:
                        RightTriangleVertex1 = new Point(X1, Y1);
                        RightTriangleVertex2 = new Point(X1, Y2);
                        RightTriangleVertex3 = new Point(X2, Y2);
                       
                        break;
                    case SELECTEDTOOL.PENTAGON:
                        break;

                }

                Invalidate();
            }
           


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            IsDrawing = true;
            X1 = e.X;
            Y1 = e.Y;

        }

    }
}
