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
    public partial class OrderBasketsCard : UserControl
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IProductRepository _productRepository;
        public int ProductId { get; set; }
        public string img
        {
            get { return pictureBox1.ImageLocation; }
            set { pictureBox1.ImageLocation = value; }
        }
        public string ProductName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public OrderBasketsCard(IBasketRepository basketRepository, IProductRepository productRepository)
        {
            InitializeComponent();
            _basketRepository = basketRepository;
            _productRepository = productRepository;
        }
    }
}
