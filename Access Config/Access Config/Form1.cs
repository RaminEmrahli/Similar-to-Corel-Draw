using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Data.OleDb;
using System.Data;

namespace Access_Config
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ConnectionStringSettings setting = new ConnectionStringSettings("ConStr1", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\normalizasiya.accdb");
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //config.ConnectionStrings.ConnectionStrings.Add(setting);
            //config.Save();

            //ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;
            //section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            //config.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings setting = 
                new ConnectionStringSettings("ConStr1", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\normalizasiya.accdb");
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Add(setting);
            config.Save();

            ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;
            section.SectionInformation.UnprotectSection();
            config.Save();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    string fileContent = reader.ReadToEnd();
                    textBox1.Text = fileContent;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings setting = new ConnectionStringSettings("ConStr1", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Database1.accdb");
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Add(setting);
            config.Save();

            ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;
            section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            config.Save();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    string fileContent = reader.ReadToEnd();
                    textBox1.Text = fileContent;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
           
            string password = tbPassword.Text;  
            string conStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\DataBase1.accdb;Persist Security Info = True; Jet OLEDB:Database Password="+password+";";
            OleDbConnectionStringBuilder bilder = new OleDbConnectionStringBuilder();
            bilder.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\DataBase1.accdb;Persist Security Info = True; Jet OLEDB:Database Password=";
            bilder.Add("Password", password);
            MessageBox.Show(bilder.ConnectionString);
            using (OleDbConnection con = new OleDbConnection(bilder.ConnectionString))
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("Select * from Sifarisler",con);
                
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        textBox1.Text+= reader[0];
                    }
                }                   
            }

            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;
            //string conStr = section.ConnectionStrings["ConStr1"].ConnectionString;
            //MessageBox.Show(conStr);
            //

            //section.SectionInformation.UnprotectSection();
        }
    }
}
