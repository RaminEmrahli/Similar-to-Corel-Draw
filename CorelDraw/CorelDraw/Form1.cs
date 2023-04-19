using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Runtime.CompilerServices;

namespace CorelDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bm);
            graphics.Clear(Color.White);
            pictureBox1.Image = bm;
        }

        Bitmap bm;
        Graphics graphics;
        Point startPoint;
        Point actionPoint;
        Color borderColor;
        Color fillColor = Color.White;
        Pen eraser = new Pen(Color.White, 20);
        Pen pen = new Pen(Color.Black, 1);
        bool isDrawing;
        int x0, y0, deltaX, deltaY;
        int borderWidth;

        private ShapeContainer shapeContainer1;
        private RectangleShape rectangleShape1;
        private RectangleShape rectangleShape2;
        private ShapeContainer shapeContainer2;
        private OvalShape ovalShape1;

        private void tSBtnRectangle_Click(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Cross;
            rectClicked = false;
            txtHeight.Enabled = false;
            txtWidth.Enabled = false;
            txtLocationX.Enabled = false;
            txtLocationY.Enabled = false;
            tSBtnRectangle.Checked = true;
            tSBtnEllipse.Checked = false;
            tSBtnCursor.Checked = false;
            tsBtnEraser.Checked = false;
            tSBtnPen.Checked = false;
        }

        private void tSBtnEllipse_Click(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Cross;
            rectClicked = false;
            txtHeight.Enabled = false;
            txtWidth.Enabled = false;
            txtLocationX.Enabled = false;
            txtLocationY.Enabled = false;
            tSBtnEllipse.Checked = true;
            tSBtnCursor.Checked = false;
            tSBtnRectangle.Checked = false;
            tSBtnPen.Checked = false;
            tsBtnEraser.Checked = false;
        }

        private void tSBtnCursor_Click(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Default;
            tSBtnCursor.Checked = true;
            tSBtnEllipse.Checked = false;
            tSBtnRectangle.Checked = false;
            tsBtnEraser.Checked = false;
            tSBtnPen.Checked = false;
        }

        private void buttonColors_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
        }

        private void tSBtnPen_Click(object sender, EventArgs e)
        {
            rectClicked = false;
            ovalClicked = false;
            txtHeight.Enabled = false;
            txtWidth.Enabled = false;
            txtLocationX.Enabled = false;
            txtLocationY.Enabled = false;
            pictureBox1.Cursor = new Cursor("aero_pen.cur");
            tSBtnPen.Checked = true;
            tSBtnCursor.Checked = false;
            tSBtnEllipse.Checked = false;
            tSBtnRectangle.Checked = false;
            tsBtnEraser.Checked = false;
        }
        private void tsBtnEraser_Click(object sender, EventArgs e)
        {
            rectClicked = false;
            ovalClicked = false;
            txtHeight.Enabled = false;
            txtWidth.Enabled = false;
            txtLocationX.Enabled = false;
            txtLocationY.Enabled = false;
            pictureBox1.Cursor = new Cursor("eraser.cur");
            tsBtnEraser.Checked = true;
            isDrawing = false;
            tSBtnCursor.Checked = false;
            tSBtnEllipse.Checked = false;
            tSBtnRectangle.Checked = false;
            tSBtnPen.Checked = false;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            x0 = e.X;
            y0 = e.Y;

            if (tSBtnPen.Checked)
            {
                isDrawing = true;

            }
            if (tSBtnRectangle.Checked)
            {
                CreateRectangle();

            }
            if (tSBtnEllipse.Checked)
            {
                CreateEllipse();
            }
        }

        private void CreateEllipse()
        {
            shapeContainer2 = new ShapeContainer();
            ovalShape1 = new OvalShape();

            ovalShape1.MouseClick += ovalShape1_MouseClick;
            ovalShape1.MouseDown += ovalShape1_MouseDown;
            ovalShape1.MouseMove += ovalShape1_MouseMove;
            shapeContainer2.Location = new Point(x0, y0);
            shapeContainer2.Margin = new Padding(0);
            shapeContainer2.Shapes.AddRange(new Shape[] {
            ovalShape1});

            ovalShape1.Location = new Point(x0, y0);
            ovalShape1.BorderColor = borderColor;
            ovalShape1.BorderWidth = borderWidth;
            pictureBox1.Controls.Add(shapeContainer2);

            txtLocationX.Text = ovalShape1.Location.X.ToString();
            txtLocationY.Text = ovalShape1.Location.Y.ToString();

            if (checkBoxFill.Checked)
            {
                ovalShape1.FillStyle = FillStyle.Solid;
                ovalShape1.FillColor = fillColor;
            }
        }

        private void CreateRectangle()
        {
            shapeContainer1 = new ShapeContainer();
            rectangleShape1 = new RectangleShape();

            rectangleShape1.MouseClick += rectangleShape1_MouseClick;
            rectangleShape1.MouseMove += rectangleShape1_MouseMove;
            rectangleShape1.MouseDown += rectangleShape1_MouseDown;
            shapeContainer1.Location = new Point(x0, y0);
            shapeContainer1.Margin = new Padding(0);
            shapeContainer1.Shapes.AddRange(new Shape[] {
            rectangleShape1});

            rectangleShape1.Location = new Point(x0, y0);
            rectangleShape1.BorderColor = borderColor;
            rectangleShape1.BorderWidth = borderWidth;

            pictureBox1.Controls.Add(shapeContainer1);

            txtLocationX.Text = rectangleShape1.Location.X.ToString();
            txtLocationY.Text = rectangleShape1.Location.Y.ToString();

            if (checkBoxFill.Checked)
            {
                rectangleShape1.FillStyle = FillStyle.Solid;
                rectangleShape1.FillColor = fillColor;
            }

        }

        private void DrawRectangle(MouseEventArgs e)
        {
            int x1 = Math.Min(x0, e.X);
            int y1 = Math.Min(y0, e.Y);
            rectangleShape1.Location = new Point(x1, y1);
            rectangleShape1.Width = Math.Abs(e.X - x0);
            rectangleShape1.Height = Math.Abs(e.Y - y0);
            txtHeight.Text = rectangleShape1.Height.ToString();
            txtWidth.Text = rectangleShape1.Width.ToString();
        }
        private void DrawEllipse(MouseEventArgs e)
        {
            int x1 = Math.Min(x0, e.X);
            int y1 = Math.Min(y0, e.Y);
            ovalShape1.Location = new Point(x1, y1);
            ovalShape1.Width = Math.Abs(e.X - x0);
            ovalShape1.Height = Math.Abs(e.Y - y0);
            txtHeight.Text = ovalShape1.Height.ToString();
            txtWidth.Text = ovalShape1.Width.ToString();
        }
        private void tSBtnPen_MouseEnter(object sender, EventArgs e)
        {
            toolStrip1.Cursor = Cursors.Hand;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (tSBtnPen.Checked)
            {
                pictureBox1.Cursor = new Cursor("aero_pen.cur");
            }
            comboBoxWidth.SelectedIndex = 0;
        }
        private void pctrBoxEditColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            pen.Color = dlg.Color;
            borderColor = dlg.Color;
        }

        private void comboBoxWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBoxWidth.Text.Remove(comboBoxWidth.Text.Length - 5, 5);
            borderWidth = int.Parse(s);
            pen.Width = borderWidth;
        }

        bool cursorNWSE1;
        bool cursorNWSE2;
        bool cursorNESW1;
        bool cursorNESW2;
        bool cursorWE1;
        bool cursorWE2;
        bool cursorNS1;
        bool cursorNS2;
        bool cursorAll;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rectClicked)
            {
                FindCursorType(e);
                MoveShapeAccordingToTheCursor(e);
            }
            if (isDrawing)
            {
                DrawLine(e);
            }
            if (tsBtnEraser.Checked && e.Button == MouseButtons.Left)
            {
                Erase(e);
            }
            if (tSBtnRectangle.Checked && e.Button == MouseButtons.Left)
            {
                DrawRectangle(e);
            }
            if (tSBtnEllipse.Checked && e.Button == MouseButtons.Left)
            {
                DrawEllipse(e);
            }
        }

        private void MoveShapeAccordingToTheCursor(MouseEventArgs e)
        {
            if (cursorNWSE1)
            {
                moveRectangleToRightDown(e);
            }
            if (cursorNWSE2)
            {
                moveRectangleToLeftTop(e);
            }
            if (cursorWE1)
            {
                moveRectangleToRight(e);
            }
            if (cursorWE2)
            {
                moveRectangleToLeft(e);
            }
            if (cursorNESW1)
            {
                moveRectangleToRightTop(e);
            }
            if (cursorNESW2)
            {
                moveRectangleToLeftBottom(e);
            }
            if (cursorNS1)
            {
                moveRectangleToBottom(e);
            }
            if (cursorNS2)
            {
                moveRectangleToTop(e);
            }
            if (!cursorNWSE1 && !cursorNWSE2 && !cursorWE1 && !cursorWE2 && !cursorNESW1 && !cursorNESW2 && !cursorNS1 && !cursorNS2)
            {
                pictureBox1.Cursor = Cursors.Default;
            }
        }

        private void FindCursorType(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None)
            {
                bool x1 = e.X < rectShape.Width + rectShape.Location.X + 15 && e.X > rectShape.Width + rectShape.Location.X;
                bool y1 = e.Y < rectShape.Height + rectShape.Location.Y + 15 && e.Y > rectShape.Height + rectShape.Location.Y;
                cursorNWSE1 = x1 && y1;

                bool x2 = e.X > rectShape.Width + rectShape.Location.X - 5 && e.X < rectShape.Location.X + rectShape.Width + 10;
                bool y2 = e.Y < rectShape.Height + rectShape.Location.Y && e.Y > rectShape.Location.Y;
                cursorWE1 = x2 && y2;

                bool x3 = e.X < rectShape.Location.X + 5 && e.X > rectShape.Location.X - 10;
                bool y3 = e.Y < rectShape.Height + rectShape.Location.Y && e.Y > rectShape.Location.Y;
                cursorWE2 = x3 && y3;

                bool x4 = e.X < rectShape.Width + rectShape.Location.X + 15 && e.X > rectShape.Width + rectShape.Location.X;
                bool y4 = e.Y < rectShape.Location.Y && e.Y > rectShape.Location.Y - 15;
                cursorNESW1 = x4 && y4;

                bool x5 = e.X < rectShape.Width + rectShape.Location.X && e.X > rectShape.Location.X;
                bool y5 = e.Y < rectShape.Location.Y + rectShape.Height + 10 && e.Y > rectShape.Location.Y + rectShape.Height;
                cursorNS1 = x5 && y5;

                bool x6 = e.X < rectShape.Width + rectShape.Location.X && e.X > rectShape.Location.X;
                bool y6 = e.Y < rectShape.Location.Y + 5 && e.Y > rectShape.Location.Y - 10;
                cursorNS2 = x6 && y6;

                bool x7 = e.X < rectShape.Location.X + 5 && e.X > rectShape.Location.X - 10;
                bool y7 = e.Y < rectShape.Location.Y + 5 && e.Y > rectShape.Location.Y - 10;
                cursorNWSE2 = x7 && y7;

                bool x8 = e.X < rectShape.Location.X + 5 && e.X > rectShape.Location.X - 10;
                bool y8 = e.Y < rectShape.Location.Y + rectShape.Height + 10 && e.Y > rectShape.Location.Y + rectShape.Height;
                cursorNESW2 = x8 && y8;

            }
        }

        private void DrawLine(MouseEventArgs e)
        {
            actionPoint = e.Location;
            graphics.DrawLine(pen, actionPoint, startPoint);
            startPoint = actionPoint;
            pictureBox1.Refresh();
        }
        private void Erase(MouseEventArgs e)
        {
            actionPoint = e.Location;
            graphics.DrawLine(eraser, actionPoint, startPoint);
            startPoint = actionPoint;
            pictureBox1.Refresh();
        }

        #region moveMethods
        private void moveRectangleToRightDown(MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.SizeNWSE;
            if (e.Button == MouseButtons.Left)
            {
                deltaX = e.X - x0;
                deltaY = e.Y - y0;
                rectShape.Width = rectShape.Width + deltaX;
                rectShape.Height = rectShape.Height + deltaY;
                x0 = e.X;
                y0 = e.Y;
                txtWidth.Text = rectShape.Width.ToString();
                txtHeight.Text = rectShape.Height.ToString();
            }
        }
        private void moveRectangleToRight(MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.SizeWE;
            if (e.Button == MouseButtons.Left)
            {
                deltaX = e.X - x0;
                rectShape.Width = rectShape.Width + deltaX;
                x0 = e.X;
                txtWidth.Text = rectShape.Width.ToString();
            }
        }

        private void moveRectangleToLeft(MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.SizeWE;
            if (e.Button == MouseButtons.Left)
            {
                deltaX = e.X - x0;
                if (rectShape.Width > 5)
                {
                    rectShape.Location = new Point(rectShape.Location.X + deltaX, rectShape.Location.Y);
                }
                rectShape.Width = rectShape.Width - deltaX;
                x0 = e.X;
                txtLocationX.Text = rectShape.Location.X.ToString();
                txtWidth.Text = rectShape.Width.ToString();
            }
        }

        private void moveRectangleToRightTop(MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.SizeNESW;
            if (e.Button == MouseButtons.Left)
            {
                deltaX = e.X - x0;
                deltaY = e.Y - y0;
                if(rectShape.Width > 5)
                {
                    rectShape.Location = new Point(rectShape.Location.X, rectShape.Location.Y + deltaY);
                }
                rectShape.Width = rectShape.Width + deltaX;
                rectShape.Height = rectShape.Height - deltaY;
                x0 = e.X;
                y0 = e.Y;
                txtLocationY.Text = rectShape.Location.Y.ToString();
                txtWidth.Text = rectShape.Width.ToString();
                txtWidth.Text = rectShape.Width.ToString();
            }
        }
        private void moveRectangleToBottom(MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.SizeNS;
            if (e.Button == MouseButtons.Left)
            {
                deltaY = e.Y - y0;
                rectShape.Height = rectShape.Height + deltaY;
                y0 = e.Y;
                txtHeight.Text = rectShape.Height.ToString();
            }
        }
        private void moveRectangleToTop(MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.SizeNS;
            if (e.Button == MouseButtons.Left)
            {
                deltaY = e.Y - y0;
                if (rectShape.Width > 5)
                {
                    rectShape.Location = new Point(rectShape.Location.X, rectShape.Location.Y + deltaY);
                }
                rectShape.Height = rectShape.Height - deltaY;
                y0 = e.Y;
                txtLocationY.Text = rectShape.Location.Y.ToString();
                txtHeight.Text = rectShape.Height.ToString();
            }
        }
        private void moveRectangleToLeftTop(MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.SizeNWSE;
            if (e.Button == MouseButtons.Left)
            {
                deltaX = e.X - x0;
                deltaY = e.Y - y0;
                if (rectShape.Width > 5) 
                {
                    rectShape.Location = new Point(rectShape.Location.X + deltaX, rectShape.Location.Y + deltaY);
                }
                rectShape.Width = rectShape.Width - deltaX;
                rectShape.Height= rectShape.Height - deltaY;
                y0 = e.Y;
                x0 = e.X;
                txtLocationX.Text = rectShape.Location.X.ToString();
                txtLocationY.Text = rectShape.Location.Y.ToString();
                txtWidth.Text = rectShape.Width.ToString();
                txtHeight.Text= rectShape.Height.ToString();
            }
        }
        private void moveRectangleToLeftBottom(MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.SizeNESW;
            if (e.Button == MouseButtons.Left)
            {
                deltaX = e.X - x0;
                deltaY = e.Y - y0;
                if (rectShape.Width > 5)
                {
                    rectShape.Location = new Point(rectShape.Location.X + deltaX, rectShape.Location.Y);
                }
                rectShape.Width = rectShape.Width - deltaX;
                rectShape.Height = rectShape.Height + deltaY;
                x0 = e.X;
                y0 = e.Y;
                txtLocationX.Text = rectShape.Location.X.ToString();
                txtWidth.Text = rectShape.Width.ToString();
                txtHeight.Text = rectShape.Height.ToString();
            }
        }
        private void moveAllShape(MouseEventArgs e, SimpleShape shape)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point temp = Control.MousePosition;
                deltaX = temp.X - firstpoint.X;
                deltaY = temp.Y - firstpoint.Y;
                shape.Location = new Point(shape.Location.X + deltaX, shape.Location.Y + deltaY);
                firstpoint = temp;
                txtLocationX.Text = shape.Location.X.ToString();
                txtLocationY.Text = shape.Location.Y.ToString();
            }
        }
        #endregion
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        bool keyPressed = false;
        private void txtLocationX_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressed = true;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        bool isFillClicked;
        private void btnFillColor_Click(object sender, EventArgs e)
        {
            isFillClicked = true;
            isBorderClicked = false;
        }

        bool isBorderClicked;
        private void btnBorderColor_Click(object sender, EventArgs e)
        {
            isBorderClicked = true;
            isFillClicked = false;
        }

        private void pictureBoxFill_Click(object sender, EventArgs e)
        {
            checkBoxFill.Checked = true;
            checkBoxNoFill.Checked = false;
        }

        private void pictureBoxNoFill_Click(object sender, EventArgs e)
        {
            checkBoxNoFill.Checked = true;
            checkBoxFill.Checked = false;
        }

        private void checkBoxFill_Click(object sender, EventArgs e)
        {
            checkBoxFill.Checked = true;
            checkBoxNoFill.Checked = false;
        }

        private void checkBoxNoFill_Click(object sender, EventArgs e)
        {
            checkBoxNoFill.Checked = true;
            checkBoxFill.Checked = false;
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if (rectClicked && txtHeight.Text != "" && keyPressed)
            {
                rectShape.Height = int.Parse(txtHeight.Text);
            }

            if (ovalClicked && txtHeight.Text != "" && keyPressed)
            {
                ovalShape.Height = int.Parse(txtHeight.Text);
            }
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            if (rectClicked && txtWidth.Text != "" && keyPressed)
            {
                rectShape.Width = int.Parse(txtWidth.Text);
            }

            if (ovalClicked && txtWidth.Text != "" && keyPressed)
            {
                ovalShape.Width = int.Parse(txtWidth.Text);
            }
        }

        private void txtLocationX_TextChanged(object sender, EventArgs e)
        {
            if (rectClicked && txtLocationX.Text != "" && txtLocationY.Text != "" && keyPressed)
            {
                rectShape.Location = new Point(int.Parse(txtLocationX.Text), int.Parse(txtLocationY.Text));
            }
            if (ovalClicked && txtLocationX.Text != "" && txtLocationY.Text != "" && keyPressed)
            {
                ovalShape.Location = new Point(int.Parse(txtLocationX.Text), int.Parse(txtLocationY.Text));
            }
        }

        private void tsButtonColor_Click(object sender, EventArgs e)
        {
            ToolStripButton btnColor = (ToolStripButton)sender;
            if (isFillClicked)
            {
                btnFillColor.BackColor = btnColor.BackColor;
                fillColor = btnFillColor.BackColor;

            }
            if (isBorderClicked)
            {
                btnBorderColor.BackColor = btnColor.BackColor;
                pen.Color = btnBorderColor.BackColor;
                borderColor = btnBorderColor.BackColor;
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            if (isFillClicked)
            {
                btnFillColor.BackColor = dlg.Color;
                fillColor = btnFillColor.BackColor;

            }
            if (isBorderClicked)
            {
                btnBorderColor.BackColor = dlg.Color;
                pen.Color = btnBorderColor.BackColor;
                borderColor = btnBorderColor.BackColor;
            }
        }

        private void toolStripColors_MouseEnter(object sender, EventArgs e)
        {
            toolStripColors.Cursor = Cursors.Hand;
        }

        private void tsButtonPalette_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            if (isFillClicked)
            {
                btnFillColor.BackColor = dlg.Color;
                fillColor = btnFillColor.BackColor;

            }
            if (isBorderClicked)
            {
                btnBorderColor.BackColor = dlg.Color;
                pen.Color = btnBorderColor.BackColor;
                borderColor = btnBorderColor.BackColor;
            }
        }

        private void toolStripColors_MouseEnter_1(object sender, EventArgs e)
        {
            toolStripColors.Cursor = Cursors.Hand;
        }

        private void PickedColor_Click(object sender, EventArgs e)
        {
            ToolStripButton btnColor = (ToolStripButton)sender;
            if (isFillClicked)
            {
                btnFillColor.BackColor = btnColor.BackColor;
                fillColor = btnFillColor.BackColor;

            }
            if (isBorderClicked)
            {
                btnBorderColor.BackColor = btnColor.BackColor;
                pen.Color = btnBorderColor.BackColor;
                borderColor = btnBorderColor.BackColor;
            }
        }

        List<SimpleShape> shapeList = new List<SimpleShape>();
        RectangleShape rectShape;
        bool rectClicked = false;
        private void rectangleShape1_MouseClick(object sender, EventArgs e)
        {
            if (tSBtnCursor.Checked)
            {
                rectShape = (RectangleShape)sender;
                shapeList.Clear();
                shapeList.Add(rectShape);
                keyPressed = false;
                rectClicked = true;
                ovalClicked = false;
                txtHeight.Enabled = true;
                txtWidth.Enabled = true;
                txtLocationX.Enabled = true;
                txtLocationY.Enabled = true;
                txtHeight.Text = rectShape.Height.ToString();
                txtWidth.Text = rectShape.Width.ToString();
                txtLocationX.Text = rectShape.Location.X.ToString();
                txtLocationY.Text = rectShape.Location.Y.ToString();
            }
        }
        OvalShape ovalShape;
        bool ovalClicked = false;
        
        private void ovalShape1_MouseClick(object sender, EventArgs e)
        {
            if (tSBtnCursor.Checked)
            {
                ovalShape = (OvalShape)sender;
                shapeList.Clear();
                shapeList.Add(ovalShape);
                keyPressed = false;
                rectClicked = false;
                ovalClicked = true;
                txtHeight.Enabled = true;
                txtWidth.Enabled = true;
                txtLocationY.Enabled = true;
                txtLocationX.Enabled = true;
                txtHeight.Text = ovalShape.Height.ToString();
                txtWidth.Text = ovalShape.Width.ToString();
                txtLocationX.Text = ovalShape.Location.X.ToString();
                txtLocationY.Text = ovalShape.Location.Y.ToString();

                //rectangleShape2 = new RectangleShape();
                //rectangleShape2.Location = ovalShape.Location;
                //rectangleShape2.Width = ovalShape.Width;
                //rectangleShape2.Height = ovalShape.Height;
                //shapeContainer2.Shapes.AddRange(new Shape[] {
                //rectangleShape2});
                //rectangleShape2.BorderColor = Color.Black;
                //rectangleShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                
                

            }
        }
        Point firstpoint = new Point();
        private void rectangleShape1_MouseDown(object sender, MouseEventArgs e)
        {
            firstpoint = Control.MousePosition;
        }
        private void rectangleShape1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rectClicked)
            {
                pictureBox1.Cursor = Cursors.SizeAll;
                moveAllShape(e,shapeList.First());
            }

        }
        private void ovalShape1_MouseDown(object sender, MouseEventArgs e)
        {
            firstpoint = Control.MousePosition;
        }
        private void ovalShape1_MouseMove(object sender,MouseEventArgs e)
        {
            if (ovalClicked)
            {
                pictureBox1.Cursor = Cursors.SizeAll;
                moveAllShape(e,shapeList.First());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shapeContainer1.Refresh();
            //shapeContainer2.Refresh();
        }
    }
}
