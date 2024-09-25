using ShoppingData.Contracts;
using ShoppingData.DAL;
using ShoppingData.Entities;
using ShoppingData.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class FrmAdminPanel : Form
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IBrandRepository _brandRepository;
        private readonly IProductRepository _productRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderProductRepository _orderProductRepository;
        private readonly IContactUsRepository _contactUsRepository;
        private readonly IBasketRepository _basketRepository;
        public FrmAdminPanel(ICategoryRepository categoryRepository, IBrandRepository brandRepository, IProductRepository productRepository, IOrderRepository orderRepository, IOrderProductRepository orderProductRepository, IContactUsRepository contactUsRepository, IBasketRepository basketRepository)
        {
            InitializeComponent();
            _basketRepository = basketRepository;
            _categoryRepository = categoryRepository;
            _brandRepository = brandRepository;
            _productRepository = productRepository;
            _orderRepository = orderRepository;
            _orderProductRepository = orderProductRepository;
            _contactUsRepository = contactUsRepository;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text != "")
            {
                Categories category = new Categories();
                category.Name = txtCategoryName.Text;
                _categoryRepository.Add(category);
                _categoryRepository.Save();
                txtCategoryName.Clear();
                dataGridCategories.DataSource = _categoryRepository.GetAll();
                txtCategoryName.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill the textbox");
            }
        }

        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            dataGridCategories.DataSource = _categoryRepository.GetAll();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)//category
            {
                FillCategories();
            }
            if (tabControl1.SelectedIndex == 1)//brand
            {
                FillComboBoxWithCategories(cmbBoxCategoriesForBrands);
                FillBrands();
            }
            if (tabControl1.SelectedIndex == 2)//Product
            {
                FillComboBoxWithCategories(cmbBoxCategoriesForProducts);
                FillProducts();
            }
            if (tabControl1.SelectedIndex == 3) //orders
            {
                //dataGridOrders.DataSource = _orderProductRepository.GetAllOrders();
                dataGridOrders.DataSource = _orderProductRepository.GetAllOrders();
            }
            if (tabControl1.SelectedIndex == 4)
            {
                dataGridMessages.DataSource = _contactUsRepository.GetAll();
            }
        }
        public void FillCategories()
        {
            List<Categories> categories = _categoryRepository.GetAll();
            if (categories != null)
            {
                dataGridCategories.DataSource = _categoryRepository.GetAll();
            }
        }
        public void FillBrands()
        {
            List<Brands> brands = _brandRepository.GetAll();
            if (brands != null)
            {
                dataGridBrands.DataSource = _brandRepository.GetAll();
            }
        }
        public void FillProducts()
        {
            List<Product> products = _productRepository.GetAll();
            if (products != null)
            {
                dataGridProducts.DataSource = _productRepository.GetAll();
            }
        }
        public void FillOrders()
        {

        }
        public void FillMessages()
        {

        }

        private void btnBrandAdd_Click(object sender, EventArgs e)
        {
            if (txtBrandName.Text != "" && cmbBoxCategoriesForBrands.Text != "")
            {
                Brands brand = new Brands();
                brand.Name = txtBrandName.Text;
                brand.CategoryName = cmbBoxCategoriesForBrands.Text;
                _brandRepository.Add(brand);
                _brandRepository.Save();
                dataGridBrands.DataSource = _brandRepository.GetAll();
                txtBrandName.Text = "";
                cmbBoxCategoriesForBrands.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill texts");
            }

        }

        private void cmbBoxCategoriesForProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxBrandsForProducts.Items.Clear();
            labelBrand.Visible = true;
            cmbBoxBrandsForProducts.Visible = true;
            List<Brands> brands = _brandRepository.GetAll().Where(x => x.CategoryName == cmbBoxCategoriesForProducts.Text).ToList();
            foreach (var brand in brands)
            {
                cmbBoxBrandsForProducts.Items.Add(brand.Name);
            }
        }
        public void FillComboBoxWithCategories(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (var category in _categoryRepository.GetAll())
            {
                comboBox.Items.Add(category.Name);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductCount.Text != "" && txtProductPrice.Text != "" && txtProductName.Text != "" &&
                txtProductImage.Text != "" && cmbBoxBrandsForProducts.Text != "" && cmbBoxCategoriesForProducts.Text != "")
            {
                Categories category = _categoryRepository.GetAll().Find(x => x.Name == cmbBoxCategoriesForProducts.Text);
                Brands brand = _brandRepository.GetAll().Find(x => x.Name == cmbBoxBrandsForProducts.Text);
                Product product = new Product();
                product.Name = txtProductName.Text;
                product.Price = double.Parse(txtProductPrice.Text);
                product.Count = int.Parse(txtProductCount.Text);
                product.Image = txtProductImage.Text;
                product.BrandId = brand.Id;
                product.CategoriesId = category.Id;
                _productRepository.Add(product);
                _productRepository.Save();
                dataGridProducts.DataSource = _productRepository.GetAll();
                txtProductName.Text = "";
                txtProductImage.Text = "";
                txtProductCount.Text = "";
                txtProductPrice.Text = "";
                cmbBoxCategoriesForProducts.Text = "";
                cmbBoxBrandsForProducts.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill all texts");
            }
        }



        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            txtProductImage.Text = ofd.FileName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmMain frm = new FrmMain(_categoryRepository, _brandRepository, _productRepository, _basketRepository, _orderRepository, _orderProductRepository, _contactUsRepository);
            frm.ShowDialog();
        }
    }
}
