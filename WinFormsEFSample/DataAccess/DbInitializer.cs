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
                },
                new()
                {
                    Id = new Guid("1977D469-EF12-464C-BEE6-03FC42EA1849"),
                    Name = "Bockshornklee"
                },
                new()
                {
                    Id = new Guid("2B87619D-E0C6-4271-8A53-537E95C05D7E"),
                    Name = "Borretsch"
                },
                new()
                {
                    Id = new Guid("C8D2C2E3-9FA0-4A85-A279-1D2E019B6CB0"),
                    Name = "Bärlauch"
                },
                new()
                {
                    Id = new Guid("4236F6F6-BB89-4952-A60E-69BF87F461AB"),
                    Name = "Dill"
                },
                new()
                {
                    Id = new Guid("A821D32E-0D32-4E94-BB0A-75568764BF15"),
                    Name = "Estragon"
                },
                new()
                {
                    Id = new Guid("00579AF1-2D77-4C4A-96FE-570EF0455CFE"),
                    Name = "Kerbel"
                },
                new()
                {
                    Id = new Guid("0A5923C6-266C-4478-972D-4A8DF335D658"),
                    Name = "Knoblauch"
                },
                new()
                {
                    Id = new Guid("4858C0FB-8A43-4B61-858C-9EB684BFBDA5"),
                    Name = "Kresse"
                },
                new()
                {
                    Id = new Guid("16C08968-1869-439A-A403-4F9757B96594"),
                    Name = "Kümmel"
                },
                new()
                {
                    Id = new Guid("F5AF8933-3F28-4D0C-BE9F-7C86743D25A0"),
                    Name = "Minze"
                },
                new()
                {
                    Id = new Guid("2587BD92-A90E-450B-9E78-BF0231A046DC"),
                    Name = "Oregano"
                },
                new()
                {
                    Id = new Guid("95D6E787-81A6-435C-A6A9-2AEA905EC3D3"),
                    Name = "Petersilie"
                },
                new()
                {
                    Id = new Guid("A6AF90E8-C94D-4D55-86E7-0E3D523AA83D"),
                    Name = "Salbei"
                },
                new()
                {
                    Id = new Guid("0A728168-51A5-4AD7-AC8C-876AFCE21B78"),
                    Name = "Schnittlauch"
                },
                new()
                {
                    Id = new Guid("8FC4AE53-EC57-45A5-9788-DAF495BD3111"),
                    Name = "Thymian"
                },
                new()
                {
                    Id = new Guid("0D6E5DD3-E41D-4CD5-A639-7C0A9D69549D"),
                    Name = "Wurzelpetersilie"
                },
                new()
                {
                    Id = new Guid("95010393-342E-4C36-90D0-8D5C9D0C13DC"),
                    Name = "Zitronenmelisse"
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
                    From = "Juni",
                    To = "September"
                },
                new()
                {
                    Id = new Guid("0D3993D4-3848-4BDF-86DC-571DAD3698BC"),
                    HerbId = herbs.First(herb => herb.Name == "Bockshornklee").Id,
                    From = "August",
                    To = "September"
                },
                new()
                {
                    Id = new Guid("D1B60B24-0A69-4848-AFCC-A8336E0C018C"),
                    HerbId = herbs.First(herb => herb.Name == "Borretsch").Id,
                    From = "Juni",
                    To = "August"
                },
                new()
                {
                    Id = new Guid("0C60496A-80DC-422C-8A93-3555C94634FA"),
                    HerbId = herbs.First(herb => herb.Name == "Bärlauch").Id,
                    From = "März",
                    To = "Juni"
                },
                new()
                {
                    Id = new Guid("6B99A058-93D3-47DA-A5F0-2A614D253754"),
                    HerbId = herbs.First(herb => herb.Name == "Dill").Id,
                    From = "April",
                    To = "September"
                },
                new()
                {
                    Id = new Guid("06B9C5A0-D6D9-40F5-B4B5-BF4EBA20986A"),
                    HerbId = herbs.First(herb => herb.Name == "Estragon").Id,
                    From = "Mai",
                    To = "Oktober"
                },
                new()
                {
                    Id = new Guid("3B2C6149-86EE-4444-B9B2-BB903515788D"),
                    HerbId = herbs.First(herb => herb.Name == "Kerbel").Id,
                    From = "April",
                    To = "Oktober"
                },
                new()
                {
                    Id = new Guid("4EF6E92A-5165-4197-8AB3-3DFAAA056C1A"),
                    HerbId = herbs.First(herb => herb.Name == "Knoblauch").Id,
                    From = "Juni",
                    To = "August"
                },
                new()
                {
                    Id = new Guid("C72EA7B9-E4C6-4A83-B1F1-22FCCF8074DF"),
                    HerbId = herbs.First(herb => herb.Name == "Kresse").Id,
                    From = "Januar",
                    To = "Dezember"
                },
                new()
                {
                    Id = new Guid("2E44A90E-2A59-47B3-B071-1E45E18512F8"),
                    HerbId = herbs.First(herb => herb.Name == "Kümmel").Id,
                    From = "Mai",
                    To = "Mai"
                },
                new()
                {
                    Id = new Guid("0EF4791A-DB80-4C47-8C9B-083DFFDDC014"),
                    HerbId = herbs.First(herb => herb.Name == "Kümmel").Id,
                    From = "August",
                    To = "Oktober"
                },
                new()
                {
                    Id = new Guid("4E7015AE-1E7E-4393-A1C9-ED94D0AFC3A0"),
                    HerbId = herbs.First(herb => herb.Name == "Minze").Id,
                    From = "Mai",
                    To = "September"
                },
                new()
                {
                    Id = new Guid("BECC6315-8D28-43DA-A16B-90925A460E13"),
                    HerbId = herbs.First(herb => herb.Name == "Oregano").Id,
                    From = "April",
                    To = "Oktober"
                },
                new()
                {
                    Id = new Guid("341E37B3-6FD4-4DB2-96F3-8D90E861F4A2"),
                    HerbId = herbs.First(herb => herb.Name == "Petersilie").Id,
                    From = "April",
                    To = "Oktober"
                },
                new()
                {
                    Id = new Guid("1118EE13-7D7B-4FCC-85B5-CAAEA124DAAD"),
                    HerbId = herbs.First(herb => herb.Name == "Salbei").Id,
                    From = "April",
                    To = "November"
                },
                new()
                {
                    Id = new Guid("F4DB0E30-AC74-44CE-9DBD-235675C94559"),
                    HerbId = herbs.First(herb => herb.Name == "Schnittlauch").Id,
                    From = "April",
                    To = "Oktober"
                },
                new()
                {
                    Id = new Guid("C9276DFD-AC0A-4A95-A3C1-DAD38F38D3AA"),
                    HerbId = herbs.First(herb => herb.Name == "Thymian").Id,
                    From = "März",
                    To = "Oktober"
                },
                new()
                {
                    Id = new Guid("28A1FD0C-1AD5-4045-AA3D-73DC96235A83"),
                    HerbId = herbs.First(herb => herb.Name == "Wurzelpetersilie").Id,
                    From = "Januar",
                    To = "April"
                },
                new()
                {
                    Id = new Guid("0623177E-602B-4855-90CA-34B262C343C5"),
                    HerbId = herbs.First(herb => herb.Name == "Wurzelpetersilie").Id,
                    From = "Oktober",
                    To = "Dezember"
                },
                new()
                {
                    Id = new Guid("B5A6F36A-27CB-4053-9472-8F781821D4E8"),
                    HerbId = herbs.First(herb => herb.Name == "Zitronenmelisse").Id,
                    From = "April",
                    To = "Oktober"
                }
            };

            modelBuilder.Entity<Season>().HasData(seasons);
        }
    }
}
