using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Database1.accdb;Jet OLEDB:Database Password=2004";
            string oledbExpression = "SELECT * FROM Mallar";
            using(OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(oledbExpression,connection);
                OleDbDataReader reader = command.ExecuteReader();
                object id=0, name=0, value=0;
                
                while (reader.Read())     
                {
                    id = reader.GetValue(0);
                    name = reader.GetValue(1);
                    value = reader.GetValue(2);
                    dataGridView1.Rows.Add(id, name, value);
                }
                     reader.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            string Mal_Ad = txtMalAd.Text;
            string Mal_Qiymet = txtMalQiymet.Text;
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Database1.accdb;Jet OLEDB:Database Password=2004";
            string oledbExpression = string.Format("INSERT INTO Mallar (Mal_Key,Mal_Ad,Mal_Qiymet) VALUES ({0},'{1}','{2}')",ID,Mal_Ad,Mal_Qiymet);
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbTransaction transaction = connection.BeginTransaction();

                OleDbCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    command.CommandText = oledbExpression;
                    int number = command.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Data elave olundu.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            string Mal_Ad = txtMalAd.Text;
            string Mal_Qiymet=txtMalQiymet.Text;
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Database1.accdb;Jet OLEDB:Database Password=2004";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbTransaction transaction = connection.BeginTransaction();
                try
                {
                    string updateQuery = "UPDATE Musteriler SET Mal_Ad = @Mal_Ad, Mal_Qiymet = @Mal_Qiymet WHERE Mal_Key = @ID";
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Mal_Ad", Mal_Ad);
                        command.Parameters.AddWithValue("@Mal_Qiymet", Mal_Qiymet);
                        int number = command.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("Data deyisdirildi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Database1.accdb;Jet OLEDB:Database Password=2004";
            int ID = int.Parse(txtID.Text);
            //string oledbExpression = "DELETE FROM Mallar WHERE Mal_Ad='Gigabyte'";
            //using (OleDbConnection connection = new OleDbConnection(connectionString))
            //{
            //    connection.Open();
            //    OleDbCommand command = new OleDbCommand(oledbExpression, connection);
            //}
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbTransaction transaction = connection.BeginTransaction();
                string oledbExpression = "DELETE FROM Mallar WHERE Mal_Key='@ID'";
                try
                {
                    using (OleDbCommand command = new OleDbCommand(oledbExpression, connection))
                    {
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@ID", ID);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMalAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMalQiymet.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
