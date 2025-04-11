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
            await context.SaveChangesAsync();
        }
    }
}
