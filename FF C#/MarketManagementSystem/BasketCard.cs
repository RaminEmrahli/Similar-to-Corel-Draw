using ShoppingData.Contracts;
using ShoppingData.Entities;
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

    public partial class BasketCard : UserControl
    {
        private readonly IProductRepository _productRepository;
        private readonly IBasketRepository _basketRepository;
        public int ProductId { get; set; }
        public string img
        {
            get { return pictureBox1.ImageLocation; }
            set { pictureBox1.ImageLocation = value; }
        }
        public string ProductName
        {
            get { return labelProductName.Text; }
            set { labelProductName.Text = value; }
        }
        public string ProductPrice
        {
            get { return labelProductPrice.Text; }
            set { labelProductPrice.Text = value; }
        }
        public string ProductCount
        {
            get { return txtProductCount.Text; }
            set { txtProductCount.Text = value; }
        }
        public string Total
        {
            get { return labelTotal.Text; }
            set { labelTotal.Text = value; }
        }
        public BasketCard(IProductRepository productRepository, IBasketRepository basketRepository)
        {
            _productRepository = productRepository;
            _basketRepository = basketRepository;
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Product product = _productRepository.GetById(ProductId);
            Basket basket = _basketRepository.GetAllBaskets().Find(x => x.ProductId == product.Id);
            int count = int.Parse(txtProductCount.Text);
            if (count < product.Count)
            {
                count++;
                basket.ProductCount = count;
                ProductCount = basket.ProductCount.ToString();
                double total = basket.ProductCount * basket.ProductPrice;
                Total = total.ToString();
            }
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Product product = _productRepository.GetById(ProductId);
            Basket basket = _basketRepository.GetAllBaskets().Find(x => x.ProductId == product.Id);
            int count = int.Parse(txtProductCount.Text);
            if (count > 1)
            {
                count--;
                basket.ProductCount = count;
                ProductCount = basket.ProductCount.ToString();
                double total = basket.ProductCount * basket.ProductPrice;
                Total = total.ToString();
            }
        }
    }
}
