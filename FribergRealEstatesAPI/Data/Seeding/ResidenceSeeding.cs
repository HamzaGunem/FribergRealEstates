using FribergRealEstatesAPI.Constants;
using FribergRealEstatesAPI.Models;

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
                    "https://images.unsplash.com/photo-1560448204-e02f11c3d0e2",
                    "https://images.unsplash.com/photo-1493809842364-78817add7ffb"
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
                    "https://images.unsplash.com/photo-1512917774080-9991f1c4c750",
                    "https://images.unsplash.com/photo-1583847268964-b28dc8f51f92"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 75,
                BiArea = 8,
                Floors = 7,
                Description = "Helt automatiserad smart lägenhet med röststyrd belysning, klimat och säkerhet. Funktioner inkluderar golv-till-tak-fönster, ett minimalistiskt kök med smarta apparater och ett inbyggt ljudsystem. Perfekt för teknikentusiaster!",
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
                    "https://images.unsplash.com/photo-1558002038-1055907df827",
                    "https://images.unsplash.com/photo-1513519245088-0e12902e5a38"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 90,
                BiArea = 0,
                Floors = 3,
                Description = "Charmig industriell stil loft med exponerade tegelväggar, träbjälkar och stora fabriksfönster. Öppen planlösning med sovloft. Beläget i ett ombyggt lagerhus med en gemensam takterrass.",
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
                    "https://images.unsplash.com/photo-1493809842364-78817add7ffb",
                    "https://images.unsplash.com/photo-1513519245088-0e12902e5a38"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 120,
                BiArea = 15,
                Floors = 2,
                Description = "Rymlig familjelägenhet i ett lugnt område. Funktioner inkluderar ett stort kök, tre sovrum, ett lekrum och en privat trädgård. Nära skolor och parker. Husdjursvänligt hus!",
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
                    "https://images.unsplash.com/photo-1583847268964-b28dc8f51f92",
                    "https://images.unsplash.com/photo-1600585154340-be6161a56a0c"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 30,
                BiArea = 0,
                Floors = 1,
                Description = "Överkomlig studio med alla nödvändigheter: ett kompakt kök, badrum och sovutrymme. Idealisk för studenter eller unga yrkesverksamma. Endast 2 minuter från tunnelbanan!",
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
                    "https://images.unsplash.com/photo-1522708323590-d24dbb6b0267",
                    "https://images.unsplash.com/photo-1556911220-bff31c812dba"
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
                    "https://images.unsplash.com/photo-1502673532817-9486cd496975",
                    "https://images.unsplash.com/photo-1567427018147-5a13ab629a9b"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 200,
                BiArea = 50,
                Floors = 12,
                Description = "Lyxig penthouse med privat oändlighetspool, hemma-bio och 360° utsikt över staden. Inkluderar ett kök för kockar, walk-in-kläder och en takterrass. 24/7 säkerhet och parkering med betjäning.",
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
                    "https://images.unsplash.com/photo-1564501049412-61c2a3083791",
                    "https://images.unsplash.com/photo-1582268611958-ebfd161ef9cf"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 80,
                BiArea = 10,
                Floors = 4,
                Description = "Hållbart boende med solpaneler, regnvatteninsamling och energieffektiva apparater. Funktioner inkluderar en grön takterrass, bambugolv och tillgång till en ekologisk trädgård.",
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
                    "https://images.unsplash.com/photo-1600566752229-2506f6a68954",
                    "https://images.unsplash.com/photo-1513519245088-0e12902e5a38"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 70,
                BiArea = 0,
                Floors = 2,
                Description = "Ljus studio med stora nordvästliga fönster, perfekt för målare och kreativa. Höga tak, betonggolv och ett flexibelt öppet utrymme. Gemensam innergård med andra konstnärer.",
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
                    "https://images.unsplash.com/photo-1513519245088-0e12902e5a38",
                    "https://images.unsplash.com/photo-1493809842364-78817add7ffb"
                }
            });

            context.Residences.Add(new Apartment
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.Apartment,
                Area = 65,
                BiArea = 5,
                Floors = 3,
                Description = "Ljusfylld lägenhet med rena linjer, ekgolv och funktionell design. Inkluderar inbyggd förvaring, en balkong och golvvärme. Nära naturreservat och cykelvägar.",
                Rooms = 2,
                FloorRows = 3,
                MonthlyFee = 2300,
                OperatingCost = 3400,
                Facilities = new List<Facilities>
                {
                    Facilities.Balcony
                },
                BuildYear = 2017,
                IsAvailable = true,
                ImageUrls = new[]
                {
                    "https://images.unsplash.com/photo-1554995207-c18c2ce90e04",
                    "https://images.unsplash.com/photo-1600121848594-d8644e57abab"
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
                    "https://images.unsplash.com/photo-1567016597817-15460187c79b",
                    "https://images.unsplash.com/photo-1554995207-c18c2ce90e04"
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
                    "https://images.unsplash.com/photo-1502672260266-1c1ef2d93688",
                    "https://images.unsplash.com/photo-1484154218962-a197022b5858"
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
                    "https://images.unsplash.com/photo-1564013799919-ab600027ffc6",
                    "https://images.unsplash.com/photo-1580587771525-78b9dba3b914"
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
                    "https://images.unsplash.com/photo-1522708323590-d24dbb6b0267",
                    "https://images.unsplash.com/photo-1486304873000-235643847519"
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
                    "https://images.unsplash.com/photo-1600585154340-be6161a56a0c",
                    "https://images.unsplash.com/photo-1605276374104-dee2a0ed3cd6"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 185,
                BiArea = 45,
                Floors = 2,
                Description = "Charmig landsbygdsvilla med panoramautsikt över kullar. Funktioner inkluderar ett öppet vardagsrum med öppen spis, ett modernt kök, fyra sovrum och en bastu. Fastigheten inkluderar en stor trädgård, ett växthus och en privat skogsstig. Perfekt för naturälskare!",
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
                    "https://images.unsplash.com/photo-1600585154340-be6161a56a0c",
                    "https://images.unsplash.com/photo-1605276374104-dee2a0ed3cd6"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 210,
                BiArea = 60,
                Floors = 1,
                Description = "Enastående envåningshus med golv-till-tak-fönster med utsikt över en privat sjö. Funktioner inkluderar ett gourmetkök, tre sovrum med egna badrum och en flytande brygga med direkt tillgång till sjön. Inkluderar en båtbrygga och en utomhus eldstad.",
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
                    "https://images.unsplash.com/photo-1600607687920-4e2a09cf159d",
                    "https://images.unsplash.com/photo-1600607688969-a5bfcd646154"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 150,
                BiArea = 20,
                Floors = 2,
                Description = "Renoverad 1800-tals bondgård med originala stenväggar och träbjälkar. Inkluderar ett mysigt kök med AGA-spis, tre sovrum och en solrum. Fastigheten har en lada (omvandlingsbar till studio/verkstad) och 1,5 hektar mark.",
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
                    "https://images.unsplash.com/photo-1600046050379-8a5d01b3f6ca",
                    "https://images.unsplash.com/photo-1600121848594-d8644e57abab"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 320,
                BiArea = 80,
                Floors = 3,
                Description = "Modernt smart hus med uppvärmd oändlighetspool, hemma-bio och takterrass. Funktioner inkluderar fem sovrum med egna badrum, ett vinkällare och ett gourmetkök med marmorbänkskivor. Trädgården inkluderar ett utomhuskök och en Zen-meditationsplats.",
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
                    "https://images.unsplash.com/photo-1564013799919-ab600027ffc6",
                    "https://images.unsplash.com/photo-1582268611958-ebfd161ef9cf"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 140,
                BiArea = 30,
                Floors = 2,
                Description = "Energisnål trähus med solpaneler, geotermisk uppvärmning och regnvattenåtervinning. Öppen planlösning med vedeldad spis, tre sovrum och ett växthus. Fastigheten inkluderar en ekologisk köksträdgård och ett hönshus.",
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
                    "https://images.unsplash.com/photo-1600566752229-2506f6a68954",
                    "https://images.unsplash.com/photo-1600585154340-be6161a56a0c"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 90,
                BiArea = 15,
                Floors = 1,
                Description = "Äkta timmerstuga inbäddad i bergen, bara några steg från vandrings- och skidspår. Funktioner inkluderar en vedeldad bastu, en steneldstad och en omslutande veranda. Perfekt för äventyr året runt!",
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
                    "https://images.unsplash.com/photo-1483728642387-6c3bdd6c93e5",
                    "https://images.unsplash.com/photo-1601918774946-25832a4be0d6"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 110,
                BiArea = 25,
                Floors = 1,
                Description = "Pittoreskt hus bara 50 meter från stranden. Funktioner inkluderar en luftig öppen planlösning, en inglasad veranda och en utomhusdusch. Fastigheten inkluderar en privat stig till sanden och ett förråd för surfbrädor/kajaker.",
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
                    "https://images.unsplash.com/photo-1512917774080-9991f1c4c750",
                    "https://images.unsplash.com/photo-1502672260266-1c1ef2d93688"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 220,
                BiArea = 50,
                Floors = 2,
                Description = "Hästgård med ett stall med fem boxar, ridbana och 10 hektar betesmarker. Huvudhuset inkluderar fyra sovrum, ett kök för kockar och ett solrum med utsikt över markerna. Idealisk för professionella ryttare eller hobbyister.",
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
                    "https://images.unsplash.com/photo-1605276374104-dee2a0ed3cd6",
                    "https://images.unsplash.com/photo-1600046050379-8a5d01b3f6ca"
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
                    "https://images.unsplash.com/photo-1605146769289-440113cc3d00",
                    "https://images.unsplash.com/photo-1600607687920-4e2a09cf159d"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 250,
                BiArea = 70,
                Floors = 2,
                Description = "Snyggt glasväggshus med flytande trappor och smart hem-automation. Funktioner inkluderar en takterrass, en inomhuspool och ett gourmetkök med premiumapparater. Den minimalistiska trädgården inkluderar en koi-damm och en zen-trädgård.",
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
                    "https://images.unsplash.com/photo-1582268611958-ebfd161ef9cf",
                    "https://images.unsplash.com/photo-1564013799919-ab600027ffc6"
                }
            });

            context.Residences.Add(new House
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.House,
                Area = 180,
                BiArea = 40,
                Floors = 2,
                Description = "Perfekt familjehem med en stor bakgård (lekplats inkluderad), ett modernt kök och fyra sovrum. Den färdiga källaren inkluderar ett hemmagym och ett filmhörn. Lugnt område med utmärkta skolor i närheten.",
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
                    "https://images.unsplash.com/photo-1600585154340-be6161a56a0c",
                    "https://images.unsplash.com/photo-1605276374104-dee2a0ed3cd6"
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
                    "https://images.unsplash.com/photo-1600566752355-35792bedcfea",
                    "https://images.unsplash.com/photo-1600607688969-a5bfcd646154"
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
                "https://images.unsplash.com/photo-1613490493576-7fde63acd811",
                "https://images.unsplash.com/photo-1600585152220-90363fe7e115"
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
                "https://images.unsplash.com/photo-1583608205777-3fd6d25a380b",
                "https://images.unsplash.com/photo-1570129477492-45c003edd32c"
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
                "https://images.unsplash.com/photo-1598928506088-98345a67d9b1",
                "https://images.unsplash.com/photo-1600047302983-e930cce1530a"
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
                "https://images.unsplash.com/photo-1605276374104-dee2a0ed3cd6",
                "https://images.unsplash.com/photo-1600607687920-4e2a09cf159d"
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
                "https://images.unsplash.com/photo-1512917774080-9991f1c4c750",
                "https://images.unsplash.com/photo-1583847268964-b28dc8f51f92"
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
                "https://images.unsplash.com/photo-1484154218962-a197022b5858",
                "https://images.unsplash.com/photo-1560448204-e02f11c3d0e2"
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
                "https://images.unsplash.com/photo-1493809842364-78817add7ffb",
                "https://images.unsplash.com/photo-1502672260266-1c1ef2d93688"
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
                "https://images.unsplash.com/photo-1580587771525-78b9dba3b914",
                "https://images.unsplash.com/photo-1564013799919-ab600027ffc6"
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
                "https://images.unsplash.com/photo-1571866316367-b1ffa92e90a3",
                "https://images.unsplash.com/photo-1566073741689-dbf3710f997f"
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
                "https://images.unsplash.com/photo-1541170306230-c80d6a84bcdb",
                "https://images.unsplash.com/photo-1564501049412-61c2dcab3b3b"
            }
            });

            context.Residences.Add(new VacationHouse
            {
                Address = context.Addresses.OrderBy(x => Guid.NewGuid()).First(),
                Type = ResidenceType.VacationHouse,
                Area = 70,
                BiArea = 15,
                Floors = 1,
                Description = "Enkel skärgårdsstuga med utvecklingspotential – Lurö skärgård\r\nLetar du efter ett sommarprojekt i ett av Vänerns mest unika lägen? Denna enkla men charmiga skärgårdsstuga ligger på en friköpt tomt i Lurö skärgård – endast nåbar med båt. Huvudbyggnaden på 45 kvm har en öppen planlösning, kokvrå, vedspis och två sovrum. El finns via solceller och batteribank, och vatten tas från gemensam brunn. Utedass och dusch i separat byggnad. Tomten är naturtomt med berghällar, bärbuskar och gles skog. Här finns stor potential för dig som vill renovera, bygga till eller skapa ett avskilt paradis – mitt i ett naturreservat. Tillgång till båtplats på fastlandet ingår i köpet.",
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
                "https://images.unsplash.com/photo-1522708323590-d24dbb6b0267",
                "https://images.unsplash.com/photo-1486304873000-235643847519"
            }
            });

            await context.SaveChangesAsync();
        }
    }
}

