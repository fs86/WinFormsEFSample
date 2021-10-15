using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WinFormsEFSample.DataAccess.Models;

namespace WinFormsEFSample.DataAccess
{
    public class DbInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var herbs = new Herb[]
            {
                new Herb
                {
                    Id = new Guid("d6b2ae7f-82f4-4099-86a9-556a62338271"),
                    Name = "Anis",
                }
            };

            modelBuilder.Entity<Herb>().HasData(herbs);

            var seasons = new Season[]
            {
                new Season
                {
                    Id = new Guid("e358d618-d376-439a-9cd3-5e2c02849103"),
                    HerbId = herbs.First(herb => herb.Name == "Anis").Id,
                    From = "September",
                    To = "November"
                }
            };

            modelBuilder.Entity<Season>().HasData(seasons);
        }
    }
}
