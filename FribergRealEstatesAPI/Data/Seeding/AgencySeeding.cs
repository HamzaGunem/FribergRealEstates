using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Seeding
{
    //Auth: Hamza
    public class AgencySeeding
    {
        public static async Task SeedAgency(ApiDbContext context)
        {
            context.Agencies.Add(new Agency
            {
                Name = "Drömhem Fastigheter",
                Description = "Specialiserar sig på lyxvillor och exklusiva bostäder i Stockholms innerstad och omnejd. Erbjuder personlig service och hög kompetens inom lyxbostäder.",
                Address = context.Address.First(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS0OvDqAb4obi8MFFOvja3tarDQ_kRGwNctxg&s",
                Realtors = new[] {
                    new Realtor {
                        FirstName = "Oscar",
                        LastName = "Hasselot",
                        Email = "oscar.hasselot@gmail.com",
                        PhoneNumber = "070000000",
                        PictureUrl = "https://www.dagensarena.se/files/2025/02/donald-trump-februari-2025-920x480.jpeg",
                    }
                }
            });
            await context.SaveChangesAsync();
        }
    }
}
