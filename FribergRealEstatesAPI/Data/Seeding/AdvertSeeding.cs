using FribergRealEstatesAPI.Models;
using System.Linq;

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

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 3200000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 1800000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4500000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2900000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 3700000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2100000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 5200000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 3500000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4100000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2700000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 3100000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2300000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4600000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2800000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 3600000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2200000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 5100000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 3400000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4000000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2600000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4900000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 3300000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4200000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2900000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 3800000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2400000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 5300000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 3500000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4300000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2700000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4800000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 3200000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4400000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2800000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 3900000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2500000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 5000000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 3300000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4100000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2900000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 3700000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2400000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 5200000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 3400000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4200000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2700000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4900000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 3100000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4500000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2800000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 3600000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2300000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 5100000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 3400000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4000000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2600000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4900000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 3300000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4200000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2900000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 3800000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2400000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 5300000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 3500000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4300000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 2700000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4800000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = true,
                CurrentPrice = 3200000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });

            context.Adverts.Add(new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = false,
                CurrentPrice = 4400000,
                Realtor = context.Realtors.OrderBy(x => Guid.NewGuid()).First(),
                Residence = context.Residences.OrderBy(x => Guid.NewGuid()).First()
            });
            await context.SaveChangesAsync();
        }
    }
}
