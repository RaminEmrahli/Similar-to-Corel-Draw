using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SDF1.Repositories;

namespace SDF1
{
    public partial class Form1 : Form
    {
        bool isClickedMehsullar = false;
        bool isClickedSatis = false;
        public Form1()
        {
            InitializeComponent();
            //Database.LoadData();
        }

        private void tsBtnMehsullar_Click(object sender, EventArgs e)
        {
            ProductsRepository productsRepository = new ProductsRepository();
            dataGridView1.DataSource = productsRepository.GetAll();
            isClickedMehsullar = true;
            isClickedSatis = false;
        }

        private void tsBtnSatis_Click(object sender, EventArgs e)
        {
            OrdersRepositories ordersRepository = new OrdersRepositories();
            dataGridView1.DataSource = ordersRepository.GetAll();
            isClickedMehsullar=false;
            isClickedSatis=true;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isClickedMehsullar)
            {
                FrmMehsul frmMehsul=new FrmMehsul();
                frmMehsul.ShowDialog();
            }
            else if(isClickedSatis)
            {
                FrmOrders frmOrders=new FrmOrders();
                frmOrders.ShowDialog();
            }
        }
    }
}
