using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate double Operation(double v1, double v2);
        Operation op = null; 
        double multiply(double v1,double v2)
        {
            return v1 * v2;
        }
        double divide(double v1,double v2)
        {
            return v1 / v2; 
        }
        double plus(double v1, double v2)
        {
            return v1 + v2;
        }
        double minus(double v1, double v2)
        {
            return v1 - v2;
        }

        private void Calculating(object sender, EventArgs e)
        {
            
            RadioButton radio = sender as RadioButton;
            double v1 = double.Parse(textBox1.Text);
            double v2 = double.Parse(textBox2.Text);
            double result = 0;
            switch (radio.Text)
            {
                case "+":
                    {
                        op=plus;
                    }
                    break;
                case "-":
                    {
                        op = minus;
                    }
                    break;
                case "/":
                    {
                        op = divide;
                    }
                    break;
                case "*":
                    {
                        op = multiply;
                    }
                    break;
            }
            label2.Text = op(v1,v2).ToString();
        }
    }
}
