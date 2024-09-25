using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenanNihat
{
    public partial class TelebeCard : UserControl
    {
        public string img
        {
            get { return pictureBox1.ImageLocation; }
            set { pictureBox1.ImageLocation = value; }
        }
        public string Name
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public TelebeCard()
        {
            InitializeComponent();
        }
    }
}
