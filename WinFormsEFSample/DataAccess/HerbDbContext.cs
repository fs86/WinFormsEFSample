using Microsoft.EntityFrameworkCore;
using WinFormsEFSample.DataAccess.Config;
using WinFormsEFSample.DataAccess.Models;

// ReSharper disable InconsistentNaming

namespace WinFormsEFSample.DataAccess
{
    public class HerbDbContext : DbContext
    {
        public HerbDbContext(DbContextOptions<HerbDbContext> options) : base(options)
        {
        }

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
