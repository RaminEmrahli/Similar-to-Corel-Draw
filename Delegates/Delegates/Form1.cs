using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            void SetBtn1BackColor(Color color)
            {
                button1.BackColor = color;
            }
            void SetBtn2BackColor(Color color)
            {
                button2.BackColor = color;
            }
            void SetLabel1Color(Color color)
            {
                label1.ForeColor = color;
            }
            void SetLabel2Color(Color color)
            {
                label2.ForeColor = color;
            }
            Delegates SetColors = new Delegates(SetBtn1BackColor);
            SetColors.AddDelegate(SetBtn2BackColor);
            SetColors.AddDelegate(SetLabel1Color);
            SetColors.AddDelegate(SetLabel2Color);
            SetColors.DeleteDelegate(SetBtn1BackColor);
            SetColors.RunDelegate(Color.Red);
        }
    }
}
