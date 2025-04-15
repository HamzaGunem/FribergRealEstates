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
            context.Agencies.Add(new Agency
            {
                Name = "Elite Living Properties",
                Description = "Premium real estate agency focusing on modern penthouses and waterfront properties in Gothenburg. Known for innovative design solutions.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/elite-living.png",
                Realtors = new[] {
                    new Realtor {
                        FirstName = "Emma",
                        LastName = "Bergman",
                        Email = "emma.bergman@eliteliving.se",
                        PhoneNumber = "0712345678",
                        PictureUrl = "https://example.com/realtors/emma-bergman.jpg",
                    }
                }
            });

            context.Agencies.Add(new Agency
            {
                Name = "Nordic Haven Realty",
                Description = "Specialists in sustainable and eco-friendly homes across Scandinavia. Winner of Green Real Estate Award 2023.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/nordic-haven.png",
                Realtors = new[] {
                    new Realtor {
                        FirstName = "Lars",
                        LastName = "Nilsson",
                        Email = "lars.nilsson@nordichaven.com",
                        PhoneNumber = "0723456789",
                        PictureUrl = "https://example.com/realtors/lars-nilsson.jpg",
                    }
                }
            });
            context.Agencies.Add(new Agency
            {
                Name = "Scandinavian Design Living",
                Description = "Curated selection of mid-century modern and contemporary design homes. Partnered with leading interior designers.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/scandi-design.png",
                Realtors = new[] {
                    new Realtor {
                        FirstName = "Marcus",
                        LastName = "Lundqvist",
                        Email = "marcus@scandidesign.se",
                        PhoneNumber = "0789012345",
                        PictureUrl = "https://example.com/realtors/marcus-lundqvist.jpg",
                    }
                }
            });
            context.Agencies.Add(new Agency
            {
                Name = "Urban Edge Properties",
                Description = "Boutique agency specializing in trendy lofts and converted industrial spaces in Malmö's up-and-coming neighborhoods.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/urban-edge.png",
                Realtors = new[] {
                    new Realtor {
                        FirstName = "Sofia",
                        LastName = "Andersson",
                        Email = "sofia@urbanedge.se",
                        PhoneNumber = "0734567890",
                        PictureUrl = "https://example.com/realtors/sofia-andersson.jpg",
                    }
                }
            });
            context.Agencies.Add(new Agency
            {
                Name = "Lakeside Estates",
                Description = "Experts in luxury lakefront properties throughout Sweden's picturesque countryside. Family-owned since 1985.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/lakeside.png",
                Realtors = new[] {
                    new Realtor {
                        FirstName = "Anders",
                        LastName = "Johansson",
                        Email = "anders.j@lakeside.se",
                        PhoneNumber = "0745678901",
                        PictureUrl = "https://example.com/realtors/anders-johansson.jpg"
                    }
                }
            });
            context.Agencies.Add(new Agency
            {
                Name = "Capital Homes",
                Description = "The leading agency for diplomatic and expat housing solutions in Stockholm. Multilingual staff available 24/7.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/capital-homes.png",
                Realtors = new[] {
                    new Realtor {
                        FirstName = "Maria",
                        LastName = "Lindgren",
                        Email = "mlindgren@capitalhomes.se",
                        PhoneNumber = "0756789012",
                        PictureUrl = "https://example.com/realtors/maria-lindgren.jpg",
                    }
                }
            });
            context.Agencies.Add(new Agency
            {
                Name = "Alpine Retreats",
                Description = "Specialists in mountain chalets and ski-in/ski-out properties in Åre and other premium alpine locations.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/alpine-retreats.png",
                Realtors = new[] {
                    new Realtor {
                        FirstName = "Johan",
                        LastName = "Ström",
                        Email = "johan.strom@alpine.se",
                        PhoneNumber = "0767890123",
                        PictureUrl = "https://example.com/realtors/johan-strom.jpg",
                    }
                }
            });

            context.Agencies.Add(new Agency
            {
                Name = "Historic Homes Sweden",
                Description = "Dedicated to preserving and selling Sweden's architectural heritage. Specialists in castles, manors, and listed properties.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/historic-homes.png",
                Realtors = new[] {
                    new Realtor {
                        FirstName = "Elin",
                        LastName = "Vikström",
                        Email = "elin@historichomes.se",
                        PhoneNumber = "0778901234",
                        PictureUrl = "https://example.com/realtors/elin-vikstrom.jpg",
                    }
                }
            });

            context.Agencies.Add(new Agency
            {
                Name = "Coastal Properties Sweden",
                Description = "Experts in archipelago and coastal real estate from Bohuslän to Österlen. Boat and dock specialists.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/coastal-properties.png",
                Realtors = new[] {
                    new Realtor {
                        FirstName = "Anna",
                        LastName = "Sandberg",
                        Email = "anna.sandberg@coastal.se",
                        PhoneNumber = "0790123456",
                        PictureUrl = "https://example.com/realtors/anna-sandberg.jpg",
                    }
                }
            });

            context.Agencies.Add(new Agency
            {
                Name = "Smart City Living",
                Description = "Innovative agency focusing on smart homes and tech-integrated properties in Sweden's urban centers.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/smart-city.png",
                Realtors = new[] {
                    new Realtor {
                        FirstName = "David",
                        LastName = "Techsson",
                        Email = "david@smartcity.se",
                        PhoneNumber = "0701234567",
                        PictureUrl = "https://example.com/realtors/david-techsson.jpg",
                    }
                }
            });

            context.Agencies.Add(new Agency
            {
                Name = "Nordic Haven Realty",
                Description = "Specialists in sustainable and eco-friendly homes across Scandinavia. Winner of Green Real Estate Award 2023.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://example.com/logos/nordic-haven.png",
                Realtors = new[] {
                    new Realtor {
                        FirstName = "Lars",
                        LastName = "Nilsson",
                        Email = "lars.nilsson@nordichaven.com",
                        PhoneNumber = "0723456789",
                        PictureUrl = "https://example.com/realtors/lars-nilsson.jpg",
                    }
                }
            });
            await context.SaveChangesAsync();
        }
    }
}
