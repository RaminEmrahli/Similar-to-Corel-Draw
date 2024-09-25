using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Microsoft.Extensions.DependencyInjection;
using ShoppingData.Contracts;
using ShoppingData.DAL;
using ShoppingData.Implementations;

namespace MarketManagementSystem
{
    internal static class Program
    {
        /////// <summary>
        ///////  The main entry point for the application.
        /////// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    DatabaseContext context = new DatabaseContext();
        //    ICategoryRepository categoryRepository = new CategoryRepository(context);
        //    IBrandRepository brandRepository = new BrandRepository(context);
        //    IProductRepository productRepository = new ProductRepository(context);
        //    IBasketRepository basketRepository = new BasketRepository(context);
        //    IOrderRepository orderRepository = new OrderRepository(context);
        //    IOrderProductRepository orderProductRepository = new OrderProductRepository(context);
        //    IContactUsRepository contactUsRepository = new ContactUsRepository(context);
        //    // To customize application configuration such as set high DPI settings or default font,
        //    // see https://aka.ms/applicationconfiguration.
        //    ApplicationConfiguration.Initialize();
        //    Application.Run(new FrmMain(categoryRepository,brandRepository,productRepository,basketRepository,orderRepository,orderProductRepository,contactUsRepository));
        //}
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<FrmMain>();
                Application.Run(form);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Add services here

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IBasketRepository, BasketRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderProductRepository, OrderProductRepository>();
            services.AddScoped<IContactUsRepository, ContactUsRepository>();
            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-I4PRRNC\\SQLEXPRESS;Database=MarketManagement;Trusted_Connection=true;");
            });
            // Add the main form
            services.AddTransient<FrmMain>();
        }

    }
}