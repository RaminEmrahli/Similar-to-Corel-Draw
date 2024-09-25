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

namespace MarketManagementSystem
{
    public partial class AfterAddbasket : UserControl
    {
        private readonly IProductRepository _productRepository;
        private readonly IBasketRepository _basketRepository;

        public int ProductId { get; set; }
        public AfterAddbasket(IProductRepository productRepository, IBasketRepository basketRepository,int id)
        {
            ProductId = id;
            _productRepository = productRepository;
            InitializeComponent();
            _basketRepository = basketRepository;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Product product = _productRepository.GetById(ProductId);
            Basket basket = _basketRepository.GetAll().Find(x => x.ProductId == ProductId);
            btnCount.Text = basket.ProductCount.ToString() + " pcs.";
            int count = basket.ProductCount;
            if (count < product.Count)
            {
                count++;
                basket.ProductCount = count;
                btnCount.Text = count.ToString() + " pcs.";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Product product = _productRepository.GetById(ProductId);
            Basket basket = _basketRepository.GetAll().Find(x => x.ProductId == ProductId);
            btnCount.Text = basket.ProductCount.ToString() + " pcs.";
            int count = basket.ProductCount;
            if (count <= product.Count)
            {
                count++;
                basket.ProductCount = count;
                btnCount.Text = count.ToString() + " pcs.";
            }
        }

        private void AfterAddbasket_Load(object sender, EventArgs e)
        {
            Product product = _productRepository.GetById(ProductId);
            Basket basket = _basketRepository.GetAll().Find(x => x.ProductId == ProductId);
            if (basket.ProductCount == 0)
            {
                btnCount.Text = "1 pcs";
            }
            else
            {
                btnCount.Text = basket.ProductCount.ToString() + " " + "pcs";
            }
           
        }
    }
}
