using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
namespace Json_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            Graphics canvas = pictureBox1.CreateGraphics();
            Ellipse ellipse = new Ellipse
            {
                X = 100,
                Y = 150,
                Radius1 = 10,
                Radius2 = 20,
            };
            pictureBox1.BackColor = default;
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Red);
            canvas.DrawEllipse(pen, ellipse.X, ellipse.Y, ellipse.Radius1, ellipse.Radius2);
            canvas.FillEllipse(brush, ellipse.X + 300, ellipse.Y, ellipse.Radius1, ellipse.Radius2);

            var options = new JsonSerializerOptions { WriteIndented = true,IncludeFields=true  };
            string classFields = JsonSerializer.Serialize(ellipse);
            richTextBox1.Text = classFields;
            File.WriteAllText("ellips.json", richTextBox1.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor);
            string txt = richTextBox1.Text;
            Ellipse elp = JsonSerializer.Deserialize<Ellipse>(txt);
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Yellow);
            g.DrawEllipse(pen, elp.X, elp.Y, elp.Radius1, elp.Radius2);
            g.FillEllipse(brush, elp.X + 300, elp.Y, elp.Radius1, elp.Radius2);

            //elp.drawEllipse(canvas);
            //elp.fillEllipse(canvas);
            //public void drawEllipse(Graphics graphic)
            //{
            //    float height = radius1;
            //    float width = radius2;
            //    Pen pen = new Pen(Color.Black);
            //    graphic.DrawEllipse(pen, x, y, width, height);
            //}
            //public void fillEllipse(Graphics graphic)
            //{
            //    float height = radius1;
            //    float width = radius2;
            //    float X = x + 300;
            //    float Y = y;
            //    Brush brush = new SolidBrush(Color.Yellow);
            //    graphic.FillEllipse(brush, X, Y, width, height);
            //}
            //public Ellipse(int X, int Y, int r, int R)
            //{
            //    radius1 = r * 10;
            //    radius2 = R * 10;
            //    x = X;
            //    y = Y;
            //}
            //Ellipse ellipse = new Ellipse(100, 150, 10, 20);
            //ellipse.drawEllipse(canvas);
            //ellipse.fillEllipse(canvas);
        }
    }
}
