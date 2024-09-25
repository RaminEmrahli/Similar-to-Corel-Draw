using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Registry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLicense_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            
        }

        private void buttonTrial_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Date;
            RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE").
                                                                    OpenSubKey("Microsoft").
                                                                    OpenSubKey("Windows", true).
                                                                    CreateSubKey("Ramin",true);
            

            key.SetValue("Date", date);
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
