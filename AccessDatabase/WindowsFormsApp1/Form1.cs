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
using WindowsFormsApp1.Database1DataSetTableAdapters;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mallarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mallarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mallarDataGridView.Columns[0].Visible = false;
            // TODO: Bu kod satırı 'database1DataSet.Sifarisler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mallarTableAdapter.Fill(this.database1DataSet.Mallar);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtComputer.Text!="" && txtPrice.Text != "")
            {
                mallarTableAdapter.Insert(txtComputer.Text, int.Parse(txtPrice.Text));
                mallarDataGridView.DataSource = mallarTableAdapter.GetData();
            }
            else
            {
                MessageBox.Show("Don't leave blank spaces");
            }
        }

        private void mallarDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            txtComputer.Text = mallarDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = mallarDataGridView.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtComputer.Clear();
            txtPrice.Clear();
            txtComputer.Focus();
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result; 
            result = MessageBox.Show("Are you sure you want to delete the data?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            {
                int key = (int)mallarDataGridView.CurrentRow.Cells[0].Value;
                string name = mallarDataGridView.CurrentRow.Cells[1].Value.ToString();
                decimal value = (decimal)mallarDataGridView.CurrentRow.Cells[2].Value;
                mallarTableAdapter.Delete(key, name, value);
                mallarDataGridView.DataSource = mallarTableAdapter.GetData();
            }
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int key = (int)mallarDataGridView.CurrentRow.Cells[0].Value;
            string name = mallarDataGridView.CurrentRow.Cells[1].Value.ToString();
            decimal value = (decimal)mallarDataGridView.CurrentRow.Cells[2].Value;
            mallarTableAdapter.Update(txtComputer.Text, int.Parse(txtPrice.Text), key, name, value);
            mallarDataGridView.DataSource = mallarTableAdapter.GetData();
        }
    }
}
