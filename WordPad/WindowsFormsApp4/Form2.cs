using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime time = new DateTime();
            listBoxDateTime.Items.Add(DateTime.Now.ToString("d"));
            listBoxDateTime.Items.Add(DateTime.Now.ToString("D").Substring(0, 12).Remove(5,2));
            listBoxDateTime.Items.Add(DateTime.Now.ToString("D"));
            listBoxDateTime.Items.Add(DateTime.Now.ToString("D").Substring(0, 12));
            listBoxDateTime.Items.Add(DateTime.Now.ToString("T"));
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            
            WordPad form = WordPad.MainForm;
            RichTextBox rbDocument = (RichTextBox)form.Controls["rbDocument"];
            rbDocument.Text += listBoxDateTime.SelectedItem.ToString();
        }
    }
}
