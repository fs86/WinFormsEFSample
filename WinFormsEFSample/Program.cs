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
        public static IConfiguration Configuration { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = configBuilder.Build();

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

            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            Application.Run(mainForm);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            var connectionString = Configuration.GetSection("appSettings")
                .Get<AppConfig>().ConnectionString;

            services.AddLogging(loggingBuilder => loggingBuilder.AddConsole());
            services.AddDbContext<HerbDbContext>(options => options.UseSqlServer(connectionString));

            // Add Business Logic services here
            services.AddTransient<IHerbService, HerbService>();

            // Main entry point
            services.AddScoped<MainForm>();
        }
    }
}
