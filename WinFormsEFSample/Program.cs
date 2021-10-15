using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;
using WinFormsEFSample.DataAccess;
using WinFormsEFSample.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WinFormsEFSample.Service;
using WinFormsEFSample.Service.Contract;

namespace WinFormsEFSample
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using var serviceProvider = services.BuildServiceProvider();

            using (var serviceScope = serviceProvider.GetService<IServiceScopeFactory>()?.CreateScope())
            {
                var context = serviceScope?.ServiceProvider.GetRequiredService<HerbDbContext>();
                context?.Database.EnsureCreated();
            }

            Application.Run(serviceProvider.GetRequiredService<MainForm>());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var config = configBuilder.Build();

            var connectionString = config.GetSection("appSettings")
                .Get<AppConfig>().ConnectionString;

            services.AddSingleton<IConfiguration>(config);

            services.AddLogging(loggingBuilder => loggingBuilder.AddConsole());
            services.AddDbContext<HerbDbContext>(options => options.UseSqlServer(connectionString));

            // Add Business Logic services here
            services.AddTransient<IHerbService, HerbService>();

            // Main entry point
            services.AddScoped<MainForm>();
        }
    }
}
