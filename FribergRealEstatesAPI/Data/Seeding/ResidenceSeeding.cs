using FribergRealEstatesAPI.Constants;
using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Seeding
{
    //Auth: Hamza
    public class ResidenceSeeding
    {
        public static async Task SeedResidences(ApiDbContext context)
        {
            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 75,
                BiArea = 5,
                Floors = 1,
                Description = "Modern apartment in city center",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 1200,
                OperatingCost = 3500,
                BuildYear = 2010,
                IsAvailable = true,
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 110,
                BiArea = 15,
                Floors = 2,
                Description = "Spacious family apartment",
                Rooms = 4,
                FloorRows = 2,
                MonthlyFee = 1800,
                OperatingCost = 4500,
                BuildYear = 2015,
                IsAvailable = false,
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 65,
                BiArea = 0,
                Floors = 1,
                Description = "Cozy studio apartment",
                Rooms = 1,
                FloorRows = 1,
                MonthlyFee = 900,
                OperatingCost = 3000,
                BuildYear = 2005,
                IsAvailable = true,
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 85,
                BiArea = 10,
                Floors = 3,
                Description = "Penthouse with great view",
                Rooms = 3,
                FloorRows = 2,
                MonthlyFee = 2000,
                OperatingCost = 5000,
                BuildYear = 2018,
                IsAvailable = true,
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 95,
                BiArea = 12,
                Floors = 2,
                Description = "Renovated classic apartment",
                Rooms = 3,
                FloorRows = 2,
                MonthlyFee = 1500,
                OperatingCost = 4000,
                BuildYear = 1995,
                IsAvailable = true,
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 120,
                BiArea = 30,
                Floors = 2,
                Description = "Suburban family house",
                Rooms = 5,
                FloorRows = 2,
                MonthlyFee = 2200,
                OperatingCost = 6000,
                BuildYear = 2012,
                IsAvailable = true,
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 150,
                BiArea = 50,
                Floors = 3,
                Description = "Large countryside house",
                Rooms = 6,
                FloorRows = 3,
                MonthlyFee = 2800,
                OperatingCost = 7000,
                BuildYear = 2008,
                IsAvailable = false,
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 100,
                BiArea = 20,
                Floors = 1,
                Description = "Small bungalow",
                Rooms = 3,
                FloorRows = 1,
                MonthlyFee = 1700,
                OperatingCost = 4500,
                BuildYear = 2019,
                IsAvailable = true,
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 180,
                BiArea = 60,
                Floors = 2,
                Description = "Luxury villa",
                Rooms = 7,
                FloorRows = 2,
                MonthlyFee = 3500,
                OperatingCost = 8000,
                BuildYear = 2020,
                IsAvailable = true,
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 90,
                BiArea = 15,
                Floors = 1,
                Description = "Cozy cottage",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 1300,
                OperatingCost = 3800,
                BuildYear = 2000,
                IsAvailable = true,
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 80,
                BiArea = 20,
                Floors = 1,
                Description = "Beachfront vacation home",
                Rooms = 3,
                FloorRows = 1,
                MonthlyFee = 1500,
                OperatingCost = 4000,
                BuildYear = 2015,
                IsAvailable = true,
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 110,
                BiArea = 30,
                Floors = 2,
                Description = "Mountain cabin",
                Rooms = 4,
                FloorRows = 2,
                MonthlyFee = 1900,
                OperatingCost = 5000,
                BuildYear = 2010,
                IsAvailable = true,
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 60,
                BiArea = 10,
                Floors = 1,
                Description = "Small lakeside retreat",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 1200,
                OperatingCost = 3500,
                BuildYear = 2005,
                IsAvailable = false,
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 130,
                BiArea = 40,
                Floors = 2,
                Description = "Ski chalet",
                Rooms = 5,
                FloorRows = 2,
                MonthlyFee = 2500,
                OperatingCost = 6500,
                BuildYear = 2018,
                IsAvailable = true,
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Area = 70,
                BiArea = 15,
                Floors = 1,
                Description = "Forest getaway",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 1100,
                OperatingCost = 3200,
                BuildYear = 2012,
                IsAvailable = true,
            });
            await context.SaveChangesAsync();
        }
    }
}
