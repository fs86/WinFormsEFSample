using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WinFormsEFSample.DataAccess.Models;

namespace WinFormsEFSample.DataAccess.Config
{
    internal class HerbEntityConfig
    {
        internal static void Set(EntityTypeBuilder<Herb> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).ValueGeneratedOnAdd();

            entityBuilder
                .HasMany(x => x.Seasons)
                .WithOne(x => x.Herb)
                .HasForeignKey(x => x.HerbId);
        }        
    }
}
