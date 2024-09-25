using ShoppingData.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class FrmLogIn : Form
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IBrandRepository _brandRepository;
        private readonly IProductRepository _productRepository;
        private readonly IBasketRepository _basketRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderProductRepository _orderProductRepository;
        private readonly IContactUsRepository _contactUsRepository;
        public FrmLogIn(ICategoryRepository categoryRepository, IBrandRepository brandRepository, IProductRepository productRepository, IBasketRepository basketRepository, IOrderProductRepository orderProductRepository, IContactUsRepository contactUsRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
            _brandRepository = brandRepository;
            _productRepository = productRepository;
            _basketRepository = basketRepository;
            _orderProductRepository = orderProductRepository;
            _contactUsRepository = contactUsRepository;
        }
        private void linkLabelHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmMain main = new FrmMain(_categoryRepository, _brandRepository, _productRepository,_basketRepository,_orderRepository, _orderProductRepository, _contactUsRepository);
            main.ShowDialog();
        }

        public void ValidateLogin()
        {

            if (txtUser.Text == "")
            {
                labelValidationUser.Text = "User is required";
            }
            if (txtPassword.Text == "")
            {
                labelValidationPassword.Text = "Password is required";
            }
            if (txtPassword.Text == "Admin" && txtUser.Text == "Admin")
            {
                MessageBox.Show("You have logged successfully");
                this.Hide();
                FrmAdminPanel frmAdminPanel = new FrmAdminPanel(_categoryRepository, _brandRepository,_productRepository,_orderRepository,_orderProductRepository, _contactUsRepository,_basketRepository);
                frmAdminPanel.ShowDialog();
                
            }
            else
            {
                if (txtUser.Text != "" && txtPassword.Text != "")
                {
                    MessageBox.Show("UserName or Password is wrong");
                }

            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ValidateLogin();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            labelValidationUser.Text = "";
            txtUser.TextAlign = HorizontalAlignment.Center;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 8;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            labelValidationPassword.Text = "";
        }


    }
}
