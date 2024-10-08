﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registry
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tSButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 4)
            {
                textBox2.Focus();
            }
            if (textBox2.Text.Length == 4)
            {
                textBox3.Focus();
            }
            if (textBox3.Text.Length == 4)
            {
                textBox4.Focus();
            }
        }

        private void tSButtonNext_Click(object sender, EventArgs e)
        {
            
            string Key = textBox1.Text + "-" + textBox2.Text + "-" + textBox3.Text + "-" + textBox4.Text;
            if(Key == "SHVY-3LE9-TMNH-7K5L")
            {
                this.Hide();
                Form3 form3 = new Form3();
                MessageBox.Show("Product Activated");
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Key is not true", "",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
