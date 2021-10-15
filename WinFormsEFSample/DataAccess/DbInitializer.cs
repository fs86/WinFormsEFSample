using Microsoft.EntityFrameworkCore;
using System;
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
                new()
                {
                    Id = new Guid("C7660F77-9962-45EE-A601-CFA7799AA85E"),
                    Name = "Anis",
                },
                new()
                {
                    Id = new Guid("32F2A89A-D70D-4EBE-8ED5-69DAB23501C8"),
                    Name = "Basilikum"
                }
            };

            modelBuilder.Entity<Herb>().HasData(herbs);

            var seasons = new Season[]
            {
                new()
                {
                    Id = new Guid("8AF96254-D025-4F5C-A56C-9B4CEF659CA6"),
                    HerbId = herbs.First(herb => herb.Name == "Anis").Id,
                    From = "September",
                    To = "November"
                },
                new()
                {
                    Id = new Guid("00B2619F-9536-4CE0-9E63-780C95F3BCE5"),
                    HerbId = herbs.First(herb => herb.Name == "Basilikum").Id,
                    From = "juni",
                    To = "September"
                }
            };

            modelBuilder.Entity<Season>().HasData(seasons);
        }
    }
}
