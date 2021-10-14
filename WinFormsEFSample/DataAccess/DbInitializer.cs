using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
                    Id = Guid.NewGuid(),
                    Name = "Anis",
                    Seasons = new List<Season>
                    {
                        new Season { From = "September", To = "November" }
                    }
                }
            };

            modelBuilder.Entity<Herb>().HasData(herbs);
        }
    }
}
