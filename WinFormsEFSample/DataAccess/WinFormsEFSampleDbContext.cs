using Microsoft.EntityFrameworkCore;
using WinFormsEFSample.DataAccess.Config;
using WinFormsEFSample.DataAccess.Models;

namespace WinFormsEFSample.DataAccess
{
    public class WinFormsEFSampleDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            HerbEntityConfig.Set(modelBuilder.Entity<Herb>());

            DbInitializer.Seed(modelBuilder);
        }

        public DbSet<Herb> Herb { get; set; }
        public DbSet<Season> Season { get; set; }
    }
}
