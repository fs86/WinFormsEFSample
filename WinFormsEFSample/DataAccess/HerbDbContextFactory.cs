using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

namespace WinFormsEFSample.DataAccess
{
    public class HerbDbContextFactory : IDesignTimeDbContextFactory<HerbDbContext>
    {
        public static IConfiguration Configuration { get; set; }

        public HerbDbContext CreateDbContext(string[] args)
        {
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = configBuilder.Build();

            var connectionString = Configuration.GetSection("appSettings")
                .Get<AppConfig>().ConnectionString;

            var optionsBuilder = new DbContextOptionsBuilder<HerbDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new HerbDbContext(optionsBuilder.Options);
        }
    }
}
