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
                Type = ResidenceType.Apartment,
                Area = 75,
                BiArea = 5,
                Floors = 1,
                Description = "Modern apartment in city center",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 1200,
                OperatingCost = 3500,
                Facilities = new List<Facilities>
                {
                    Facilities.Balcony,
                    Facilities.ParkingLot,
                    Facilities.Elevator
                },
                BuildYear = 2010,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1560448204-e02f11c3d0e2",
                    "https://images.unsplash.com/photo-1493809842364-78817add7ffb"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 110,
                BiArea = 15,
                Floors = 2,
                Description = "Spacious family apartment",
                Rooms = 4,
                FloorRows = 2,
                MonthlyFee = 1800,
                OperatingCost = 4500,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Elevator,
                    Facilities.Balcony,
                    Facilities.Terrace
                },
                BuildYear = 2015,
                IsAvailable = false,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1512917774080-9991f1c4c750",
                    "https://images.unsplash.com/photo-1583847268964-b28dc8f51f92"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 65,
                BiArea = 0,
                Floors = 1,
                Description = "Cozy studio apartment",
                Rooms = 1,
                FloorRows = 1,
                MonthlyFee = 900,
                OperatingCost = 3000,
                Facilities = new List<Facilities>
                {
                    Facilities.Balcony
                },
                BuildYear = 2005,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1502672260266-1c1ef2d93688",
                    "https://images.unsplash.com/photo-1484154218962-a197022b5858"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 85,
                BiArea = 10,
                Floors = 3,
                Description = "Penthouse with great view",
                Rooms = 3,
                FloorRows = 2,
                MonthlyFee = 2000,
                OperatingCost = 5000,
                Facilities = new List<Facilities>
                {
                    Facilities.Balcony,
                    Facilities.ParkingLot,
                    Facilities.Elevator,
                    Facilities.Terrace,
                    Facilities.Pool
                },
                BuildYear = 2018,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1564013799919-ab600027ffc6",
                    "https://images.unsplash.com/photo-1580587771525-78b9dba3b914"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 95,
                BiArea = 12,
                Floors = 2,
                Description = "Renovated classic apartment",
                Rooms = 3,
                FloorRows = 2,
                MonthlyFee = 1500,
                OperatingCost = 4000,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Elevator,
                    Facilities.NewProduction
                },
                BuildYear = 1995,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1522708323590-d24dbb6b0267",
                    "https://images.unsplash.com/photo-1486304873000-235643847519"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 120,
                BiArea = 30,
                Floors = 2,
                Description = "Suburban family house",
                Rooms = 5,
                FloorRows = 2,
                MonthlyFee = 2200,
                OperatingCost = 6000,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace,
                    Facilities.Pool
                },
                BuildYear = 2012,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1600585154340-be6161a56a0c",
                    "https://images.unsplash.com/photo-1605276374104-dee2a0ed3cd6"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 150,
                BiArea = 50,
                Floors = 3,
                Description = "Large countryside house",
                Rooms = 6,
                FloorRows = 3,
                MonthlyFee = 2800,
                OperatingCost = 7000,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace,
                    Facilities.Pool,
                    Facilities.NewProduction
                },
                BuildYear = 2008,
                IsAvailable = false,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1605146769289-440113cc3d00",
                    "https://images.unsplash.com/photo-1600607687920-4e2a09cf159d"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 100,
                BiArea = 20,
                Floors = 1,
                Description = "Small bungalow",
                Rooms = 3,
                FloorRows = 1,
                MonthlyFee = 1700,
                OperatingCost = 4500,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace
                },
                BuildYear = 2019,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1600566752355-35792bedcfea",
                    "https://images.unsplash.com/photo-1600607688969-a5bfcd646154"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 180,
                BiArea = 60,
                Floors = 2,
                Description = "Luxury villa",
                Rooms = 7,
                FloorRows = 2,
                MonthlyFee = 3500,
                OperatingCost = 8000,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace,
                    Facilities.Pool,
                    Facilities.NewProduction
                },
                BuildYear = 2020,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1613490493576-7fde63acd811",
                    "https://images.unsplash.com/photo-1600585152220-90363fe7e115"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 90,
                BiArea = 15,
                Floors = 1,
                Description = "Cozy cottage",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 1300,
                OperatingCost = 3800,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace
                },
                BuildYear = 2000,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1605276374104-dee2a0ed3cd6",
                    "https://images.unsplash.com/photo-1600607687920-4e2a09cf159d"
                }
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.VacationHouse,
                Area = 80,
                BiArea = 20,
                Floors = 1,
                Description = "Beachfront vacation home",
                Rooms = 3,
                FloorRows = 1,
                MonthlyFee = 1500,
                OperatingCost = 4000,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace,
                    Facilities.Pool
                },
                BuildYear = 2015,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1512917774080-9991f1c4c750",
                    "https://images.unsplash.com/photo-1583847268964-b28dc8f51f92"
                }
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.VacationHouse,
                Area = 110,
                BiArea = 30,
                Floors = 2,
                Description = "Mountain cabin",
                Rooms = 4,
                FloorRows = 2,
                MonthlyFee = 1900,
                OperatingCost = 5000,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace
                },
                BuildYear = 2010,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1484154218962-a197022b5858",
                    "https://images.unsplash.com/photo-1560448204-e02f11c3d0e2"
                }
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.VacationHouse,
                Area = 60,
                BiArea = 10,
                Floors = 1,
                Description = "Small lakeside retreat",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 1200,
                OperatingCost = 3500,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace
                },
                BuildYear = 2005,
                IsAvailable = false,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1493809842364-78817add7ffb",
                    "https://images.unsplash.com/photo-1502672260266-1c1ef2d93688"
                }
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.VacationHouse,
                Area = 130,
                BiArea = 40,
                Floors = 2,
                Description = "Ski chalet",
                Rooms = 5,
                FloorRows = 2,
                MonthlyFee = 2500,
                OperatingCost = 6500,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace,
                    Facilities.NewProduction
                },
                BuildYear = 2018,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1580587771525-78b9dba3b914",
                    "https://images.unsplash.com/photo-1564013799919-ab600027ffc6"
                }
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.VacationHouse,
                Area = 70,
                BiArea = 15,
                Floors = 1,
                Description = "Forest getaway",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 1100,
                OperatingCost = 3200,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace
                },
                BuildYear = 2012,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1522708323590-d24dbb6b0267",
                    "https://images.unsplash.com/photo-1486304873000-235643847519"
                }
            });
            await context.SaveChangesAsync();
        }
    }
}
