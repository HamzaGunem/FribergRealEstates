using FribergRealEstatesAPI.Constants;
using FribergRealEstatesAPI.Models;
using static System.Net.WebRequestMethods;

namespace FribergRealEstatesAPI.Data.Seeding
{
    //Auth: Hamza
    public class ResidenceSeeding
    {
        public static async Task SeedResidences(ApiDbContext context)
        {
            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 75,
                BiArea = 5,
                Floors = 1,
                Description = "Stilren 2:a med balkong och utsikt över Klarälven – Inre Hamn, Karlstad\r\nDenna moderna tvåa om 58 kvm är belägen i ett av Karlstads mest attraktiva områden – Inre Hamn. Bostaden har en öppen planlösning mellan kök och vardagsrum som ger en härlig rymd. Köket är utrustat med vitvaror från Bosch och gott om arbetsyta för matlagning. Från vardagsrummet nås en generös balkong med sol hela eftermiddagen och fantastisk utsikt mot vattnet. Sovrummet har plats för dubbelsäng och har inbyggda garderober. Helkaklat badrum med tvättmaskin och torktumlare. I föreningen finns garage, övernattningslägenhet och en gemensam takterrass.",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 1200,
                OperatingCost = 3500,
                Facilities = new List<Facilities>
                {
                    Facilities.Balcony,
                    Facilities.ParkingLot,
                    Facilities.Elevator
                },
                BuildYear = 2010,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/89/0f/890f98788b46350c6c909a33a751b9d0.jpg",
                    "https://bilder.hemnet.se/images/1024x/c5/55/c555d898036c3791de8a7fc58b98f9c8.jpg",
                    "https://bilder.hemnet.se/images/1024x/c4/19/c4192bbe9d88f63603d8f79c7678ace7.jpg",
                    "https://bilder.hemnet.se/images/1024x/79/ef/79ef70beae01fa9912a9de60329714a9.jpg"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 110,
                BiArea = 15,
                Floors = 2,
                Description = "Välplanerad 4:a med två balkonger – Rud, Karlstad\r\nPerfekt för barnfamiljen eller för dig som söker extra utrymme! Denna trea om 76 kvm ligger i ett lugnt och grönt område, med närhet till både skolor, mataffärer och bussförbindelser till centrum. Lägenheten har ett renoverat kök i klassisk stil, med matplats för 4–6 personer. Vardagsrummet är rymligt med utgång till en solsäker balkong i västerläge. Två stora sovrum, varav det ena har utgång till en andra balkong i österläge – perfekt för morgonkaffet. Helkaklat badrum, ny el och fiberanslutning. Bra förening med låg avgift.",
                Rooms = 4,
                FloorRows = 2,
                MonthlyFee = 1800,
                OperatingCost = 4500,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Elevator,
                    Facilities.Balcony,
                    Facilities.Terrace
                },
                BuildYear = 2015,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/b4/74/b47409976aacf4002c89d1d0b4f89bfc.jpg",
                    "https://bilder.hemnet.se/images/1024x/60/cd/60cd488f4027497de2362af55734cde3.jpg",
                    "https://bilder.hemnet.se/images/1024x/b4/04/b404b8bcafe1ba4bb1608df54df48044.jpg",
                    "https://bilder.hemnet.se/images/1024x/62/dd/62dd0a98c6fefdca10421247345520a0.jpg"
                }
            });
            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 75,
                BiArea = 8,
                Floors = 7,
                Description = "Fully automated smart apartment with voice-controlled lighting, climate, and security. Features floor-to-ceiling windows, a minimalist kitchen with smart appliances, and a built-in sound system. Perfect for tech enthusiasts!",
                Rooms = 1,
                FloorRows = 7,
                MonthlyFee = 2900,
                OperatingCost = 4100,
                Facilities = new List<Facilities>
                {
                    Facilities.Elevator,
                    Facilities.Balcony
                },
                BuildYear = 2022,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/2e/a1/2ea1046916391c34cf38764b2e33edcc.jpg",
                    "https://bilder.hemnet.se/images/1024x/a7/ed/a7ede391d2da282986e63084df3fa031.jpg",
                    "https://bilder.hemnet.se/images/1024x/8e/ff/8effa3c6a743603062a4561d978c22c2.jpg"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 90,
                BiArea = 0,
                Floors = 3,
                Description = "Charming industrial-style loft with exposed brick walls, wooden beams, and large factory windows. Open-plan living with a mezzanine bedroom. Located in a converted warehouse with a shared rooftop garden.",
                Rooms = 1,
                FloorRows = 3,
                MonthlyFee = 2200,
                OperatingCost = 3500,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot
                },
                BuildYear = 2016,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/2b/04/2b04e26b33a8f4380159583bd202ea36.jpg",
                    "https://bilder.hemnet.se/images/1024x/17/6d/176da0ff1d84c637750fec362d20100e.jpg",
                    "https://bilder.hemnet.se/images/1024x/4e/b0/4eb05cfa5afc6280b6171218fe6e9447.jpg"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 120,
                BiArea = 15,
                Floors = 2,
                Description = "Spacious family apartment in a quiet neighborhood. Features a large kitchen, three bedrooms, a playroom, and a private garden. Close to schools and parks. Pet-friendly building!",
                Rooms = 4,
                FloorRows = 2,
                MonthlyFee = 3800,
                OperatingCost = 5200,
                Facilities = new List<Facilities>
                {
                    Facilities.Elevator,
                    Facilities.Balcony
                },
                BuildYear = 2010,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/87/a8/87a8434b565f040cbf6a2408966ab721.jpg",
                    "https://bilder.hemnet.se/images/1024x/69/c9/69c934f921f0ad889b7cb2f539f2a70a.jpg",
                    "https://bilder.hemnet.se/images/1024x/9b/38/9b38826c8c479ed96c3113d67e21a6e0.jpg",
                    "https://bilder.hemnet.se/images/1024x/05/e1/05e125aa67f4f0f4952b61a2ce9e9479.jpg"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 30,
                BiArea = 0,
                Floors = 1,
                Description = "Affordable studio with all essentials: a compact kitchen, bathroom, and sleeping area. Ideal for students or young professionals. Just 2 minutes from the metro!",
                Rooms = 1,
                FloorRows = 1,
                MonthlyFee = 950,
                OperatingCost = 1200,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Elevator
                },
                BuildYear = 2000,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/a2/54/a25441d8baa58dd4c150acf38acbf2fe.jpg",
                    "https://bilder.hemnet.se/images/1024x/0d/02/0d02595787b9f9f7db6e4de3e1d07cf2.jpg",
                    "https://bilder.hemnet.se/images/1024x/d7/c2/d7c2d5cd3dfad4eb6263732caa37c192.jpg",
                    "https://bilder.hemnet.se/images/1024x/0d/c1/0dc131d6fada7647003bb8609638340d.jpg"
                }
            });
            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 75,
                BiArea = 8,
                Floors = 3,
                Description = "Modern lägenhet med öppen planlösning – Södermalm, Stockholm\r\nEn vacker lägenhet på 75 kvm med två rum och kök. Den öppna planlösningen ger en känsla av rymd och ljus. Köket är utrustat med moderna vitvaror och en ö med plats för måltider. Sovrummet har byggnadsstäder och det finns ett badrum med dusch. Lägenheten ligger på tredje våningen med hiss och har en balkong med utsikt över innergården.",
                Rooms = 2,
                FloorRows = 3,
                MonthlyFee = 2000,
                OperatingCost = 3500,
                Facilities = new List<Facilities>
                {
                    Facilities.Elevator,
                    Facilities.Balcony
                },
                BuildYear = 2010,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/96/ed/96ed4558de114235841d80acaac7fafc.jpg",
                    "https://bilder.hemnet.se/images/1024x/3a/96/3a9676bdd71da537a049719fa77d1d4c.jpg",
                    "https://bilder.hemnet.se/images/1024x/40/35/4035310c13c6f687243156065810becf.jpg"

                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 200,
                BiArea = 50,
                Floors = 12,
                Description = "Luxury penthouse with a private infinity pool, home theater, and 360° city views. Includes a chef’s kitchen, walk-in closets, and a rooftop terrace. 24/7 security and valet parking.",
                Rooms = 3,
                FloorRows = 12,
                MonthlyFee = 12000,
                OperatingCost = 15000,
                Facilities = new List<Facilities>
                {
                    Facilities.Pool,
                    Facilities.Terrace,
                    Facilities.Balcony
    
                },
                BuildYear = 2021,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/45/49/454992de0a28621d69afe7f59892c4cd.jpg",
                    "https://bilder.hemnet.se/images/1024x/12/0b/120b058d449672f958b79b0b53c526b0.jpg",
                    "https://bilder.hemnet.se/images/1024x/64/4a/644a5e0df99e636afcd82a44c5973b12.jpg",
                    "https://bilder.hemnet.se/images/1024x/06/c9/06c989d526a388b53ccc363e3db084ef.jpg"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 80,
                BiArea = 10,
                Floors = 4,
                Description = "Sustainable living with solar panels, rainwater harvesting, and energy-efficient appliances. Features a green roof terrace, bamboo flooring, and organic garden access.",
                Rooms = 2,
                FloorRows = 4,
                MonthlyFee = 2600,
                OperatingCost = 3200,
                Facilities = new List<Facilities>
                {
                    Facilities.Balcony
                },
                BuildYear = 2019,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/69/2d/692d62c88ef7503b3ade0f81d3f9c984.jpg",
                    "https://bilder.hemnet.se/images/1024x/54/3f/543f6c6b14f95f150bbb2ba961d89ee2.jpg",
                    "https://bilder.hemnet.se/images/1024x/f4/94/f49471fd506d516817eb04eea34f21e4.jpg",
                    "https://bilder.hemnet.se/images/1024x/09/a3/09a387c696faaaf11d31ba9ba9ce2765.jpg",
                    "https://bilder.hemnet.se/images/1024x/95/4a/954a74b0c57d2b719dce69c51134e814.jpg"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 70,
                BiArea = 0,
                Floors = 2,
                Description = "Bright studio with large north-facing windows, perfect for painters and creatives. High ceilings, concrete floors, and a flexible open space. Shared courtyard with other artists.",
                Rooms = 1,
                FloorRows = 2,
                MonthlyFee = 1800,
                OperatingCost = 2400,
                Facilities = new List<Facilities>
                {
                    Facilities.Balcony
                },
                BuildYear = 2015,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/59/56/595645944ee38a9ef84205123e650c55.jpg",
                    "https://bilder.hemnet.se/images/1024x/bc/89/bc89df752a2b88f5456af8e4bf9da57a.jpg",
                    "https://bilder.hemnet.se/images/1024x/05/eb/05eba4481efd3ccbbe485e6dc98530c1.jpg",
                    "https://bilder.hemnet.se/images/1024x/2f/52/2f528f8fd010704e3062a2d43d77ce12.jpg",
                    "https://bilder.hemnet.se/images/1024x/3c/cf/3ccfeb99a6b281cd7c4e111414b021a0.jpg"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 65,
                BiArea = 5,
                Floors = 3,
                Description = "Light-filled apartment with clean lines, oak flooring, and functional design. Includes built-in storage, a balcony, and underfloor heating. Near nature reserves and bike paths.",
                Rooms = 2,
                FloorRows = 3,
                MonthlyFee = 2300,
                OperatingCost = 3400,
                Facilities = new List<Facilities>
                {
                    Facilities.Balcony,
     
                },
                BuildYear = 2017,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/39/4b/394b09a4d63e06b394ee0d08c46bcdd3.jpg",
                    "https://bilder.hemnet.se/images/1024x/cf/70/cf7022de7ed9629d7e38a4f562d6f5d1.jpg",
                    "https://bilder.hemnet.se/images/1024x/af/07/af07a1ee9fc7b961393be96fa58aed19.jpg",
                    "https://bilder.hemnet.se/images/1024x/09/70/09709fd94b1f0e8460ab25f5724612c8.jpg"
                }
            });
            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 110,
                BiArea = 10,
                Floors = 5,
                Description = "Exklusiv taklägenhet med vid utsikt – Östermalm, Stockholm\r\nEn fantastisk taklägenhet på 110 kvm med tre rum och kök. Den stora takterrassen erbjuder enastående utsikt över staden. Lägenheten har ett modernt kök, två sovrum och ett badrum med badkar. Det finns även ett separat tvättutrymme. Lägenheten ligger på femte våningen med hiss.",
                Rooms = 3,
                FloorRows = 5,
                MonthlyFee = 2500,
                OperatingCost = 4500,
                Facilities = new List<Facilities>
                {
                    Facilities.Elevator,
                    Facilities.Terrace,
                    Facilities.NewProduction
                },
                BuildYear = 2015,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/9d/2a/9d2a1e1e33f5cb9949b2efe7c42e4d98.jpg",
                    "https://bilder.hemnet.se/images/1024x/ea/7f/ea7f908fdf3a119780ecb505535a5e9d.jpg",
                    "https://bilder.hemnet.se/images/1024x/2e/fc/2efc1ef797e7c23045955875f853707c.jpg",
                    "https://bilder.hemnet.se/images/1024x/43/a1/43a1878595768b3c13168c993513f893.jpg"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 65,
                BiArea = 0,
                Floors = 1,
                Description = "Sekelskiftespärla med kakelugn och stuckatur – Vasastan, Stockholm\r\nEn lägenhet för den som älskar det klassiska! Denna charmiga bostad om 41 kvm ligger på våning 3 i ett vackert sekelskifteshus. Lägenheten bjuder på tidstypiska detaljer såsom kakelugn, djupa fönsternischer, högt i tak och stuckatur. Vardagsrummet är generöst och har plats för både soffa, matbord och arbetshörna. Kök med modern standard och god förvaring. Sovalkov med plats för 140-säng. Badrum med dusch och kombimaskin. Mycket stabil förening och hiss finns i huset.",
                Rooms = 1,
                FloorRows = 1,
                MonthlyFee = 900,
                OperatingCost = 3000,
                Facilities = new List<Facilities>
                {
                    Facilities.Balcony
                },
                BuildYear = 2005,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/6d/d7/6dd78742003093eacf7d0ad7ee762eb2.png",
                    "https://bilder.hemnet.se/images/1024x/87/34/8734034ba07a7f7f05fbbc193afe45e6.jpg",
                    "https://bilder.hemnet.se/images/1024x/65/5c/655c1a95a671b39714d1d8121c042ca5.jpg",
                    "https://bilder.hemnet.se/images/1024x/db/07/db076d5ec03fc3dd1e22198dbdc62faa.jpg"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 85,
                BiArea = 10,
                Floors = 3,
                Description = "Modern enplansvilla med öppen planlösning och dubbelgarage – Skoghall\r\nHär erbjuds en nyproducerad villa på 140 kvm som passar perfekt för den moderna familjen. Planlösningen är social med ett öppet kök, matplats och vardagsrum i ett. Köket har köksö och vitvaror i rostfritt från Siemens. Fyra sovrum, varav ett med eget badrum och walk-in closet. Två helkaklade badrum, separat tvättstuga och gott om förvaring. Stora fönster släpper in rikligt med ljus. På baksidan finns en träaltan med plats för loungemöbler, matgrupp och grill. Uppfarten rymmer flera bilar och dubbelgarage med laddbox för elbil.",
                Rooms = 3,
                FloorRows = 2,
                MonthlyFee = 2000,
                OperatingCost = 5000,
                Facilities = new List<Facilities>
                {
                    Facilities.Balcony,
                    Facilities.ParkingLot,
                    Facilities.Elevator,
                    Facilities.Terrace,
                    Facilities.Pool
                },
                BuildYear = 2018,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/ed/df/eddf02d88142b18b51de641526600bdb.jpg",
                    "https://bilder.hemnet.se/images/1024x/fb/ce/fbce0aa080a9ff344d8d7ebb86e8f6c0.jpg",
                    "https://bilder.hemnet.se/images/1024x/d7/76/d7766fb827ba6c6cd4547f79dc7ac6c0.jpg",
                    "https://bilder.hemnet.se/images/1024x/7d/f5/7df5425ee8aeffafed8a229fe47c9c50.jpg",
                    "https://bilder.hemnet.se/images/1024x/8d/c7/8dc78879ef92337d03e0622a9a97cd84.jpg"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 95,
                BiArea = 12,
                Floors = 2,
                Description = "Totalrenoverad villa i barnvänligt område – Kroppkärr, Karlstad\r\nVälkommen till denna smakfullt renoverade villa på 164 kvm med 6 rum och kök. Huset ligger på en återvändsgata med närhet till skolor, lekplatser och grönområden. På entréplan finns ett modernt kök med integrerade vitvaror, matsal med öppen spis, stort vardagsrum samt ett sovrum/kontor. Övervåningen rymmer tre sovrum, allrum samt ett stilrent badrum med badkar. Källarplan med tvättstuga, förråd och hobbyrum. Nytt tak, fasad och fönster. Tomten är lättskött med ny altan och växthus. Här är det bara att flytta in!",
                Rooms = 3,
                FloorRows = 2,
                MonthlyFee = 1500,
                OperatingCost = 4000,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Elevator,
                    Facilities.NewProduction
                },
                BuildYear = 1995,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/5b/fd/5bfd449615e41a715f4fa8e0171ff543.jpg",
                    "https://bilder.hemnet.se/images/1024x/38/f1/38f174191250a51d2bb2705418091eb7.jpg",
                    "https://bilder.hemnet.se/images/1024x/98/e7/98e736388f3454e9a463c124852e3242.jpg",
                    "https://bilder.hemnet.se/images/1024x/f4/88/f48874681378f88a5473e85324fab6fd.jpg",
                    "https://bilder.hemnet.se/images/1024x/37/72/3772ea3985f6b6ecfbaa58136ce1204b.jpg",
                    "https://bilder.hemnet.se/images/1024x/77/57/7757e5459d17c40ad8deb7511fa6e7b8.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 120,
                BiArea = 30,
                Floors = 2,
                Description = "Lantligt drömboende med stall och hagar – Alster, Karlstad\r\nDrömmer du om att bo på landet men ändå ha nära till stan? Denna rymliga villa med tillhörande stall och hagar erbjuder en unik livsstil för dig med hästintresse. Huvudbyggnaden är på 178 kvm, fördelat på två plan med fyra sovrum, två vardagsrum och lantligt kök med vedspis. På tomten finns ett stall med tre boxar, sadelkammare, höloft samt paddock. Fastigheten omfattar totalt 2 hektar mark. Fiber indraget, värmepump installerad, och närhet till fina ridvägar.",
                Rooms = 5,
                FloorRows = 2,
                MonthlyFee = 2200,
                OperatingCost = 6000,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace,
                    Facilities.Pool
                },
                BuildYear = 2012,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/17/8e/178ea8f98a9a27e8e082611836bcb3e7.jpg",
                    "https://bilder.hemnet.se/images/1024x/86/07/86075d13c08377f951643cd0855a3016.jpg",
                    "https://bilder.hemnet.se/images/1024x/47/54/4754f9c7a190650da5f9343ff77e5572.jpg",
                    "https://bilder.hemnet.se/images/1024x/c9/77/c9778140beb804b3d0fda0f298f3fd95.jpg",
                    "https://bilder.hemnet.se/images/1024x/25/8e/258e904e33ec90096a626c95a33c3bd9.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 185,
                BiArea = 45,
                Floors = 2,
                Description = "Charming countryside villa with panoramic views of rolling hills. Features an open-plan living area with a fireplace, a modern kitchen, four bedrooms, and a sauna. The property includes a large garden, a greenhouse, and a private forest trail. Perfect for nature lovers!",
                Rooms = 4,
                FloorRows = 2,
                MonthlyFee = 2800,
                OperatingCost = 6500,
                Facilities = new List<Facilities>
                {
        
                    Facilities.ParkingLot
                },
                BuildYear = 2015,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/1c/cf/1ccfb11410467c19bd581fb6b0b0e2cc.jpg",
                    "https://bilder.hemnet.se/images/1024x/66/9d/669d2a2dd24b3e1f79981d76ae6486e2.jpg",
                    "https://bilder.hemnet.se/images/1024x/30/e2/30e29a7d26bc134516478dd0600824ab.jpg",
                    "https://bilder.hemnet.se/images/1024x/25/27/2527c77cc1c1010c7ce033d4ba323743.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 210,
                BiArea = 60,
                Floors = 1,
                Description = "Stunning single-story house with floor-to-ceiling windows overlooking a private lake. Features a gourmet kitchen, three bedrooms with en-suite bathrooms, and a floating deck with direct lake access. Includes a boat dock and outdoor fire pit.",
                Rooms = 3,
                FloorRows = 1,
                MonthlyFee = 4500,
                OperatingCost = 8500,
                Facilities = new List<Facilities>
                {
                    Facilities.Pool,
                    Facilities.ParkingLot,
                    Facilities.Terrace
                },
                BuildYear = 2020,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/6d/ef/6defba9d98b768dbffc898746e93db6b.jpg",
                    "https://bilder.hemnet.se/images/1024x/e5/94/e594a0f937d650cee46c5602377f2550.jpg",
                    "https://bilder.hemnet.se/images/1024x/b3/ef/b3efbee4c110210d2076ac210be9bf95.jpg",
                    "https://bilder.hemnet.se/images/1024x/41/54/415433634617c7d3a35598dd2a66f861.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 150,
                BiArea = 20,
                Floors = 2,
                Description = "Renovated 19th-century farmhouse with original stone walls and wooden beams. Includes a cozy kitchen with a AGA stove, three bedrooms, and a sunroom. The property features a barn (convertible to a studio/workshop) and 1.5 hectares of land.",
                Rooms = 3,
                FloorRows = 2,
                MonthlyFee = 3200,
                OperatingCost = 5000,
                Facilities = new List<Facilities>
                {
                    Facilities.Balcony,
                    Facilities.ParkingLot
                },
                BuildYear = 1850,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/9f/58/9f5846323c7a418b8752d9e75fd1c7c1.jpg",
                    "https://bilder.hemnet.se/images/1024x/04/f7/04f76835b6e4ba865fb3ada6a17d6bd7.jpg",
                    "https://bilder.hemnet.se/images/1024x/dc/76/dc762715803f085841b1573521e4ccf3.jpg",
                    "https://bilder.hemnet.se/images/1024x/ab/1e/ab1e3a646fefe14db0f6bb52b8031962.jpg",
                    "https://bilder.hemnet.se/images/1024x/b6/03/b6038fea55d011e21a9f0df10e11a7b8.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 320,
                BiArea = 80,
                Floors = 3,
                Description = "State-of-the-art smart villa with a heated infinity pool, home theater, and rooftop terrace. Features five ensuite bedrooms, a wine cellar, and a gourmet kitchen with marble countertops. The garden includes an outdoor kitchen and a Zen meditation area.",
                Rooms = 5,
                FloorRows = 3,
                MonthlyFee = 9500,
                OperatingCost = 12000,
                Facilities = new List<Facilities>
                {
                    Facilities.Pool,
                    Facilities.Elevator,
                    Facilities.ParkingLot
                },
                BuildYear = 2021,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/d0/61/d0618df87cf45ff3368fb6c29e2b110f.jpg",
                    "https://bilder.hemnet.se/images/1024x/77/0b/770b8ca79cbbcff963a223820b0e4564.jpg",
                    "https://bilder.hemnet.se/images/1024x/5c/99/5c99df2a0f902de56c39d7cac49090ad.jpg",
                    "https://bilder.hemnet.se/images/1024x/82/68/826850252e64c93ffd7a920b186c85f9.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 140,
                BiArea = 30,
                Floors = 2,
                Description = "Energy-efficient timber house with solar panels, geothermal heating, and rainwater recycling. Open-plan living with a wood-burning stove, three bedrooms, and a greenhouse. The property includes an organic vegetable garden and a chicken coop.",
                Rooms = 3,
                FloorRows = 2,
                MonthlyFee = 2400,
                OperatingCost = 3800,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot
      
                },
                BuildYear = 2018,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/ec/de/ecdeeb9027227a27b7237fac7a5384d7.jpg",
                    "https://bilder.hemnet.se/images/1024x/54/9a/549ae2f8ea1c1bf59bfc186821fc24cb.jpg",
                    "https://bilder.hemnet.se/images/1024x/89/41/8941bd45a93d4709548aae6253dbc86f.jpg",
                    "https://bilder.hemnet.se/images/1024x/f6/68/f6686fff755c23bcf3ef84e4a6744282.jpg",
                    "https://bilder.hemnet.se/images/1024x/0a/6c/0a6cbaa28930ce1a0e7624f8b40e82ef.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 90,
                BiArea = 15,
                Floors = 1,
                Description = "Authentic log cabin nestled in the mountains, just steps from hiking and skiing trails. Features a wood-fired sauna, a stone fireplace, and a wraparound porch. Perfect for year-round adventures!",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 1800,
                OperatingCost = 3000,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot
                },
                BuildYear = 2010,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/a8/54/a854f55394646c73d2b2a062cec67ddf.jpg",
                    "https://bilder.hemnet.se/images/1024x/b3/4b/b34b705ef0d337e1da803b0176b5a6f3.jpg",
                    "https://bilder.hemnet.se/images/1024x/5b/d2/5bd2952a8e5953a94005494eebcb58ae.jpg",
                    "https://bilder.hemnet.se/images/1024x/fb/68/fb682e16f6181cf18e22668d1868e0a5.jpg",
                    "https://bilder.hemnet.se/images/1024x/9e/13/9e13151a1cd6689468a04abefe391499.jpg"
                }
            });
            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 110,
                BiArea = 25,
                Floors = 1,
                Description = "Quaint cottage just 50 meters from the beach. Features a breezy open layout, a screened porch, and an outdoor shower. The property includes a private path to the sand and a storage shed for surfboards/kayaks.",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 3500,
                OperatingCost = 4800,
                Facilities = new List<Facilities>
                {
                    Facilities.Balcony,
                    Facilities.Terrace
                },
                BuildYear = 2005,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/58/29/582988874047d744373563c17ddcde52.jpg",
                    "https://bilder.hemnet.se/images/1024x/1e/f4/1ef4c212e9c3ebd771b5fd7bbb82e19c.jpg",
                    "https://bilder.hemnet.se/images/1024x/e9/64/e9647ca5687eeb463f433a8a7e7fc08b.jpg",
                    "https://bilder.hemnet.se/images/1024x/0b/a8/0ba810b13d56ff2e67129c59cc331463.jpg",
                    "https://bilder.hemnet.se/images/1024x/fd/32/fd32b1c26f5f65422a6848e06e1fe9f0.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 220,
                BiArea = 50,
                Floors = 2,
                Description = "Equestrian property with a 5-stall barn, riding arena, and 10 acres of pastures. The main house includes four bedrooms, a chef’s kitchen, and a sunroom overlooking the grounds. Ideal for professional riders or hobbyists.",
                Rooms = 4,
                FloorRows = 2,
                MonthlyFee = 5200,
                OperatingCost = 9000,
                Facilities = new List<Facilities>
                {
                    Facilities.Pool,
                    Facilities.ParkingLot
                },
                BuildYear = 2015,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/13/a1/13a1296244ddc8fc0a470750fde9dad6.jpg",
                    "https://bilder.hemnet.se/images/1024x/51/78/5178f49f50ef336fb88fdc38aafe9626.jpg",
                    "https://bilder.hemnet.se/images/1024x/46/79/46799422ad1624901c1cee12b3c8d44b.jpg",
                    "https://bilder.hemnet.se/images/1024x/41/4a/414aac6b601c0004526d4f68eecf20fd.jpg",
                    "https://bilder.hemnet.se/images/1024x/5d/c3/5dc389dfe9009e08750998ed73ae1948.jpg"
                }
            });
            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 150,
                BiArea = 50,
                Floors = 3,
                Description = "Sjönära stuga med egen brygga och bastu – Värmskog, Värmland\r\nEn idyll vid sjön! Denna charmiga timmerstuga är på 65 kvm och ligger bara 15 meter från strandlinjen. Här finns två sovrum, ett öppet kök med vedspis, och ett mysigt vardagsrum med panoramafönster mot vattnet. Stor altan i sydvästläge, perfekt för långa sommarkvällar. På tomten finns en gäststuga med plats för ytterligare fyra sovplatser samt bastu med vedeldad kamin. Egen brygga med plats för båt och bad. Både el och vatten är indraget. Här får du riktig sommarkänsla året runt.",
                Rooms = 6,
                FloorRows = 3,
                MonthlyFee = 2800,
                OperatingCost = 7000,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace,
                    Facilities.Pool,
                    Facilities.NewProduction
                },
                BuildYear = 2008,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/3d/11/3d11ad32e997b532eccb745fc8953c0e.jpg",
                    "https://bilder.hemnet.se/images/1024x/1f/ca/1fca4cecc2cc6bc930df45fef0a0a164.jpg",
                    "https://bilder.hemnet.se/images/1024x/ef/6b/ef6b916f7eab89e2b538011f5d949c0f.jpg",
                    "https://bilder.hemnet.se/images/1024x/28/fc/28fcb1501225d28fc2ae692e1a836c19.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 250,
                BiArea = 70,
                Floors = 2,
                Description = "Sleek glass-walled home with floating staircases and smart-home automation. Features a rooftop terrace, an indoor pool, and a gourmet kitchen with premium appliances. The minimalist garden includes a koi pond and zen rock garden.",
                Rooms = 3,
                FloorRows = 2,
                MonthlyFee = 8800,
                OperatingCost = 11000,
                Facilities = new List<Facilities>
                {
                    Facilities.Pool,
                    Facilities.Terrace,
                    Facilities.ParkingLot
                },
                BuildYear = 2022,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/2d/d3/2dd3ae31f72fa06e473f0a67e8862047.jpg",
                    "https://bilder.hemnet.se/images/1024x/13/cf/13cfaac1063a2300c62fd0a1768d8629.jpg",
                    "https://bilder.hemnet.se/images/1024x/2e/78/2e787526de407f961954e9758830ccd1.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 180,
                BiArea = 40,
                Floors = 2,
                Description = "Perfect family home with a large backyard (play set included), a modern kitchen, and four bedrooms. The finished basement includes a home gym and a movie corner. Quiet neighborhood with excellent schools nearby.",
                Rooms = 4,
                FloorRows = 2,
                MonthlyFee = 3800,
                OperatingCost = 5500,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot
                },
                BuildYear = 2016,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/33/49/3349bb080b6f955c923feec1bf4c0395.jpg",
                    "https://bilder.hemnet.se/images/1024x/64/55/64551bb5caedd5b312cfffa395629f77.jpg",
                    "https://bilder.hemnet.se/images/1024x/07/bc/07bc85bf40213055b45fcb538e431395.jpg",
                    "https://bilder.hemnet.se/images/1024x/c4/df/c4df4d4931925a343a9d1f7eaf202a5d.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 100,
                BiArea = 20,
                Floors = 1,
                Description = "Avskilt torp i naturskön miljö – Ransäter\r\nFör dig som söker tystnad och återhämtning! Detta gamla torp på cirka 55 kvm erbjuder ett genuint fritidsboende med skogen som närmsta granne. Huset har enkel standard med kök, vardagsrum och ett sovrum. Vedspis och el finns, men vattnet hämtas från brunn. På tomten står ett förråd, utedass och en liten lada. Möjlighet till jakt i området. En plats för dig som vill logga ut från vardagen och återknyta till det enkla livet.",
                Rooms = 3,
                FloorRows = 1,
                MonthlyFee = 1700,
                OperatingCost = 4500,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace
                },
                BuildYear = 2019,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/27/30/2730ca38cdfca7369d377bc8d355c67e.jpg",
                    "https://bilder.hemnet.se/images/1024x/fd/ff/fdffa4f22f6db4810fbe29e0510eecff.jpg",
                    "https://bilder.hemnet.se/images/1024x/26/df/26dfe0182b7ad015d1e7fa23102a15c7.jpg",
                    "https://bilder.hemnet.se/images/1024x/76/92/7692b4403e8af9c92283f90f53176a3c.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 180,
                BiArea = 60,
                Floors = 2,
                Description = "Fritidshus med året-runt-standard nära Branäs skidanläggning\r\nDetta vinterbonade fritidshus om 72 kvm har allt du behöver för aktiva vinterhelger eller lugna somrar i fjällmiljö. Öppen planlösning mellan kök och allrum med stor kamin som värmer hela huset. Två sovrum, helkaklat badrum och bastu. Uppfart med plats för två bilar. Stugan säljs möblerad. Gångavstånd till skidspår, längdåkning och skoterspår. Fiber är indraget och huset kan användas som permanentboende.",
                Rooms = 7,
                FloorRows = 2,
                MonthlyFee = 3500,
                OperatingCost = 8000,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace,
                    Facilities.Pool,
                    Facilities.NewProduction
                },
                BuildYear = 2020,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/c1/8f/c18fab1c7f897da518c4c3c9f10941ee.jpg",
                    "https://bilder.hemnet.se/images/1024x/06/08/06087f22f3d7a3ac592bdd56030aa868.jpg",
                    "https://bilder.hemnet.se/images/1024x/91/82/91827ecbdfa9357fafc0152f5bb2876e.jpg",
                    "https://bilder.hemnet.se/images/1024x/15/89/15895682f19fa31f03d8df611ab72209.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 120,
                BiArea = 20,
                Floors = 2,
                Description = "Charmig villa med stor trädgård – Lidingö, Stockholm\r\nEn vacker villa på 120 kvm med fem rum och kök. Huset har två våningar med ett stort vardagsrum, tre sovrum och två badrum. Köket är nyrenoverat med moderna vitvaror. Trädgården är stor och välskött med plats för grill och uteservering. Lägenheten ligger i ett lugnt bostadsområde nära skola och dagis.",
                Rooms = 5,
                FloorRows = 2,
                MonthlyFee = 1800,
                OperatingCost = 4200,
                Facilities = new List<Facilities>
                {
                    Facilities.Terrace
                },
                BuildYear = 1985,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/e1/b3/e1b309bf8f1b93d9837938bf67d06c4d.jpg",
                    "https://bilder.hemnet.se/images/1024x/11/3e/113e176c6f95633be2374edef745b3ff.jpg",
                    "https://bilder.hemnet.se/images/1024x/43/a5/43a56ca494fcb673ef395d520327236e.jpg",
                    "https://bilder.hemnet.se/images/1024x/b6/1b/b61bb51f413cd40e165175c5b71d54f5.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 150,
                BiArea = 25,
                Floors = 2,
                Description = "Stor familjevilla med pool – Djursholm, Stockholm\r\nEn imponerande villa på 150 kvm med sex rum och kök. Huset har två våningar med ett stort vardagsrum, fyra sovrum och två badrum. Det finns även ett hobbyrum i källaren. Trädgården är stor med en pool och uteserveringsområde. Villan ligger i ett exklusivt bostadsområde nära vatten.",
                Rooms = 6,
                FloorRows = 2,
                MonthlyFee = 2200,
                OperatingCost = 5000,
                Facilities = new List<Facilities>
                {
                    Facilities.Pool,
                    Facilities.Terrace
                },
                BuildYear = 2005,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/38/1b/381b663d4e5830594a860815381a0b96.jpg",
                    "https://bilder.hemnet.se/images/1024x/38/1e/381eb14596247e8393cd0cba5305fdc0.jpg",
                    "https://bilder.hemnet.se/images/1024x/58/bd/58bd70cbb58b8af4103ef4d24303bf42.jpg",
                    "https://bilder.hemnet.se/images/1024x/66/13/6613d9512ff0c34e79dbd00a8d75173f.jpg"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 90,
                BiArea = 15,
                Floors = 1,
                Description = "Attefallshus med permanentstandard – Vänernära tomt\r\nEtt nybyggt Attefallshus på 30 kvm med smart planlösning, perfekt som fritidshus, gästhus eller extraboende. Allrum med kök i vinkel, separat sovalkov, duschrum med tvättmaskin och golvvärme. Huset är isolerat och vinterbonat med vattenburen golvvärme och luftvärmepump. På tomten finns utekök, badtunna och elansluten förrådsbod. Gångavstånd till badstrand och båtplats.",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 1300,
                OperatingCost = 3800,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace
                },
                BuildYear = 2000,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/79/1a/791aa1d5cf4514ede228863ce7c06268.jpg",
                    "https://bilder.hemnet.se/images/1024x/cd/76/cd76bc4cf4728f36932acad36c4744af.jpg",
                    "https://bilder.hemnet.se/images/1024x/ad/39/ad392270a8e158063cd909a9c4e60423.jpg",
                    "https://bilder.hemnet.se/images/1024x/21/1d/211da86e510c1bd6ab7ad30a99a5f24d.jpg"
                }
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.VacationHouse,
                Area = 80,
                BiArea = 20,
                Floors = 1,
                Description = "Arkitektritat minihus med sjöglimt – Karlskoga skärgård\r\nEtt designat attefallshus i exklusiva materialval – betonggolv, svarta träpaneler, stora glaspartier och takfönster som ger ett fantastiskt ljusinsläpp. 35 kvm med sovloft, platsbyggt kök och lyxigt badrum. Altan med utsikt mot sjön, uteplats med eldstad. Huset är helt nybyggt och står på arrendetomt. En riktig pärla för den som söker något unikt.",
                Rooms = 3,
                FloorRows = 1,
                MonthlyFee = 1500,
                OperatingCost = 4000,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace,
                    Facilities.Pool
                },
                BuildYear = 2015,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/0d/61/0d61c62ce1218ef80ea76954d863cb8c.jpg",
                    "https://bilder.hemnet.se/images/1024x/7b/1a/7b1a90ed70b1ed3557d56cedadf1ec2f.jpg",
                    "https://bilder.hemnet.se/images/1024x/a0/73/a073ce17d70d8e28dbe74eaa5f254ec3.jpg",
                    "https://bilder.hemnet.se/images/1024x/dd/c4/ddc461e275e99f4d482bcc5f166e73e5.jpg",
                    "https://bilder.hemnet.se/images/1024x/80/e9/80e9453b97b0f4c55f7f1a2e52d1df47.jpg"
                }
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.VacationHouse,
                Area = 110,
                BiArea = 30,
                Floors = 2,
                Description = "Lägenhetshotell i fjällen – investeringsmöjlighet!\r\nEtt möblerat och fullt utrustat studio-boende med fyra bäddar mitt i populär skidort. Här erbjuds en kombination av privat fritidsboende och möjlighet till uthyrning via driftbolag. Pentry, badrum med bastu, balkong med fjällutsikt samt tillgång till hotellfaciliteter såsom restaurang, gym och skidförvaring. Passar perfekt för dig som vill ha bekvämlighet och avkastning.",
                Rooms = 4,
                FloorRows = 2,
                MonthlyFee = 1900,
                OperatingCost = 5000,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace
                },
                BuildYear = 2010,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/f1/c0/f1c0a167fc37766878ce05262587998e.jpg",
                    "https://bilder.hemnet.se/images/1024x/42/e9/42e9c4fdcc1770b89728ca7888689a2d.jpg",
                    "https://bilder.hemnet.se/images/1024x/4f/44/4f44f75ec1434d5d136823731ba93db3.jpg",
                    "https://bilder.hemnet.se/images/1024x/9c/23/9c2361371161dbdd88167a6e8d153c49.jpg"
                }
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.VacationHouse,
                Area = 60,
                BiArea = 10,
                Floors = 1,
                Description = "Fritidshus med havsutsikt och gäststuga – Torsö, Vänern\r\nDetta fantastiska fritidshus på natursköna Torsö erbjuder både rofylld avkoppling och sociala ytor för hela familjen. Huvudbyggnaden är ca 68 kvm med två sovrum, ett luftigt vardagsrum och ett kök med utsikt mot Vänerns glittrande vatten. Genomgående fina ytskikt, täljstenskamin samt nytt badrum med dusch och tvättmaskin. På tomten om 2 200 kvm finns dessutom en vinterbonad gäststuga med ytterligare fyra bäddar och eget WC. Ett stort trädäck omger huset – perfekt för sommarens middagar eller avkoppling i kvällssolen. Tillgång till privat badplats och möjlighet till båtplats bara 150 meter bort.",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 1200,
                OperatingCost = 3500,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace
                },
                BuildYear = 2005,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/b6/1f/b61f5a4f12f82531549acf1d10fef9cf.jpg",
                    "https://bilder.hemnet.se/images/1024x/03/c7/03c7c0815890814acf2de3edc3dc2460.jpg",
                    "https://bilder.hemnet.se/images/1024x/29/92/29925769e42b370a66b9bbc09f332dfe.jpg",
                    "https://bilder.hemnet.se/images/1024x/6d/3a/6d3a9a709b52bd5c3c1ba3848275e3ef.jpg"
                }
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.VacationHouse,
                Area = 130,
                BiArea = 40,
                Floors = 2,
                Description = "Fjällnära fritidsboende med garage och altan – Lofsdalen\r\nMed ett spektakulärt läge vid foten av fjällen ligger detta välskötta fritidshus på 74 kvm. Huset är byggt för året-runt-bruk med god isolering, luftvärmepump och braskamin för mysiga vinterkvällar. Här finns tre sovrum, allrum med öppet tak upp till nock, ett fullutrustat kök och helkaklat badrum med bastu. Utanför breder sig en altan på 50 kvm ut, med vacker utsikt över fjällkedjan. Till fastigheten hör även ett isolerat garage med plats för både bil och skoter, samt förråd. Längdskidspår passerar precis bakom huset, och liftar samt affärer ligger 5 minuter bort med bil. Säljs delvis möblerat.",
                Rooms = 5,
                FloorRows = 2,
                MonthlyFee = 2500,
                OperatingCost = 6500,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace,
                    Facilities.NewProduction
                },
                BuildYear = 2018,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/34/a2/34a288038a31bd17d4810ed342dc20f6.jpg",
                    "https://bilder.hemnet.se/images/1024x/8c/4f/8c4fee3f44dde5eb03ee4a8de9524813.jpg",
                    "https://bilder.hemnet.se/images/1024x/8e/5d/8e5d6ee59e6a0e66cca4d1a331a959ee.jpg",
                    "https://bilder.hemnet.se/images/1024x/63/95/63952f3e14c791ef8612956de17f571f.jpg"
                }
            });
            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.VacationHouse,
                Area = 60,
                BiArea = 15,
                Floors = 1,
                Description = "Mysigt sommarställe med sjönära läge – Trosa skärgård\r\nEtt mysigt sommarställe på 60 kvm med två rum och kök. Stugan har ett vardagsrum med öppen spis, ett sovrum och ett badrum med dusch. Utanför finns en stor altan med utsikt över sjön. Tomten är stor med plats för solstolar och grill. Stugan ligger i ett lugnt område nära badplats och båttrafik.",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 1200,
                OperatingCost = 3000,
                Facilities = new List<Facilities>
                {
                    Facilities.Terrace,
                    Facilities.ParkingLot
                },
                BuildYear = 1990,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/68/ed/68ed8788780dc1ba62417b89d0f0d8c7.jpg",
                    "https://bilder.hemnet.se/images/1024x/fe/e1/fee155da07cf5d36ec52e3745e906783.jpg",
                    "https://bilder.hemnet.se/images/1024x/69/75/6975870f24b4ec5320917d7a31d3c66b.jpg",
                    "https://bilder.hemnet.se/images/1024x/0a/31/0a31503772efb6258ecaf53939f06c8a.jpg"
                }
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.VacationHouse,
                Area = 70,
                BiArea = 18,
                Floors = 1,
                Description = "Modernt fritidshus med altan och bastu – Åre fjäll\r\nEtt modernt fritidshus på 70 kvm med tre rum och kök. Huset har ett vardagsrum med öppen spis, två sovrum och ett badrum med bastu. Utanför finns en stor altan med utsikt över fjällen. Tomten är lättskött med plats för grill och uteservering. Huset ligger nära skidbackar och vandringsleder.",
                Rooms = 3,
                FloorRows = 1,
                MonthlyFee = 1400,
                OperatingCost = 3800,
                Facilities = new List<Facilities>
                {
                    Facilities.Terrace,
                    Facilities.ParkingLot
                },
                BuildYear = 2012,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/07/dc/07dcd8f941da0453effbe07db252faf9.jpg",
                    "https://bilder.hemnet.se/images/1024x/93/5b/935b7f7a914a0531fcc9ba13c6353079.jpg",
                    "https://bilder.hemnet.se/images/1024x/4e/da/4eda560cb97d04b824882329927a80fc.jpg",
                    "https://bilder.hemnet.se/images/1024x/88/38/8838eabd73684312bbf8e62eb63e397c.jpg"
                }
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.VacationHouse,
                Area = 70,
                BiArea = 15,
                Floors = 1,
                Description = "nkel skärgårdsstuga med utvecklingspotential – Lurö skärgård\r\nLetar du efter ett sommarprojekt i ett av Vänerns mest unika lägen? Denna enkla men charmiga skärgårdsstuga ligger på en friköpt tomt i Lurö skärgård – endast nåbar med båt. Huvudbyggnaden på 45 kvm har en öppen planlösning, kokvrå, vedspis och två sovrum. El finns via solceller och batteribank, och vatten tas från gemensam brunn. Utedass och dusch i separat byggnad. Tomten är naturtomt med berghällar, bärbuskar och gles skog. Här finns stor potential för dig som vill renovera, bygga till eller skapa ett avskilt paradis – mitt i ett naturreservat. Tillgång till båtplats på fastlandet ingår i köpet.",
                Rooms = 2,
                FloorRows = 1,
                MonthlyFee = 1100,
                OperatingCost = 3200,
                Facilities = new List<Facilities>
                {
                    Facilities.ParkingLot,
                    Facilities.Terrace
                },
                BuildYear = 2012,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://bilder.hemnet.se/images/1024x/c3/83/c3839f0bfbd740b757057bdb7aa2e127.jpg",
                    "https://bilder.hemnet.se/images/1024x/5c/25/5c2546bf286ec3ffb671990ce8374079.jpg",
                    "https://bilder.hemnet.se/images/1024x/76/79/767983fb4642731fba50c847c432dde3.jpg",
                    "https://bilder.hemnet.se/images/1024x/5d/f4/5df41ae2698e366547b8dec0412e01e5.jpg"
                }
            });
            await context.SaveChangesAsync();
        }
    }
}
