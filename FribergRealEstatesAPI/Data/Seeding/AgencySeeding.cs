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
                LogoUrl = "https://image.spreadshirtmedia.com/image-server/v1/products/T1459A839PA3861PT28D1039185756W10000H8459/views/1,width=550,height=550,appearanceId=839,backgroundColor=F2F2F2/elite-logo-sticker.jpg",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Nordic Haven Realty",
                Description = "Specialists in sustainable and eco-friendly homes across Scandinavia. Winner of Green Real Estate Award 2023.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://dynamic.brandcrowd.com/asset/logo/cd107cbf-4ac1-4d32-864c-8d66d90f258b/logo-search-grid-1x?logoTemplateVersion=1&v=637607005913200000&text=Nordic+Haven",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Scandinavian Design Living",
                Description = "Curated selection of mid-century modern and contemporary design homes. Partnered with leading interior designers.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://static.vecteezy.com/system/resources/previews/007/938/913/non_2x/simple-and-clean-scandinavian-real-estates-logo-minimal-house-logo-vector.jpg",
 
            });
            context.Agencies.Add(new Agency
            {
                Name = "Urban Edge Properties",
                Description = "Boutique agency specializing in trendy lofts and converted industrial spaces in Malmö's up-and-coming neighborhoods.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRN3442-czt5ficKfCe-ffgSMPFYmEa5ZjAkg&s",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Lakeside Estates",
                Description = "Experts in luxury lakefront properties throughout Sweden's picturesque countryside. Family-owned since 1985.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://images.mhvillage.com/sales-center-photos/71173910.jpg?type=400&mod=1674601135",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Capital Homes",
                Description = "The leading agency for diplomatic and expat housing solutions in Stockholm. Multilingual staff available 24/7.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnscB0QYxiNTDVi3uvzoadD2yK6_Vo66A9Jw&s",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Alpine Retreats",
                Description = "Specialists in mountain chalets and ski-in/ski-out properties in Åre and other premium alpine locations.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQuVRhnp-RzRYdDc3B69neYMunihXgYUZtLA&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Historic Homes Sweden",
                Description = "Dedicated to preserving and selling Sweden's architectural heritage. Specialists in castles, manors, and listed properties.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQhr0Xy8LNA4PoE3BKcrxyxOxgT-rBjdzde5Q&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Coastal Properties Sweden",
                Description = "Experts in archipelago and coastal real estate from Bohuslän to Österlen. Boat and dock specialists.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://t4.ftcdn.net/jpg/01/65/54/77/360_F_165547799_rypU2XS9Bk7A265XNmwcaPxKEbuIwJ5e.jpg",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Smart City Living",
                Description = "Innovative agency focusing on smart homes and tech-integrated properties in Sweden's urban centers.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://t4.ftcdn.net/jpg/02/43/70/77/360_F_243707747_I4RHdpKfr1iq20dAYVy36tdOG6Ch5KAD.jpg",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Nordic Haven Realty",
                Description = "Specialists in sustainable and eco-friendly homes across Scandinavia. Winner of Green Real Estate Award 2023.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://dynamic.brandcrowd.com/asset/logo/cd107cbf-4ac1-4d32-864c-8d66d90f258b/logo-search-grid-1x?logoTemplateVersion=1&v=637607005913200000&text=Nordic+Haven",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Luxe Villas Sweden",
                Description = "Specializes in high-end villas and estates in the Stockholm archipelago. Offers bespoke services for discerning clients.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRjEnNsw3Bghplx2LZa4Qcp1hhk8Q1qg8IG8w&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Urban Oasis Realty",
                Description = "Focuses on green and sustainable urban living spaces in Gothenburg. Promotes eco-friendly housing solutions.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRQ1TIix4-BjksPAs5vi59KSvHG4Vqy4A9eAg&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Scandinavian Chalets",
                Description = "Provides exclusive mountain and ski properties in Sweden's northern regions. Known for luxury winter retreats.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSgQNomPJcIxXSTKXKfn9im51GVTF5En08vUg&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Royal Estates Sweden",
                Description = "Deals in premium and historic properties across Sweden. Caters to high-net-worth individuals and families.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWk4jn08DfmmuqxGfVt6zlNhbsaRyKBut6Kw&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Modern Living Spaces",
                Description = "Offers contemporary and minimalist homes in Malmö. Collaborates with renowned architects for unique designs.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://images.ctfassets.net/w4bhfqu0yxyq/38ntrgRpuDgsZkXnJ6sa9I/865881b5fddfb0d5c31f166bda5cd979/logo_ModernLiving_1000x700.jpg",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Eco Homes Sweden",
                Description = "Specializes in energy-efficient and sustainable homes across Sweden. Committed to reducing carbon footprints.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://static.vecteezy.com/system/resources/previews/000/660/670/non_2x/vector-eco-home-logo.jpg",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Nordic Luxury Realty",
                Description = "Provides luxury real estate services in Sweden's most desirable locations. Known for exceptional client service.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://media.licdn.com/dms/image/v2/D4E0BAQFy6eVEfSFkfw/company-logo_200_200/company-logo_200_200/0/1721661799768/norluxerealty_logo?e=2147483647&v=beta&t=7U2EPszsUa4UCRd_JnMaQiWZF53YkRWZOr4n_IVGT1M",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Historic Mansions Sweden",
                Description = "Specialists in historic and heritage properties across Sweden. Offers expertise in preservation and restoration.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRD-urmALV5UmtZpaknj5Ni2yOvd1ggtZQ8UQ&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Seaside Retreats",
                Description = "Focuses on coastal and waterfront properties along Sweden's west coast. Offers properties with stunning sea views.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6XaN8-BZOJzoAb5xtX8JNCIHGdfenQa3uFw&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Tech Homes Sweden",
                Description = "Specializes in smart and technology-integrated homes in Sweden's major cities. Promotes modern living solutions.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQVUJL-K9JL-TVgGVeRI-yhAXoR045QmFXglQ&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Green Living Sweden",
                Description = "Specializes in eco-friendly and sustainable homes in rural and urban areas. Promotes green living initiatives.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://greenlivingmag.com/wp-content/uploads/2020/09/green-living-logo-blocked-retina.jpg",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Nordic Dream Homes",
                Description = "Offers a curated selection of dream homes across Sweden. Known for exceptional customer service and unique properties.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://s3-eu-west-1.amazonaws.com/tpd/logos/5df746d5c952730001cf581c/0x0.png",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Luxury Waterfront Living",
                Description = "Specializes in high-end waterfront properties in Stockholm and its archipelago. Caters to luxury property seekers.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR24x6hPBG4PsctkQuUFbILTMYP7WRKsV4apQ&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Urban Chic Properties",
                Description = "Focuses on stylish and modern apartments in Sweden's urban centers. Known for trendy and upscale listings.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXIlxKXgiae4JGSR1o3zNazSHaK-dJsKmCmA&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Scandinavian Heritage Homes",
                Description = "Specialists in historic and culturally significant properties across Sweden. Preserves and promotes heritage sites.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://logowik.com/content/uploads/images/olavsrose-norwegian-heritage5150.logowik.com.webp",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Coastal Dreams Realty",
                Description = "Offers premium coastal properties along Sweden's eastern coast. Specializes in beachfront and seaside homes.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOe0MPBhF2g68WS3oLW8ckLi9aevYoIDm03Q&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Modern Nordic Living",
                Description = "Provides contemporary and innovative homes in Sweden's major cities. Collaborates with top architects and designers.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://cdn.dribbble.com/userupload/8933146/file/original-12d583df5795549b298a8e1f05225169.jpg?format=webp&resize=400x300&vertical=center",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Eco Retreats Sweden",
                Description = "Specializes in sustainable retreats and eco-friendly getaways in Sweden's countryside. Promotes green tourism.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQHoD11HYC6VHmnrbw8BFJjMPa17DY5_OPQSA&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Luxe Nordic Estates",
                Description = "Offers luxury estates and high-end properties in exclusive locations across Sweden. Caters to affluent clients.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRCt14679gFDy4d5AeeFju7vMoG7nFgRqFBlw&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Historic Charm Properties",
                Description = "Specializes in charming and historic homes in Sweden's rural and urban areas. Preserves architectural heritage.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://charmproperties.co.uk/wp-content/uploads/2022/09/CharmLogo.png",
            });
            context.Agencies.Add(new Agency
            {
                Name = "Nordic Luxe Retreats",
                Description = "Specializes in luxury retreats and exclusive getaways in Sweden's most scenic locations. Caters to high-end clientele.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQF2VLMewMysFG9PYCcQ7X2MX1BeQTOwPOnBQ&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Urban Green Spaces",
                Description = "Focuses on urban properties with green spaces and eco-friendly features. Promotes sustainable city living.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://static.vecteezy.com/system/resources/previews/043/214/271/non_2x/a-cityscape-filled-with-greenery-featuring-a-prominent-leaf-in-the-center-develop-a-minimalist-icon-that-symbolizes-sustainable-urban-development-and-green-spaces-free-vector.jpg",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Scandinavian Lake Homes",
                Description = "Offers a selection of premium lakefront properties across Sweden. Specializes in waterfront living.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://www.shutterstock.com/image-vector/logo-badge-scandinavian-drakkar-longship-260nw-323499734.jpg",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Modern Scandi Living",
                Description = "Provides modern and minimalist homes in Sweden's urban areas. Known for sleek and contemporary designs.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSfqPhtm00UWBKoiolyYelEV7XWSC8rXIvN6w&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Eco Nordic Homes",
                Description = "Specializes in eco-friendly and sustainable homes across Sweden. Promotes green building practices.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQVRcMkb3gr_9VcmSyrtzmmAOjt-TFsfJQvGw&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Luxury Nordic Estates",
                Description = "Offers luxury estates and high-end properties in Sweden's most desirable locations. Caters to affluent clients.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRYfnPcMQiLPLPPpxdNpDFfqAL-uVhqWIj9Vg&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Historic Swedish Mansions",
                Description = "Specializes in historic and heritage properties across Sweden. Preserves and promotes cultural heritage.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ3rxtnFT6uxfxdpDyXkxT9ZrL6WVCMDlHTQw&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Coastal Living Sweden",
                Description = "Focuses on coastal and waterfront properties along Sweden's beautiful coastlines. Offers stunning sea views.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWmk5AgoGNhPnOg-4Sr-1daQi4DwWthYAKFA&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Tech Integrated Homes",
                Description = "Specializes in smart and technology-integrated homes in Sweden's urban centers. Promotes modern living solutions.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTucxZsVyyakKZzyqCK8xiA5GDdhDC27xPZjQ&s",
            });

            context.Agencies.Add(new Agency
            {
                Name = "Nordic Dream Estates",
                Description = "Offers a curated selection of dream homes and luxury properties across Sweden. Known for exceptional service.",
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).FirstOrDefault(),
                LogoUrl = "https://s3-eu-west-1.amazonaws.com/tpd/logos/5df746d5c952730001cf581c/0x0.png",
            });


            await context.SaveChangesAsync();
        }
    }
}
