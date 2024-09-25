using Data.Contracts;
using Data.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SDF2
{
    internal static class Program
    {
        //{
        //    [STAThread]
        //    static void Main()
        //    {
        //        /// <summary>
        //        ///  The main entry point for the application.
        //        /// </summary>
        //        [STAThread]
        //        static void Main()
        //        {
        //            // To customize application configuration such as set high DPI settings or default font,
        //            // see https://aka.ms/applicationconfiguration.
        //            ApplicationConfiguration.Initialize();
        //            Application.Run(new Form1());
        //        }
        //    }
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
           
            // Add the main form
            services.AddTransient<Form1>();
        }
    }
}