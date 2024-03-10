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

        public Form1()
        {
            InitializeComponent();
            
            
        }

        
        private void rightTToolStripMenuItem_Click(object sender, EventArgs e)
        {
          dbDrawing.SelectedTool = SELECTEDTOOL.RIGHTTRIANGLE;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbDrawing.SelectedTool = SELECTEDTOOL.RECTANGLE;
        }

      

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbDrawing.SelectedTool = SELECTEDTOOL.CIRCLE;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbDrawing.SelectedTool = SELECTEDTOOL.LINE;
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbDrawing.SelectedTool = SELECTEDTOOL.TRIANGLE;

        }

        private void pentagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbDrawing.SelectedTool = SELECTEDTOOL.PENTAGON;
        }





        private void pxToolStripMenuItem_Click(object sender, EventArgs e)
        {
           dbDrawing.ChangeOutlineSize(1);

        }

        private void pxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           dbDrawing.ChangeOutlineSize(2);
        }

        private void pxToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dbDrawing.ChangeOutlineSize(3);
        }

        private void pxToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dbDrawing.ChangeOutlineSize(4);
        }

        private void pxToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            dbDrawing.ChangeOutlineSize(5);
        }

      

            
        private void outlineColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dbDrawing.ChangeOutlineColor();

        }

        private void fileColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dbDrawing.ChangeFillColor();
        }

        private void dbDrawing_Load(object sender, EventArgs e)
        {
            
        }

        private void dbDrawing_NotifyShapeCount(int sCount)
        {
            tss.Text = $"Object Count = {sCount}";
        }
    }
}
