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

namespace figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool flagCursor = false;
        bool inside = false;
        private void rectangleShape1_MouseEnter(object sender, EventArgs e)
        {
            inside = true;
        }

        private void rectangleShape1_MouseLeave(object sender, EventArgs e)
        {
            inside = false;
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            focusedName = rectangleShape1.Name;
            if (rectangleShape1.Focus())
            {
                label2.Text = "salam";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = rectangleShape1.Location.Y.ToString() + " " + rectangleShape1.Height.ToString();
        }

        string focusedName = "";
        int deltaX,deltaY;
        bool cursorChange;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            bool xIf = e.X < rectangleShape1.Width + rectangleShape1.Location.X + 15 && e.X > rectangleShape1.Width + rectangleShape1.Location.X;
            bool yIf = e.Y < rectangleShape1.Height +rectangleShape1.Location.Y + 15 && e.Y > rectangleShape1.Height+rectangleShape1.Location.Y;
            cursorChange = xIf && yIf;

            if (focusedName == rectangleShape1.Name)
            {
                if (cursorChange)
                {
                    this.Cursor = Cursors.SizeNWSE;
                }
                if (e.Button == MouseButtons.Left && this.Cursor == Cursors.SizeNWSE)
                {
                    //this.Cursor = Cursors.SizeNWSE;
                    deltaX = e.X - x0;
                    deltaY = e.Y - y0;
                    rectangleShape1.Width = rectangleShape1.Width + deltaX;
                    rectangleShape1.Height = rectangleShape1.Height + deltaY;
                    x0 = e.X;
                    y0 = e.Y;
                }
                if (e.Button == MouseButtons.None && cursorChange == false)
                {
                    this.Cursor = Cursors.Default;
                }
            }
            label1.Text = e.X.ToString() + " " + e.Y.ToString();
        }

      

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //cursorChange = false;
            //this.Cursor = Cursors.Default;
        }

        //first coordinates
        int x0, y0;

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            // Get the DisplayRectangle for each OvalShape.
            Rectangle rect1 = ovalShape1.DisplayRectangle;
            Rectangle rect2 = ovalShape2.DisplayRectangle;
            // If the DisplayRectangles intersect, move OvalShape2.
            if (rect1.IntersectsWith(rect2))
            {
                ovalShape2.SetBounds(rect1.Right, rect1.Bottom, rect2.Width, rect2.Height);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
                x0 = e.X;
                y0 = e.Y;
            
        }
    }
}
