using SDF1.Entities;
using SDF1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SDF1
{
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            OrdersModel ordersModel = new OrdersModel();
            
            ordersModel.Count = txtOrderCount.Text;
            ordersModel.Price = txtPriceOrder.Text;
            ordersModel.Name = comboBoxNames.SelectedItem.ToString();
            OrdersRepositories ordersRepositories = new OrdersRepositories();
            ordersRepositories.Add(ordersModel);
            this.Close();
        }

        private void FrmOrders_Activated(object sender, EventArgs e)
        {
            foreach (var item in Database.Products)
            {
                comboBoxNames.Items.Add(item.Name);
            }
        }

        private void comboBoxNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
