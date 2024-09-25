using ShoppingData.Contracts;
using ShoppingData.DTOs;
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
    public partial class FrmBaskets : Form
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IBasketRepository _basketRepository;
        private readonly IProductRepository _productRepository;
        private readonly IOrderProductRepository _orderProductRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IBrandRepository _brandRepository;
        System.Windows.Forms.Timer _timer3;
        public FrmBaskets(System.Windows.Forms.Timer timer, IBasketRepository basketRepository, IProductRepository productRepository, IOrderRepository orderRepository, IOrderProductRepository orderProductRepository, ICategoryRepository categoryRepository, IBrandRepository brandRepository)
        {
            _timer3 = timer;
            InitializeComponent();
            _basketRepository = basketRepository;
            _productRepository = productRepository;
            _orderRepository = orderRepository;
            _orderProductRepository = orderProductRepository;
            _categoryRepository = categoryRepository;
            _brandRepository = brandRepository;
        }

        private void FrmBaskets_Load(object sender, EventArgs e)
        {
            timer1.Start();
            btnResetBasket.FlatAppearance.BorderColor = Color.LawnGreen;
            btnResetBasket.FlatAppearance.BorderSize = 3;
            FillBaskets();
        }

        public void FillBaskets()
        {
            flwPanelBaskets.Controls.Clear();
            var baskets = _basketRepository.GetAllBaskets();
            foreach (var basket in baskets)
            {
                var bc = new BasketCard(_productRepository, _basketRepository);
                bc.ProductName = basket.Product.Brand.Name + " " + basket.ProductName;
                bc.img = basket.Product.Image;
                bc.ProductPrice += basket.ProductPrice.ToString();
                double total = basket.ProductCount * basket.ProductPrice;
                bc.Total = total.ToString();
                bc.ProductCount = basket.ProductCount.ToString();
                bc.ProductId = basket.ProductId;
                bc.Visible = true;
                flwPanelBaskets.Controls.Add(bc);
            }
        }
        private void btnResetBasket_Click(object sender, EventArgs e)
        {
            labelTotal.Text = "₼ 0";
            flwPanelBaskets.Controls.Clear();
            _basketRepository.DeleteAll();
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double sum = _basketRepository.GetAll().Sum(x => x.ProductCount * x.ProductPrice);
            if (sum >= 30)
            {
                btnOrder.Enabled = true;
                labelWarning.Visible = false;
            }
            else
            {
                labelWarning.Visible = true;
                btnOrder.Enabled = false;
            }
            labelTotal.Text = "₼ " + sum.ToString("0.0");
        }

        private void FrmBaskets_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            _timer3.Start();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (_basketRepository.GetAll().Count != 0)
            {
                FrmOrder frmOrder = new FrmOrder(timerForOrder,_productRepository,_basketRepository,_orderRepository,_brandRepository,_orderProductRepository,_categoryRepository);
                frmOrder.ShowDialog();
            }
            else
            {
                MessageBox.Show("Səbət boşdur");
            }
        }

        private void timerForOrder_Tick(object sender, EventArgs e)
        {
            FillBaskets();
            timerForOrder.Stop();
        }
    }
}
