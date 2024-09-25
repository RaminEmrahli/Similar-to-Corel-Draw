using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace Command_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetString_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings setting = new ConnectionStringSettings("ConStr1", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\normalizasiya.accdb");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int key = int.Parse(txbMKey.Text);
            string name = txbMName.Text;
            string surname=txbMSurname.Text;

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\normalizasiya.accdb";
            string accessExpression = String.Format("INSERT INTO Musteriler (MusteriKey,musteriAd,musteriSoyad) VALUES ({0},'{1}','{2}')", key, name, surname);
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbTransaction transaction = connection.BeginTransaction();

                OleDbCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    command.CommandText = accessExpression;
                    int number = command.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Data ugurla elave olundu.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\normalizasiya.accdb";
            string accessExpression = "SELECT * FROM Musteriler";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                List<object> keys = new List<object>();
                List<object> names = new List<object>();
                List<object> surnames = new List<object>();
                connection.Open();
                OleDbCommand command = new OleDbCommand(accessExpression, connection);
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataGridView1.Columns.Add(reader.GetName(0), reader.GetName(0));
                    dataGridView1.Columns.Add(reader.GetName(1), reader.GetName(1));
                    dataGridView1.Columns.Add(reader.GetName(2), reader.GetName(2));
                    while (reader.Read())
                    {
                        object key = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object surname = reader.GetValue(2);

                        keys.Add(key);
                        names.Add(name);
                        surnames.Add(surname);
                    }

                    for (int i = 0; i < keys.Count; i++)
                    {
                        dataGridView1.Rows.Add(keys[i], names[i], surnames[i]);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int key = int.Parse(txbMKey.Text);
            string name = txbMName.Text;
            string surname = txbMSurname.Text;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\normalizasiya.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbTransaction transaction = connection.BeginTransaction();

                try
                {
                    string updateQuery = "UPDATE Musteriler SET musteriAd = @name, musteriSoyad = @surname WHERE musteriKey = @key";
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surname", surname);
                        command.Parameters.AddWithValue("@key", key);
                        int rowsAffected = command.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Data ugurla deyisdirildi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
                

                connection.Close();
            }

        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\normalizasiya.accdb";
            int key = int.Parse(txbMKey.Text);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbTransaction transaction = connection.BeginTransaction();
                string removeCommandText = "DELETE FROM Musteriler WHERE MusteriKey = @MusteriKey";
                try
                {
                    using (OleDbCommand command = new OleDbCommand(removeCommandText, connection))
                    {
                        command.Transaction = transaction;

                        command.Parameters.AddWithValue("@MusteriKey", key);
                        int number = command.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Data ugurla silindi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
                
            }

        }
    }
}
