using FribergRealEstatesAPI.Constants;
using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Seeding
{
    public class ResidenceSeeding
    {
        public static async Task SeedResidences(ApiDbContext context)
        {
            context.Residences.Add(new Residence
            {
                Address = context.Address.FirstOrDefault(x => x.Id == 4),
                StartPrice = 2000000,
                beArea = 90,
                Description = "sdsadsadsaxcvfvfvvng",
                Rooms = 3,
                FloorRows = 2,
                MonthlyFee = 1000,
                OperatingCost = 4000,
                BuildYear = 2002,
                Sold = false,
                IsAvailable = true,
                Realtor = context.Realtors.First()
            });
            context.Residences.Add(new Residence
            {
                Address = context.Address.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                StartPrice = 1800000,
                beArea = 85,
                Description = "Modern apartment with great views",
                Rooms = 2,
                FloorRows = 3,
                MonthlyFee = 1200,
                OperatingCost = 3500,
                BuildYear = 2010,
                Sold = false,
                IsAvailable = true,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).FirstOrDefault()
            });

            context.Residences.Add(new Residence
            {
                Address = context.Address.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                StartPrice = 3200000,
                beArea = 120,
                Description = "Spacious family home with garden",
                Rooms = 4,
                FloorRows = 1,
                MonthlyFee = 1500,
                OperatingCost = 5000,
                BuildYear = 1995,
                Sold = false,
                IsAvailable = true,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).FirstOrDefault()
            });

            context.Residences.Add(new Residence
            {
                Address = context.Address.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                StartPrice = 2500000,
                beArea = 95,
                Description = "Renovated apartment in central location",
                Rooms = 3,
                FloorRows = 4,
                MonthlyFee = 1300,
                OperatingCost = 4200,
                BuildYear = 2005,
                Sold = true,
                IsAvailable = false,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).FirstOrDefault()
            });

            context.Residences.Add(new Residence
            {
                Address = context.Address.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                StartPrice = 1500000,
                beArea = 75,
                Description = "Cozy studio perfect for singles",
                Rooms = 1,
                FloorRows = 5,
                MonthlyFee = 900,
                OperatingCost = 3000,
                BuildYear = 2015,
                Sold = false,
                IsAvailable = true,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).FirstOrDefault()
            });

            context.Residences.Add(new Residence
            {
                Address = context.Address.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                StartPrice = 2800000,
                beArea = 110,
                Description = "Luxury penthouse with terrace",
                Rooms = 3,
                FloorRows = 8,
                MonthlyFee = 1800,
                OperatingCost = 6000,
                BuildYear = 2018,
                Sold = false,
                IsAvailable = true,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).FirstOrDefault()
            });

            context.Residences.Add(new Residence
            {
                Address = context.Address.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                StartPrice = 1950000,
                beArea = 88,
                Description = "Bright apartment with balcony",
                Rooms = 2,
                FloorRows = 2,
                MonthlyFee = 1100,
                OperatingCost = 3800,
                BuildYear = 2008,
                Sold = false,
                IsAvailable = true,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).FirstOrDefault()
            });

            context.Residences.Add(new Residence
            {
                Address = context.Address.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                StartPrice = 4200000,
                beArea = 150,
                Description = "Exclusive villa with pool",
                Rooms = 5,
                FloorRows = 1,
                MonthlyFee = 2500,
                OperatingCost = 8000,
                BuildYear = 2012,
                Sold = false,
                IsAvailable = true,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).FirstOrDefault()
            });

            context.Residences.Add(new Residence
            {
                Address = context.Address.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                StartPrice = 2300000,
                beArea = 92,
                Description = "Modern loft-style apartment",
                Rooms = 2,
                FloorRows = 6,
                MonthlyFee = 1400,
                OperatingCost = 4500,
                BuildYear = 2016,
                Sold = true,
                IsAvailable = false,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).FirstOrDefault()
            });

            context.Residences.Add(new Residence
            {
                Address = context.Address.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                StartPrice = 1650000,
                beArea = 78,
                Description = "Affordable first-time buyer option",
                Rooms = 2,
                FloorRows = 3,
                MonthlyFee = 950,
                OperatingCost = 3200,
                BuildYear = 2000,
                Sold = false,
                IsAvailable = true,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).FirstOrDefault()
            });

            context.Residences.Add(new Residence
            {
                Address = context.Address.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                StartPrice = 3500000,
                beArea = 125,
                Description = "Premium duplex in quiet area",
                Rooms = 4,
                FloorRows = 2,
                MonthlyFee = 1700,
                OperatingCost = 5500,
                BuildYear = 2014,
                Sold = false,
                IsAvailable = true,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).FirstOrDefault()
            });
            await context.SaveChangesAsync();
        }
    }
}
