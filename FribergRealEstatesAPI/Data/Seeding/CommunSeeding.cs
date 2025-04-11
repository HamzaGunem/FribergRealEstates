using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Seeding

{
    //Auth: Hamza
    public class CommunSeeding
    {
        //Seed Commun and Addresses
        public static async Task SeedCommun(ApiDbContext context)
        {
            context.Communs.Add(new Commun
            {
                Name = "Uppsala",
                Addresses = new[] {
                    new Address
                    {
                        City = "Uppsala",
                        Street = "Grindstugegatan7",
                        PostalCode = "75257"
                    },
                       new Address
                    {
                        City = "Uppsala",
                        Street = "Grindstugegatan14",
                        PostalCode = "75262"
                    },
                }
            });
            context.Communs.Add(new Commun
            {
                Name = "Luleå",
                Addresses = new[] {
                    new Address
                    {
                        City = "Luleå",
                        Street = "Mjölkuddsvägen143",
                        PostalCode = "97371"
                    },
                       new Address
                    {
                        City = "Luleå",
                        Street = "Lingonstigen14",
                        PostalCode = "97382"
                    },
                }
            });
            await context.SaveChangesAsync();

        }
    }
}
