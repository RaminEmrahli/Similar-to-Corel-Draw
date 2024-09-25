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

namespace SDF1
{
    public partial class FrmMehsul : Form
    {
        public FrmMehsul()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductModel productModel = new ProductModel();
            productModel.Name = txtName.Text;
            productModel.Count = txtCouint.Text;
            productModel.Price = txtPrice.Text;

            ProductsRepository productsRepository = new ProductsRepository();
            productsRepository.Add(productModel);
            this.Close();
        }
    }
}
