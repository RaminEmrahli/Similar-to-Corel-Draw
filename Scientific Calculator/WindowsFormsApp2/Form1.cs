using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        // Standart Calculator started

        private bool clearScreen = false;
        private int numberOfSignClicks = 0;
        private int numberOfNumberClicks = 0;
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            numberOfEqualClicks = 0;
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
            if (numberOfEqualClicks > 0)
            {
                label1.Text = " ";
            }
            numberOfEqualClicks = 0;
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
            panel2 = label1.Text;
            textBox1Screen.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            panel2 = label1.Text;
            textBox1Screen.Text = "0";
            clearScreen = false;
            label1.Text = "";
            result = 0;
        }

        private int numberOfEqualClicks = 0;
        private string panel2;
        private void EqualButton_Click(object sender, EventArgs e)
        {
            numberOfPointClicks = 0;
            string temp = textBox1Screen.Text;
            numberOfEqualClicks++;
            clearScreen = true;
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
            if (numberOfEqualClicks == 1)
            {
                label1.Text = label1.Text + "" + temp + "=" + result.ToString();
            }
            textBox1Screen.Text = result.ToString();
            sign = "";
            if (numberOfEqualClicks > 0)
            {
                textBoxHistory.Text += label1.Text + ("\r\n");
            }
        }
        private int numberOfPointClicks = 0;
        private void buttonPoint_Click(object sender, EventArgs e)
        {
            numberOfPointClicks++;
            if (numberOfPointClicks == 1)
            {
                label1.Text = "";
            }
            clearScreen = false;
            if (numberOfEqualClicks > 0 || numberOfSignClicks > 0)
            {
                textBox1Screen.Text = "0";
            }
            Button button = (Button)sender;
            if (!textBox1Screen.Text.Contains(","))
            {
                textBox1Screen.Text += button.Text;
            }
        }

        private void buttonDeleteHistory_Click(object sender, EventArgs e)
        {
            textBoxHistory.Text = "";
        }

        // Standart Calculator finished


        //Scientific Calculator started

        private bool s_clearScreen = false;
        private int s_numberOfSignClicks = 0;
        private int s_numberOfNumberClicks = 0;
        private void ButtonSNumbers_Click(object sender, EventArgs e)
        {
            s_numberOfEqualClicks = 0;
            s_numberOfSignClicks = 0;
            s_numberOfNumberClicks++;
            Button button = (Button)sender;
            if (s_clearScreen)
            {
                textBox2Screen.Text = "";
                s_clearScreen = false;
            }
            if (textBox2Screen.Text == "0")
            {
                textBox2Screen.Text = "";
            }
            textBox2Screen.Text += button.Text;
        }

        private string s_sign = "";
        private double s_result = 0;

        private void ButtonS_Signs_Click(object sender, EventArgs e)
        {
            if (s_numberOfEqualClicks > 0)
            {
                label2.Text = " ";
            }
            s_numberOfEqualClicks = 0;
            s_numberOfNumberClicks = 0;
            s_numberOfSignClicks++;
            s_clearScreen = true;
            Button button = (Button)sender;
            string s_newSign = button.Text;
            if (s_numberOfSignClicks == 1)
            {

                label2.Text = label2.Text + textBox2Screen.Text + s_newSign;
                switch (s_sign)
                {
                    case "+":
                        {
                            textBox2Screen.Text = (s_result + double.Parse(textBox2Screen.Text)).ToString();
                        }
                        break;
                    case "-":
                        {
                            textBox2Screen.Text = (s_result - double.Parse(textBox2Screen.Text)).ToString();
                        }
                        break;
                    case "*":
                        {
                            textBox2Screen.Text = (s_result * double.Parse(textBox2Screen.Text)).ToString();
                        }
                        break;
                    case "/":
                        {
                            textBox2Screen.Text = (s_result / double.Parse(textBox2Screen.Text)).ToString();
                        }
                        break;
                }
                s_result = double.Parse(textBox2Screen.Text);
                textBox2Screen.Text = s_result.ToString();
                s_sign = s_newSign;
            }
        }
        private void ButtonS_C_Click(object sender, EventArgs e)
        {
            s_panel2 = label2.Text;
            textBox2Screen.Text = "0";
            s_clearScreen = false;
            label2.Text = "";
            s_result = 0;
        }

        private void ButtonS_CE_Click(object sender, EventArgs e)
        {
            s_panel2 = label2.Text;
            textBox2Screen.Text = "0";
        }

        private int s_numberOfEqualClicks = 0;
        private string s_panel2;

        private void ButtonS_Equal_Click(object sender, EventArgs e)
        {
            s_numberOfNumberClicks = 0;
            s_numberOfPointClicks = 0;
            string temp = textBox2Screen.Text;
            s_numberOfEqualClicks++;
            s_clearScreen = true;
            switch (s_sign)
            {
                case "+":
                    {
                        textBox2Screen.Text = (s_result + double.Parse(textBox2Screen.Text)).ToString();
                    }
                    break;
                case "-":
                    {
                        textBox2Screen.Text = (s_result - double.Parse(textBox2Screen.Text)).ToString();
                    }
                    break;
                case "*":
                    {
                        textBox2Screen.Text = (s_result * double.Parse(textBox2Screen.Text)).ToString();
                    }
                    break;
                case "/":
                    {
                        textBox2Screen.Text = (s_result / double.Parse(textBox2Screen.Text)).ToString();
                    }
                    break;
            }
            s_result = double.Parse(textBox2Screen.Text);
            if (s_numberOfEqualClicks == 1)
            {
                label2.Text = label2.Text + "" + temp + "=" + s_result.ToString();
            }
            textBox2Screen.Text = s_result.ToString();
            s_sign = "";
            if (s_numberOfEqualClicks > 0)
            {
                textBoxHistory1.Text += label2.Text + ("\r\n");
            }
        }

        private int s_numberOfPointClicks = 0;
        private void ButtonS_Point_Click(object sender, EventArgs e)
        {
            s_numberOfPointClicks++;
            if (s_numberOfPointClicks == 1)
            {
                label2.Text = "";
            }
            s_clearScreen = false;
            if (s_numberOfEqualClicks > 0 || s_numberOfSignClicks > 0)
            {
                textBox2Screen.Text = "0";
            }
            Button button = (Button)sender;
            if (!textBox2Screen.Text.Contains(","))
            {
                textBox2Screen.Text += button.Text;
            }
        }

        private void ScientificButtons(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string s_newSign = btn.Text;
            switch (s_newSign)
            {
                case "sqrt":
                    {
                        textBox2Screen.Text = Math.Sqrt(double.Parse(textBox2Screen.Text)).ToString();

                    }
                    break;
                case "1/x":
                    {
                        textBox2Screen.Text = (1 / double.Parse(textBox2Screen.Text)).ToString();

                    }
                    break;
                case "+/_":
                    {
                        if (double.Parse(textBox2Screen.Text) > 0)
                        {
                            textBox2Screen.Text = ((-1) * double.Parse(textBox2Screen.Text)).ToString();
                        }
                        else
                        {
                            textBox2Screen.Text = (1 * double.Parse(textBox2Screen.Text)).ToString();
                        }
                    }
                    break;
            }
        }

        private void buttonS_Delete_History(object sender, EventArgs e)
        {
            textBoxHistory1.Text = "";
        }

        private void ButtonS_Percent_Click(object sender, EventArgs e)
        {
            if (s_sign == "")
            {
                textBox2Screen.Text = "0";
            }
            switch (s_sign)
            {
                case "+":
                    {
                        textBox2Screen.Text = (s_result * (double.Parse(textBox2Screen.Text) / 100)).ToString();
                    }
                    break;
                case "-":
                    {
                        textBox2Screen.Text = (s_result * (double.Parse(textBox2Screen.Text) / 100)).ToString();
                    }
                    break;
                case "/":
                    {
                        textBox2Screen.Text = ((double.Parse(textBox2Screen.Text) / 100)).ToString();
                    }
                    break;
                case "*":
                    {
                        textBox2Screen.Text = ((double.Parse(textBox2Screen.Text) / 100)).ToString();
                    }
                    break;
            }
        }

        private void buttonS_Delete_Click(object sender, EventArgs e)
        {
            if (s_numberOfNumberClicks > 0)
            {
                textBox2Screen.Text = textBox2Screen.Text.Substring(0, textBox2Screen.Text.Length - 1);
                if (textBox2Screen.Text == "")
                {
                    textBox2Screen.Text = "0";
                }
            }
            if (s_numberOfEqualClicks > 0)
            {
                label2.Text = "";
                numberOfEqualClicks = 0;
            }
        }

        private double memory = 0;
        private void M_Buttons_Click(object sender, EventArgs e)
        {
            s_clearScreen = true;
            Button btn = (Button)sender;
            string M_sign=btn.Text;
            switch (M_sign)
            {
                case "MC":
                    {
                        memory = 0;
                    }
                    break;
                case "MR":
                    {
                        textBox2Screen.Text = memory.ToString();
                        if (memory == 0)
                        {
                            textBox2Screen.Text = textBox2Screen.Text;
                        }
                    }
                    break;
                case "M+":
                    {
                        memory += double.Parse(textBox2Screen.Text);
                    }
                    break;
                case "M-":
                    {
                        memory += (double.Parse(textBox2Screen.Text)*(-1));
                    }
                    break;
                case "MS":
                    {
                        memory = double.Parse(textBox2Screen.Text);
                    }
                    break;
            }
        }
        int temp = 0;
        private void buttonHistory_Click(object sender, EventArgs e)
        {
            temp = splitContainer1.SplitterDistance;

            splitContainer1.Panel1.Hide();
            splitContainer1.Panel2.Show();
            splitContainer1.SplitterDistance = 0;
        }
    }
}

