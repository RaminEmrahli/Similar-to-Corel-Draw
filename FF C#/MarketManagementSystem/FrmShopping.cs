using ShoppingData.Contracts;
using ShoppingData.Entities;
using ShoppingData.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MarketManagementSystem
{
    public partial class FrmShopping : Form
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IBrandRepository _brandRepository;
        private readonly IBasketRepository _basketRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderProductRepository _orderProductRepository;
        private readonly IContactUsRepository _contactUsRepository;
        public FrmShopping(IProductRepository productRepository, ICategoryRepository categoryRepository, IBrandRepository brandRepository, IBasketRepository basketRepository, IOrderRepository orderRepository, IOrderProductRepository orderProductRepository, IContactUsRepository contactUsRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _brandRepository = brandRepository;
            _basketRepository = basketRepository;
            _orderRepository = orderRepository;
            _orderProductRepository = orderProductRepository;
            _contactUsRepository = contactUsRepository;
        }

        public void FillBestSellers(FlowLayoutPanel flw)
        {

            flw.Controls.Clear();
            List<Product> products = _productRepository.GetAllProductsWithBrands().OrderByDescending(x => x.SoldCount).ToList();
            int i = 0;
            foreach (var product in products)
            {
                if (i < 3)
                {
                    var pc = new ProductCard(_productRepository, _basketRepository, product.Id);
                    pc.ProductName = product.Brand.Name + " " + product.Name;
                    pc.img = product.Image;
                    pc.ProductPrice += product.Price.ToString();
                    pc.ProductId = product.Id;
                    pc.Visible = true;
                    flw.Controls.Add(pc);
                    i++;
                }
                else
                {
                    break;
                }
            }
        }
        private void FrmShopping_Load(object sender, EventArgs e)
        {
            FillBestSellers(flowlyPanelBestSellers);
            timer3.Start();
            _basketRepository.DeleteAll();
            btnBack.FlatAppearance.BorderColor = Color.White;
            btnBack.FlatAppearance.BorderSize = 2;
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatAppearance.BorderSize = 2;
            btnAddBasket.FlatAppearance.BorderColor = Color.White;
            btnAddBasket.FlatAppearance.BorderSize = 2;
            timer1.Start();
            pictureBoxSlider.ImageLocation = @"C:\Users\Ramin\OneDrive\Masaüstü\ResourcesForMarket\Slider1.png";
            foreach (var data in _categoryRepository.GetAll())
            {
                tsDropDownBtnCategories.DropDown.Items.Add(data.Name);
            }
        }
        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
        private void tsDropDownBtnCategories_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            timer1.Stop();
            timer2.Stop();
            Point location = pictureBoxSlider.Location;
            this.Controls.Remove(pictureBoxSlider);
            this.Controls.Remove(radioButton1);
            this.Controls.Remove(radioButton2);
            this.Controls.Remove(labelBestSellers);
            this.Controls.Remove(flowlyPanelBestSellers);
            int index = tsDropDownBtnCategories.DropDownItems.IndexOf(e.ClickedItem);
            labelSelectedCategory.Text = tsDropDownBtnCategories.DropDownItems[index].Text;
            Categories category = _categoryRepository.GetAll().Find(x => x.Name == labelSelectedCategory.Text);
            flowLayoutPanel.Location = location;
            flowLayoutPanel.Width = 900;
            flowLayoutPanel.Height = 500;
            flowLayoutPanel.Visible = true;
            flowLayoutPanel.AutoScroll = true;
            this.Controls.Add(flowLayoutPanel);
            List<Product> products = _productRepository.GetAllProductsByCategory(category.Id);
            FillProducts(flowLayoutPanel, products);
        }
        public void FillProducts(FlowLayoutPanel flw, List<Product> products)
        {
            flw.Controls.Clear();
            foreach (var product in products)
            {
                var pc = new ProductCard(_productRepository, _basketRepository, product.Id);
                pc.ProductName = product.Brand.Name + " " + product.Name;
                pc.img = product.Image;
                pc.ProductPrice += product.Price.ToString();
                pc.ProductId = product.Id;
                pc.Visible = true;
                flw.Controls.Add(pc);
            }
        }
        //public void FillBestSoldProducts(FlowLayoutPanel flw)
        //{
        //    flw.Controls.Clear();
        //    List<Product> products = _productRepository.GetAllProducts(id);
        //    foreach (var product in products)
        //    {
        //        var pc = new ProductCard(_productRepository, _basketRepository, product.Id);
        //        pc.ProductName = product.Brand.Name + " " + product.Name;
        //        pc.img = product.Image;
        //        pc.ProductPrice += product.Price.ToString();
        //        pc.ProductId = product.Id;
        //        pc.Visible = true;
        //        flw.Controls.Add(pc);
        //    }
        //}
        private void radioButton2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = true;
            timer1.Stop();
            timer2.Start();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxSlider.ImageLocation = @"C:\Users\Ramin\OneDrive\Masaüstü\ResourcesForMarket\Slider2.png";
            radioButton2.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            radioButton2.FlatAppearance.BorderColor = Color.LawnGreen;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            radioButton1.FlatAppearance.BorderColor = Color.LawnGreen;
            pictureBoxSlider.ImageLocation = @"C:\Users\Ramin\OneDrive\Masaüstü\ResourcesForMarket\Slider1.png";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            timer2.Stop();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBasket_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            FrmBaskets frm = new FrmBaskets(timer3, _basketRepository, _productRepository, _orderRepository, _orderProductRepository, _categoryRepository, _brandRepository);
            frm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frm = new FrmMain(_categoryRepository, _brandRepository, _productRepository, _basketRepository, _orderRepository, _orderProductRepository, _contactUsRepository);
            frm.ShowDialog();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            double sum = _basketRepository.GetAll().Sum(x => x.ProductCount * x.ProductPrice);
            labelTotal.Text = "₼ " + sum.ToString("0.0");
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            FrmContactUs frmContact = new FrmContactUs(_contactUsRepository);
            frmContact.ShowDialog();
        }

        public void FillOneProduct(FlowLayoutPanel flw, Product product)
        {

            var pc = new ProductCard(_productRepository, _basketRepository, product.Id);
            pc.ProductName = product.Brand.Name + " " + product.Name;
            pc.img = product.Image;
            pc.ProductPrice += product.Price.ToString();
            pc.ProductId = product.Id;
            pc.Visible = true;
            flw.Controls.Add(pc);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(flowLayoutPanel);
            labelSelectedCategory.Text = "";
            flowLayoutPanel.Controls.Clear();
            this.Controls.Remove(pictureBoxSlider);
            this.Controls.Remove(radioButton1);
            this.Controls.Remove(radioButton2);
            this.Controls.Remove(labelBestSellers);
            this.Controls.Remove(flowlyPanelBestSellers);
            flowLayoutPanel.Location = new Point(161, 216);
            flowLayoutPanel.Width = 900;
            flowLayoutPanel.Height = 600;
            flowLayoutPanel.Visible = true;
            flowLayoutPanel.AutoScroll = true;
            this.Controls.Add(flowLayoutPanel);
            List<Product> products = _productRepository.GetAllProductsWithBrands();
            foreach (Product product in products)
            {
                string productName = product.Brand.Name.ToLower() + " " + product.Name.ToLower();
                if (productName.Contains(txtSearchText.Text.ToLower()))
                {
                    FillOneProduct(flowLayoutPanel, product);
                }
            }
        }

        private void pictureBoxSlider_Click(object sender, EventArgs e)
        {

        }


    }
}
