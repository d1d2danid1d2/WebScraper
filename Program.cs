using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScraper.Forms;

namespace WebScraper
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ISearchForCars, SearchForCars>();
            services.AddScoped<IClassContentSwapper, ClassContentSwapper>();

            services.AddScoped<MainMenuForm>();
            services.AddScoped<SearchForm>();
            services.AddScoped<CarDetailForm>();
            
        }


        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<MainMenuForm>();               
                Application.Run(form1);
            }
        }
    }
}
