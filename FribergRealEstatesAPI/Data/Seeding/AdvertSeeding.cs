using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Seeding
{
    //Auth: Hamza
    public class AdvertSeeding
    {
        public static async Task SeedAdvert(ApiDbContext context)
        {
            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()

            });
            await context.SaveChangesAsync();
        }
    }
}
