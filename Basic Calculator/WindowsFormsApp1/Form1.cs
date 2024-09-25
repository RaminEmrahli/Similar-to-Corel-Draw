using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
           
        }
        private bool clearScreen = false;
        private int numberOfSignClicks = 0;
        private int numberOfNumberClicks = 0;
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            numberOfSignClicks = 0;
            numberOfNumberClicks++;
            Button button = (Button)sender;
            if (clearScreen)
            {
                textBox1Screen.Text = "";
                clearScreen = false;
            }
            if (textBox1Screen.Text == "0")
            {
                textBox1Screen.Text = "";
            }
            textBox1Screen.Text += button.Text;
        }
       
        private string sign;
        private double result = 0;
        private void buttonSigns_Click(object sender, EventArgs e)
        {
            numberOfNumberClicks = 0;
            numberOfSignClicks++;
            clearScreen = true;
            Button button = (Button)sender;
            string newSign = button.Text;
            if (numberOfSignClicks == 1)
            {
                label1.Text = label1.Text + textBox1Screen.Text + newSign;
                switch (sign)
                {
                    case "+":
                        {
                            textBox1Screen.Text = (result + double.Parse(textBox1Screen.Text)).ToString();
                        }
                        break;
                    case "-":
                        {
                            textBox1Screen.Text = (result - double.Parse(textBox1Screen.Text)).ToString();
                        }
                        break;
                    case "*":
                        {
                            textBox1Screen.Text = (result * double.Parse(textBox1Screen.Text)).ToString();
                        }
                        break;
                    case "/":
                        {
                            textBox1Screen.Text = (result / double.Parse(textBox1Screen.Text)).ToString();
                        }
                        break;
                }
                result = double.Parse(textBox1Screen.Text);
                textBox1Screen.Text = result.ToString();
                sign = newSign;
            }
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1Screen.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1Screen.Text = "0";
            clearScreen = false;
            label1.Text = "";
            result = 0;
        }

        private int numberOfEqualClicks = 0;
        private void EqualButton_Click(object sender, EventArgs e)
        {
            numberOfEqualClicks++;
            clearScreen = true;
            label1.Text = "";
            switch (sign)
            {
                case "+":
                    {
                        textBox1Screen.Text = (result + double.Parse(textBox1Screen.Text)).ToString();
                    }
                    break;
                case "-":
                    {
                        textBox1Screen.Text = (result - double.Parse(textBox1Screen.Text)).ToString();
                    }
                    break;
                case "*":
                    {
                        textBox1Screen.Text = (result * double.Parse(textBox1Screen.Text)).ToString();
                    }
                    break;
                case "/":
                    {
                        textBox1Screen.Text = (result / double.Parse(textBox1Screen.Text)).ToString();
                    }
                    break;
            }
            result = double.Parse(textBox1Screen.Text);
            textBox1Screen.Text = result.ToString();
            sign = "";
        }
        private void buttonPoint_Click(object sender, EventArgs e)
        {
            clearScreen = false;
            if(numberOfEqualClicks > 0 || numberOfSignClicks > 0)
            {
                textBox1Screen.Text = "0";
            }
            Button button = (Button)sender;
            if (!textBox1Screen.Text.Contains(","))
            {
                textBox1Screen.Text += button.Text;
            }
        }
    }
}
