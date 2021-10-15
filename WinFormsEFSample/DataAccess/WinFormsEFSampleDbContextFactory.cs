using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace WinFormsEFSample.DataAccess
{
    public class WinFormsEFSampleDbContextFactory : IDesignTimeDbContextFactory<WinFormsEFSampleDbContext>
    {
        public static IConfiguration Configuration { get; set; }

        public WinFormsEFSampleDbContext CreateDbContext(string[] args)
        {
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = configBuilder.Build();

            var connectionString = Configuration.GetSection("appSettings")
                .Get<AppConfig>().ConnectionString;

            var optionsBuilder = new DbContextOptionsBuilder<WinFormsEFSampleDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new WinFormsEFSampleDbContext(optionsBuilder.Options);
        }
    }
}
