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
                CurrentPrice = 1500000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            // Advert 2
            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2200000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            // Advert 3
            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 1800000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            // Advert 4
            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2500000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            // Advert 5
            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 1900000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            // Advert 6
            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2100000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            // Advert 7
            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 1700000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            // Advert 8
            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2300000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            // Advert 9
            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 1600000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            // Advert 10
            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2400000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });
            await context.SaveChangesAsync();
        }
    }
}
