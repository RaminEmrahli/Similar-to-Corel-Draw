using KenanNIhat.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Windows.Forms.Design;
using KenanNIhat.Data;

namespace KenanNihat
{
    internal static class Program
    {
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
                var form = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Add services here
            services.AddScoped<IGroupRepository,GroupRepository>();
            services.AddScoped<IStudentRepository,StudentRepository>();
            services.AddDbContext<KenanNIhat.Data.AppContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-I4PRRNC\\SQLEXPRESS;Database=KenanNihat;Trusted_Connection=true;");
            });
            // Add the main form
            services.AddTransient<Form1>();
        }
    }
}
