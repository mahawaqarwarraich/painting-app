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
    public delegate void NotifyShapeCount(int sCount);

    public partial class DrawingBoard : UserControl

    {

        public event NotifyShapeCount NotifyShapeCount;
        int X1, Y1, X2, Y2;
        private SELECTEDTOOL selectedTool;

        public SELECTEDTOOL SelectedTool { get; set; } = SELECTEDTOOL.SELECT;
        Color OutlineColor = Color.Black;
        private int outlineSize;

        public int OutlineSize { get; set; } = 2;
        Color FillColor = Color.Transparent;
        bool IsDrawing = false;
        List<Shape> Shapes = new List<Shape>();
      


        Triangle triangle;
        Pentagon pentagon;

        Point TriangleVertex1;
        Point TriangleVertex2;
        Point TriangleVertex3;
        Point TriangleVertex4;
        Point TriangleVertex5;


        public DrawingBoard()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

       // parennt -> user control

        protected override void OnPaint(PaintEventArgs e)
        {
          base.OnPaint(e);
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
                        triangle = new Triangle(TriangleVertex1, TriangleVertex2, TriangleVertex3, OutlineSize, OutlineColor, FillColor);
                        triangle.Draw(e.Graphics);
                        ;
                        break;
                    case SELECTEDTOOL.RIGHTTRIANGLE:
                        triangle = new Triangle(TriangleVertex1, TriangleVertex2, TriangleVertex3, OutlineSize, OutlineColor, FillColor);
                        triangle.Draw(e.Graphics);
                        break;
                    case SELECTEDTOOL.PENTAGON:
                        pentagon = new Pentagon(TriangleVertex1, TriangleVertex2, TriangleVertex3, TriangleVertex4, TriangleVertex5, OutlineSize, OutlineColor, FillColor);
                        pentagon.Draw(e.Graphics);
                        break;

                    case SELECTEDTOOL.SELECT:
                        break;
                    default:
                        break;
                }




            }
        }

       

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

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
                    triangle = new Triangle(TriangleVertex1, TriangleVertex2, TriangleVertex3, OutlineSize, OutlineColor, FillColor);
                    Shapes.Add(triangle);
                    break;

                case SELECTEDTOOL.PENTAGON:
                    pentagon = new Pentagon(TriangleVertex1, TriangleVertex2, TriangleVertex3, TriangleVertex4, TriangleVertex5, OutlineSize, OutlineColor, FillColor);
                    Shapes.Add(pentagon);
                    break;

                case SELECTEDTOOL.SELECT:
                    break;
                default:
                    break;
            }

            if (NotifyShapeCount != null)
            {
                NotifyShapeCount.Invoke(Shapes.Count);
            }


        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
          base.OnMouseMove(e);
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
                        TriangleVertex1 = new Point(X1, Y1);
                        TriangleVertex2 = new Point(X1, Y2);
                        TriangleVertex3 = new Point(X2, Y2);

                        break;
                    case SELECTEDTOOL.PENTAGON:
                        double angle = -Math.PI / 2;
                        int radius = Math.Min(Math.Abs(X2 - X1), Math.Abs(Y2 - Y1)) / 2;

                        TriangleVertex1 = new Point(
                            (int)(X1 + (X2 - X1) / 2 + radius * Math.Cos(angle)),
                            (int)(Y1 + radius * Math.Sin(angle))
                        );

                        angle += 2 * Math.PI / 5;
                        TriangleVertex2 = new Point(
                           (int)(X1 + (X2 - X1) / 2 + radius * Math.Cos(angle)),
                           (int)(Y1 + radius * Math.Sin(angle))
                       );

                        angle += 2 * Math.PI / 5;
                        TriangleVertex3 = new Point(
                           (int)(X1 + (X2 - X1) / 2 + radius * Math.Cos(angle)),
                           (int)(Y1 + radius * Math.Sin(angle))
                       );

                        angle += 2 * Math.PI / 5;
                        TriangleVertex4 = new Point(
                           (int)(X1 + (X2 - X1) / 2 + radius * Math.Cos(angle)),
                           (int)(Y1 + radius * Math.Sin(angle))
                       );

                        angle += 2 * Math.PI / 5;
                        TriangleVertex5 = new Point(
                           (int)(X1 + (X2 - X1) / 2 + radius * Math.Cos(angle)),
                           (int)(Y1 + radius * Math.Sin(angle))
                       );

                        break;

                }

                Invalidate();
            }



        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            IsDrawing = true;
            X1 = e.X;
            Y1 = e.Y;

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

        public void ChangeOutlineColor()
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

        public void ChangeFillColor()
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






    }
}
