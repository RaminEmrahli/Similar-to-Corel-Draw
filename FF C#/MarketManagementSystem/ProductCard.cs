using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ProductCard : UserControl
    {
        private readonly IProductRepository _productRepository;
        private readonly IBasketRepository _basketRepository;
        public int ProductId { get; set; }
        public string img
        {
            get { return pictureBoxProduct.ImageLocation; }
            set { pictureBoxProduct.ImageLocation = value; }
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
        public ProductCard(IProductRepository productRepository, IBasketRepository basketRepository, int id)
        {
            this.ProductId = id;
            _basketRepository = basketRepository;
            _productRepository = productRepository;
            InitializeComponent();
        }

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            Product product = _productRepository.GetById(ProductId);
            Basket basket = _basketRepository.GetAll().Find(x => x.ProductId == ProductId);
            if (basket != null)
            {
                basket.ProductCount++;
            }
            else
            {
                basket = new Basket
                {
                    ProductCount = 1,
                    ProductId = this.ProductId,
                    ProductName = product.Name,
                    ProductPrice = product.Price
                };
                _basketRepository.Add(basket);
            }
            _basketRepository.Save();
            AfterAddbasket afterAddbasket = new AfterAddbasket(_productRepository, _basketRepository, ProductId);
            afterAddbasket.Location = btnAddToBasket.Location;
            afterAddbasket.Visible = true;
            this.Controls.Remove(btnAddToBasket);
            this.Controls.Add(afterAddbasket);
        }
    }
}
