using ShoppingData.Contracts;
using ShoppingData.Implementations;

namespace MarketManagementSystem
{
    public partial class FrmMain : Form
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IBrandRepository _brandRepository;
        private readonly IProductRepository _productRepository;
        private readonly IBasketRepository _basketRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderProductRepository _orderProductRepository;
        private readonly IContactUsRepository _contactUsRepository;
        public FrmMain(ICategoryRepository categoryRepository, IBrandRepository brandRepository, IProductRepository productRepository, IBasketRepository basketRepository, IOrderRepository orderRepository, IOrderProductRepository orderProductRepository, IContactUsRepository contactUsRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
            _brandRepository = brandRepository;
            _productRepository = productRepository;
            _basketRepository = basketRepository;
            _orderRepository = orderRepository;
            _orderProductRepository = orderProductRepository;
            _contactUsRepository = contactUsRepository;
        }
        private void tsMenuItemAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogIn logIn = new FrmLogIn(_categoryRepository, _brandRepository, _productRepository, _basketRepository,_orderProductRepository, _contactUsRepository);
            logIn.ShowDialog();
        }

        private void tsMenuItemShopping_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmShopping shopping = new FrmShopping(_productRepository, _categoryRepository, _brandRepository,_basketRepository, _orderRepository, _orderProductRepository,_contactUsRepository);
            shopping.ShowDialog();
        }
    }
}