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
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS0OvDqAb4obi8MFFOvja3tarDQ_kRGwNctxg&s",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Elite Living Properties",
                Description = "Premium real estate agency focusing on modern penthouses and waterfront properties in Gothenburg. Known for innovative design solutions.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/elite-living.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Nordic Haven Realty",
                Description = "Specialists in sustainable and eco-friendly homes across Scandinavia. Winner of Green Real Estate Award 2023.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/nordic-haven.png",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Scandinavian Design Living",
                Description = "Curated selection of mid-century modern and contemporary design homes. Partnered with leading interior designers.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/scandi-design.png",
 
            });
            context.Agencies.Add(new Agency
            {
                Name = "Urban Edge Properties",
                Description = "Boutique agency specializing in trendy lofts and converted industrial spaces in Malmö's up-and-coming neighborhoods.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/urban-edge.png",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Lakeside Estates",
                Description = "Experts in luxury lakefront properties throughout Sweden's picturesque countryside. Family-owned since 1985.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/lakeside.png",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Capital Homes",
                Description = "The leading agency for diplomatic and expat housing solutions in Stockholm. Multilingual staff available 24/7.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/capital-homes.png",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Alpine Retreats",
                Description = "Specialists in mountain chalets and ski-in/ski-out properties in Åre and other premium alpine locations.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/alpine-retreats.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Historic Homes Sweden",
                Description = "Dedicated to preserving and selling Sweden's architectural heritage. Specialists in castles, manors, and listed properties.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/historic-homes.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Coastal Properties Sweden",
                Description = "Experts in archipelago and coastal real estate from Bohuslän to Österlen. Boat and dock specialists.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/coastal-properties.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Smart City Living",
                Description = "Innovative agency focusing on smart homes and tech-integrated properties in Sweden's urban centers.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/smart-city.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Nordic Haven Realty",
                Description = "Specialists in sustainable and eco-friendly homes across Scandinavia. Winner of Green Real Estate Award 2023.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/nordic-haven.png",
            });
            await context.SaveChangesAsync();
        }
    }
}
