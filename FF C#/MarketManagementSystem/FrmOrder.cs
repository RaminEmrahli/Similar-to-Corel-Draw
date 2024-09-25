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
    public partial class FrmOrder : Form
    {
        System.Windows.Forms.Timer _timer;
        private readonly IBasketRepository _basketRepository;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IBrandRepository _brandRepository;
        private readonly IOrderProductRepository _orderProductRepository;
        private readonly IContactUsRepository _contactUsRepository;
        public FrmOrder(System .Windows.Forms.Timer timer, IProductRepository productRepository, IBasketRepository basketRepository, IOrderRepository orderRepository, IBrandRepository brandRepository, IOrderProductRepository orderProductRepository,ICategoryRepository categoryRepository)
        {
            _timer = timer;
            InitializeComponent();
            _categoryRepository = categoryRepository;
            _orderRepository = orderRepository;
            _basketRepository = basketRepository;
            _productRepository = productRepository;
            _brandRepository = brandRepository;
            _orderProductRepository = orderProductRepository;
        }

        private void FrmOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            _timer.Start();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            btnCard.FlatAppearance.BorderColor = Color.White;
            btnCash.FlatAppearance.BorderColor = Color.White;
            double sum = _basketRepository.GetAll().Sum(x => x.ProductCount * x.ProductPrice);
            labelTotal.Text = "₼ " + sum.ToString("0.0").ToString();
            sum += 2.5;
            labelTotalAll.Text = "₼ " + sum.ToString("0.0");
            FillBaskets();
        }
        public void FillBaskets()
        {
            flwBaskets.Controls.Clear();
            var baskets = _basketRepository.GetAllBaskets();
            foreach (var basket in baskets)
            {
                var obc = new OrderBasketsCard(_basketRepository, _productRepository);
                obc.ProductName = basket.Product.Brand.Name + " " + basket.ProductName;
                obc.img = basket.Product.Image;
                double total = basket.ProductCount * basket.ProductPrice;
                obc.ProductId = basket.ProductId;
                obc.Visible = true;
                flwBaskets.Controls.Add(obc);
            }
        }

        string message = "";
        public void PostOrder()
        {
            List<Basket> baskets = _basketRepository.GetAll();
            Order order = new Order
            {
                UserName = txtName.Text,
                Adress = cmbBoxRegion.Text + " " + txtAdress.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Date = DateTime.Now,
                Total = baskets.Sum(x => x.ProductPrice * x.ProductCount),
                PayMethod = payMethod
            };
            foreach (var basket in baskets)
            {
                order.OrderProducts.Add(new OrderProduct
                {
                    OrderId = order.Id,
                    ProductCount = basket.ProductCount,
                    ProductId = basket.ProductId,
                    ProductName = basket.ProductName,
                    ProductPrice = basket.ProductPrice
                });
                basket.Product.Count -= basket.ProductCount;
                basket.Product.SoldCount += basket.ProductCount;
            }
            _orderRepository.Add(order);
            _orderRepository.Save();
            _basketRepository.DeleteAll();
            payMethod = "";
            message = "Sifarişiniz uğurla qeydə alındı";
            MessageBox.Show(message);
        }
        public bool Validate()
        {
            if (payMethod == "")
            {
                MessageBox.Show("Ödəmə üsulunu seçin");
                return false;
            }
            if (txtAdress.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Zəhmət olmasa müştəri məlumatlarını doldurun");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            bool isOrder = Validate();
            if (isOrder)
            {
                PostOrder();
                this.Close();
            }

        }

        string payMethod = "";
        private void btnCash_Click(object sender, EventArgs e)
        {
            payMethod = "Nağd";
            btnCash.FlatAppearance.BorderColor = Color.LawnGreen;
            btnCard.FlatAppearance.BorderColor = Color.White;
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            payMethod = "Card";
            btnCash.FlatAppearance.BorderColor = Color.White;
            btnCard.FlatAppearance.BorderColor = Color.LawnGreen;
        }

    }
}
