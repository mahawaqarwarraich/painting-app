namespace PaintPrac
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentagonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.outlineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tss = new System.Windows.Forms.ToolStripStatusLabel();
            this.dbDrawing = new PaintPrac.DrawingBoard();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shapesToolStripMenuItem,
            this.sizeToolStripMenuItem,
            this.outlineColorToolStripMenuItem,
            this.fileColorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.triangleToolStripMenuItem,
            this.pentagonToolStripMenuItem,
            this.rightTToolStripMenuItem});
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.shapesToolStripMenuItem.Text = "Shapes";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
            // 
            // pentagonToolStripMenuItem
            // 
            this.pentagonToolStripMenuItem.Name = "pentagonToolStripMenuItem";
            this.pentagonToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pentagonToolStripMenuItem.Text = "Pentagon";
            this.pentagonToolStripMenuItem.Click += new System.EventHandler(this.pentagonToolStripMenuItem_Click);
            // 
            // rightTToolStripMenuItem
            // 
            this.rightTToolStripMenuItem.Name = "rightTToolStripMenuItem";
            this.rightTToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.rightTToolStripMenuItem.Text = "Right triangle";
            this.rightTToolStripMenuItem.Click += new System.EventHandler(this.rightTToolStripMenuItem_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pxToolStripMenuItem,
            this.pxToolStripMenuItem1,
            this.pxToolStripMenuItem2,
            this.pxToolStripMenuItem3,
            this.pxToolStripMenuItem4});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // pxToolStripMenuItem
            // 
            this.pxToolStripMenuItem.Name = "pxToolStripMenuItem";
            this.pxToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pxToolStripMenuItem.Text = "1px";
            this.pxToolStripMenuItem.Click += new System.EventHandler(this.pxToolStripMenuItem_Click);
            // 
            // pxToolStripMenuItem1
            // 
            this.pxToolStripMenuItem1.Name = "pxToolStripMenuItem1";
            this.pxToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.pxToolStripMenuItem1.Text = "2px";
            this.pxToolStripMenuItem1.Click += new System.EventHandler(this.pxToolStripMenuItem1_Click);
            // 
            // pxToolStripMenuItem2
            // 
            this.pxToolStripMenuItem2.Name = "pxToolStripMenuItem2";
            this.pxToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.pxToolStripMenuItem2.Text = "3px";
            this.pxToolStripMenuItem2.Click += new System.EventHandler(this.pxToolStripMenuItem2_Click);
            // 
            // pxToolStripMenuItem3
            // 
            this.pxToolStripMenuItem3.Name = "pxToolStripMenuItem3";
            this.pxToolStripMenuItem3.Size = new System.Drawing.Size(270, 34);
            this.pxToolStripMenuItem3.Text = "4px";
            this.pxToolStripMenuItem3.Click += new System.EventHandler(this.pxToolStripMenuItem3_Click);
            // 
            // pxToolStripMenuItem4
            // 
            this.pxToolStripMenuItem4.Name = "pxToolStripMenuItem4";
            this.pxToolStripMenuItem4.Size = new System.Drawing.Size(270, 34);
            this.pxToolStripMenuItem4.Text = "5px";
            this.pxToolStripMenuItem4.Click += new System.EventHandler(this.pxToolStripMenuItem4_Click);
            // 
            // outlineColorToolStripMenuItem
            // 
            this.outlineColorToolStripMenuItem.Name = "outlineColorToolStripMenuItem";
            this.outlineColorToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.outlineColorToolStripMenuItem.Text = "Outline Color";
            this.outlineColorToolStripMenuItem.Click += new System.EventHandler(this.outlineColorToolStripMenuItem_Click_1);
            // 
            // fileColorToolStripMenuItem
            // 
            this.fileColorToolStripMenuItem.Name = "fileColorToolStripMenuItem";
            this.fileColorToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.fileColorToolStripMenuItem.Text = "Fill Color";
            this.fileColorToolStripMenuItem.Click += new System.EventHandler(this.fileColorToolStripMenuItem_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(858, 32);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip";
            // 
            // tss
            // 
            this.tss.Name = "tss";
            this.tss.Size = new System.Drawing.Size(149, 25);
            this.tss.Text = "Object Count = 0";
            // 
            // dbDrawing
            // 
            this.dbDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbDrawing.Location = new System.Drawing.Point(0, 36);
            this.dbDrawing.Name = "dbDrawing";
            this.dbDrawing.OutlineSize = 2;
            this.dbDrawing.SelectedTool = PaintPrac.SELECTEDTOOL.SELECT;
            this.dbDrawing.Size = new System.Drawing.Size(858, 485);
            this.dbDrawing.TabIndex = 1;
            this.dbDrawing.UseWaitCursor = true;
            this.dbDrawing.NotifyShapeCount += new PaintPrac.NotifyShapeCount(this.dbDrawing_NotifyShapeCount);
            this.dbDrawing.Load += new System.EventHandler(this.dbDrawing_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 521);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dbDrawing);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pentagonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem outlineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileColorToolStripMenuItem;
        private DrawingBoard dbDrawing;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tss;
    }
}

