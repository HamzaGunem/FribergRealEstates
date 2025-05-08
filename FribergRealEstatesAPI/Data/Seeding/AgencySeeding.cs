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
                //LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS0OvDqAb4obi8MFFOvja3tarDQ_kRGwNctxg&s",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Elite Living Properties",
                Description = "Premium real estate agency focusing on modern penthouses and waterfront properties in Gothenburg. Known for innovative design solutions.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/elite-living.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Nordic Haven Realty",
                Description = "Specialists in sustainable and eco-friendly homes across Scandinavia. Winner of Green Real Estate Award 2023.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/nordic-haven.png",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Scandinavian Design Living",
                Description = "Curated selection of mid-century modern and contemporary design homes. Partnered with leading interior designers.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/scandi-design.png",
 
            });
            context.Agencies.Add(new Agency
            {
                Name = "Urban Edge Properties",
                Description = "Boutique agency specializing in trendy lofts and converted industrial spaces in Malmö's up-and-coming neighborhoods.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/urban-edge.png",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Lakeside Estates",
                Description = "Experts in luxury lakefront properties throughout Sweden's picturesque countryside. Family-owned since 1985.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/lakeside.png",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Capital Homes",
                Description = "The leading agency for diplomatic and expat housing solutions in Stockholm. Multilingual staff available 24/7.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/capital-homes.png",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Alpine Retreats",
                Description = "Specialists in mountain chalets and ski-in/ski-out properties in Åre and other premium alpine locations.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/alpine-retreats.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Historic Homes Sweden",
                Description = "Dedicated to preserving and selling Sweden's architectural heritage. Specialists in castles, manors, and listed properties.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/historic-homes.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Coastal Properties Sweden",
                Description = "Experts in archipelago and coastal real estate from Bohuslän to Österlen. Boat and dock specialists.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/coastal-properties.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Smart City Living",
                Description = "Innovative agency focusing on smart homes and tech-integrated properties in Sweden's urban centers.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/smart-city.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Nordic Haven Realty",
                Description = "Specialists in sustainable and eco-friendly homes across Scandinavia. Winner of Green Real Estate Award 2023.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/nordic-haven.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Luxe Villas Sweden",
                Description = "Specializes in high-end villas and estates in the Stockholm archipelago. Offers bespoke services for discerning clients.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/luxe-villas.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Urban Oasis Realty",
                Description = "Focuses on green and sustainable urban living spaces in Gothenburg. Promotes eco-friendly housing solutions.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/urban-oasis.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Scandinavian Chalets",
                Description = "Provides exclusive mountain and ski properties in Sweden's northern regions. Known for luxury winter retreats.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/scandinavian-chalets.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Royal Estates Sweden",
                Description = "Deals in premium and historic properties across Sweden. Caters to high-net-worth individuals and families.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/royal-estates.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Modern Living Spaces",
                Description = "Offers contemporary and minimalist homes in Malmö. Collaborates with renowned architects for unique designs.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/modern-living.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Eco Homes Sweden",
                Description = "Specializes in energy-efficient and sustainable homes across Sweden. Committed to reducing carbon footprints.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/eco-homes.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Nordic Luxury Realty",
                Description = "Provides luxury real estate services in Sweden's most desirable locations. Known for exceptional client service.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/nordic-luxury.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Historic Mansions Sweden",
                Description = "Specialists in historic and heritage properties across Sweden. Offers expertise in preservation and restoration.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/historic-mansions.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Seaside Retreats",
                Description = "Focuses on coastal and waterfront properties along Sweden's west coast. Offers properties with stunning sea views.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/seaside-retreats.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Tech Homes Sweden",
                Description = "Specializes in smart and technology-integrated homes in Sweden's major cities. Promotes modern living solutions.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/tech-homes.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Green Living Sweden",
                Description = "Specializes in eco-friendly and sustainable homes in rural and urban areas. Promotes green living initiatives.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
               //LogoUrl = "https://example.com/logos/green-living.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Nordic Dream Homes",
                Description = "Offers a curated selection of dream homes across Sweden. Known for exceptional customer service and unique properties.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/nordic-dream.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Luxury Waterfront Living",
                Description = "Specializes in high-end waterfront properties in Stockholm and its archipelago. Caters to luxury property seekers.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/luxury-waterfront.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Urban Chic Properties",
                Description = "Focuses on stylish and modern apartments in Sweden's urban centers. Known for trendy and upscale listings.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/urban-chic.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Scandinavian Heritage Homes",
                Description = "Specialists in historic and culturally significant properties across Sweden. Preserves and promotes heritage sites.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/heritage-homes.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Coastal Dreams Realty",
                Description = "Offers premium coastal properties along Sweden's eastern coast. Specializes in beachfront and seaside homes.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/coastal-dreams.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Modern Nordic Living",
                Description = "Provides contemporary and innovative homes in Sweden's major cities. Collaborates with top architects and designers.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/modern-nordic.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Eco Retreats Sweden",
                Description = "Specializes in sustainable retreats and eco-friendly getaways in Sweden's countryside. Promotes green tourism.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/eco-retreats.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Luxe Nordic Estates",
                Description = "Offers luxury estates and high-end properties in exclusive locations across Sweden. Caters to affluent clients.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/luxe-nordic.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Historic Charm Properties",
                Description = "Specializes in charming and historic homes in Sweden's rural and urban areas. Preserves architectural heritage.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/historic-charm.png",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Nordic Luxe Retreats",
                Description = "Specializes in luxury retreats and exclusive getaways in Sweden's most scenic locations. Caters to high-end clientele.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/nordic-luxe-retreats.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Urban Green Spaces",
                Description = "Focuses on urban properties with green spaces and eco-friendly features. Promotes sustainable city living.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/urban-green.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Scandinavian Lake Homes",
                Description = "Offers a selection of premium lakefront properties across Sweden. Specializes in waterfront living.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/lake-homes.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Modern Scandi Living",
                Description = "Provides modern and minimalist homes in Sweden's urban areas. Known for sleek and contemporary designs.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/modern-scandi.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Eco Nordic Homes",
                Description = "Specializes in eco-friendly and sustainable homes across Sweden. Promotes green building practices.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/eco-nordic.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Luxury Nordic Estates",
                Description = "Offers luxury estates and high-end properties in Sweden's most desirable locations. Caters to affluent clients.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/luxury-nordic-estates.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Historic Swedish Mansions",
                Description = "Specializes in historic and heritage properties across Sweden. Preserves and promotes cultural heritage.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/historic-swedish.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Coastal Living Sweden",
                Description = "Focuses on coastal and waterfront properties along Sweden's beautiful coastlines. Offers stunning sea views.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/coastal-living.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Tech Integrated Homes",
                Description = "Specializes in smart and technology-integrated homes in Sweden's urban centers. Promotes modern living solutions.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/tech-integrated.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Nordic Dream Estates",
                Description = "Offers a curated selection of dream homes and luxury properties across Sweden. Known for exceptional service.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                //LogoUrl = "https://example.com/logos/nordic-dream-estates.png",
            });


            await context.SaveChangesAsync();
        }
    }
}
