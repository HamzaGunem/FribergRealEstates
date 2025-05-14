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

            context.Communs.Add(new Commun
            {
                Name = "Stockholm",
                Addresses = new[] {
                    new Address
                    {
                    City = "Stockholm",
                    Street = "Drottninggatan 42",
                    PostalCode = "11121"
                    },
                    new Address
                    {
                    City = "Stockholm",
                    Street = "Kungsgatan 15",
                    PostalCode = "11143"
                    },
                    new Address
                    {
                        City = "Stockholm",
                        Street = "Sveavägen 24",
                        PostalCode = "11157"
                    },
                    new Address
                    {
                        City = "Stockholm",
                        Street = "Birger Jarlsgatan 8",
                        PostalCode = "11434"
                    },
                    new Address
                    {
                        City = "Stockholm",
                        Street = "Stureplan 2",
                        PostalCode = "11435"
                    },
                    new Address
                    {
                        City = "Stockholm",
                        Street = "Götgatan 22",
                        PostalCode = "11846"
                    },
                    new Address
                    {
                        City = "Stockholm",
                        Street = "Östermalmsgatan 16",
                        PostalCode = "11426"
                    },
                    new Address
                    {
                        City = "Stockholm",
                        Street = "Hamngatan 11",
                        PostalCode = "11147"
                    },
                    new Address
                    {
                        City = "Stockholm",
                        Street = "Fleminggatan 18",
                        PostalCode = "11226"
                    },
                    new Address
                    {
                        City = "Stockholm",
                        Street = "Hornsgatan 124",
                        PostalCode = "11728"
                    },
                    new Address
                    {
                        City = "Stockholm",
                        Street = "Södermalmstorg 1",
                        PostalCode = "11645"
                    },
                    new Address 
                    {
                        City = "Stockholm",
                        Street = "Folkungagatan 50", 
                        PostalCode = "11622" 
                    },
                    new Address 
                    { 
                        City = "Stockholm", 
                        Street = "Bondegatan 3", 
                        PostalCode = "11633" 
                    },
                    new Address 
                    { 
                        City = "Stockholm", 
                        Street = "Södermannagatan 44", 
                        PostalCode = "11623" 
                    },
                    new Address 
                    { 
                        City = "Stockholm", 
                        Street = "Tjärhovsgatan 11", 
                        PostalCode = "11628" 
                    },
                    new Address 
                    { 
                        City = "Stockholm", 
                        Street = "Wollmar Yxkullsgatan 12", 
                        PostalCode = "11850" 
                    },

                    new Address 
                    { 
                        City = "Stockholm", 
                        Street = "Strandvägen 52", 
                        PostalCode = "11456" 
                    },
                    new Address 
                    { 
                        City = "Stockholm", 
                        Street = "Smålandsgatan 7", 
                        PostalCode = "11146" 
                    },
                    new Address 
                    { 
                        City = "Stockholm", 
                        Street = "Kungsgatan 42", 
                        PostalCode = "11135" 
                    },
                    new Address 
                    { 
                        City = "Stockholm", 
                        Street = "Norrlandsgatan 15", 
                        PostalCode = "11143" 
                    },
                }
            });

            context.Communs.Add(new Commun
            {
                Name = "Göteborg",
                Addresses = new[] {
                    new Address
                    {
                    City = "Göteborg",
                    Street = "Avenyn 23",
                    PostalCode = "41136"
                    },
                    new Address
                    {
                    City = "Göteborg",
                    Street = "Nordstan 5",
                    PostalCode = "41105"
                    },
                }
            });

            context.Communs.Add(new Commun
            {
                Name = "Malmö",
                Addresses = new[] {
                    new Address
                    {
                    City = "Malmö",
                    Street = "Stortorget 1",
                    PostalCode = "21122"
                    },
                    new Address
                    {
                    City = "Malmö",
                    Street = "Turning Torso 9",
                    PostalCode = "21115"
                    },
                }
            });

            context.Communs.Add(new Commun
            {
                Name = "Umeå",
                Addresses = new[] {
                    new Address
                    {
                        City = "Umeå",
                        Street = "Storgatan 18",
                        PostalCode = "90325"
                    },
                    new Address
                    {
                        City = "Umeå",
                        Street = "Universitetsvägen 12",
                        PostalCode = "90187"
                    },
                }
            });

            context.Communs.Add(new Commun
            {
                Name = "Linköping",
                Addresses = new[] {
                    new Address
                    {
                        City = "Linköping",
                        Street = "Ågatan 32",
                        PostalCode = "58222"
                    },
                    new Address
                    {
                        City = "Linköping",
                        Street = "Stångebrovägen 7",
                        PostalCode = "58245"
                    },
                }
            });

            context.Communs.Add(new Commun
            {
                Name = "Örebro",
                Addresses = new[] {
                    new Address
                    {
                        City = "Örebro",
                        Street = "Drottninggatan 5",
                        PostalCode = "70210"
                    },
                    new Address
                    {
                        City = "Örebro",
                        Street = "Stortorget 12",
                        PostalCode = "70361"
                    },
                }
            });

            context.Communs.Add(new Commun
            {
                Name = "Västerås",
                Addresses = new[] {
                    new Address
                    {
                        City = "Västerås",
                        Street = "Kopparbergsvägen 10",
                        PostalCode = "72213"
                    },
                    new Address
                    {
                        City = "Västerås",
                        Street = "Stora gatan 45",
                        PostalCode = "72215"
                    },
                }
            });

            context.Communs.Add(new Commun
            {
                Name = "Helsingborg",
                Addresses = new[] {
                    new Address
                    {
                        City = "Helsingborg",
                        Street = "Kullagatan 18",
                        PostalCode = "25220"
                    },
                    new Address
                    {
                        City = "Helsingborg",
                        Street = "Södergatan 7",
                        PostalCode = "25225"
                    },
                }
            });

            context.Communs.Add(new Commun
            {
                Name = "Jönköping",
                Addresses = new[] {
                    new Address
                    {
                        City = "Jönköping",
                        Street = "Barnarpsgatan 12",
                        PostalCode = "55315"
                    },
                    new Address
                    {
                        City = "Jönköping",
                        Street = "Munktellstorget 3",
                        PostalCode = "55302"
                    },
                }
            });

            context.Communs.Add(new Commun
            {
                Name = "Norrköping",
                Addresses = new[] {
                    new Address
                    {
                        City = "Norrköping",
                        Street = "Drottninggatan 22",
                        PostalCode = "60224"
                    },
                    new Address
                    {
                        City = "Norrköping",
                        Street = "Knäppingsborgsvägen 5",
                        PostalCode = "60213"
                    },
                }
            });
            context.Communs.Add(new Commun
            {
                Name = "Växjö",
                Addresses = new[] {
                    new Address
                    {
                        City = "Växjö",
                        Street = "Storgatan 12",
                        PostalCode = "35230"
                    },
                    new Address
                    {
                        City = "Växjö",
                        Street = "Kronobergsgatan 5",
                        PostalCode = "35232"
                    },
                }
            });

            context.Communs.Add(new Commun
            {
                Name = "Karlstad",
                Addresses = new[] {
                    new Address
                    {
                        City = "Karlstad",
                        Street = "Drottninggatan 22",
                        PostalCode = "65224"
                    },
                    new Address
                    {
                        City = "Karlstad",
                        Street = "Kungsgatan 12",
                        PostalCode = "65225"
                    },
                }
            });

            context.Communs.Add(new Commun
            {
                Name = "Östersund",
                Addresses = new[] {
                    new Address
                    {
                        City = "Östersund",
                        Street = "Prästgatan 12",
                        PostalCode = "83132"
                    },
                    new Address
                    {
                        City = "Östersund",
                        Street = "Storgatan 42",
                        PostalCode = "83134"
                    },
                }
            });

            context.Communs.Add(new Commun
            {
                Name = "Borås",
                Addresses = new[] {
        new Address
        {
            City = "Borås",
            Street = "Allégatan 12",
            PostalCode = "50332"
        },
        new Address
        {
            City = "Borås",
            Street = "Sven Eriksonsplatsen 5",
            PostalCode = "50335"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Eskilstuna",
                Addresses = new[] {
        new Address
        {
            City = "Eskilstuna",
            Street = "Klädesholmen 7",
            PostalCode = "63220"
        },
        new Address
        {
            City = "Eskilstuna",
            Street = "Fiskartorpsvägen 3",
            PostalCode = "63230"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Södertälje",
                Addresses = new[] {
        new Address
        {
            City = "Södertälje",
            Street = "Storgatan 18",
            PostalCode = "15132"
        },
        new Address
        {
            City = "Södertälje",
            Street = "Nygatan 22",
            PostalCode = "15136"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Trollhättan",
                Addresses = new[] {
        new Address
        {
            City = "Trollhättan",
            Street = "Fabriksgatan 22",
            PostalCode = "46132"
        },
        new Address
        {
            City = "Trollhättan",
            Street = "Kanalgatan 12",
            PostalCode = "46135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Kalmar",
                Addresses = new[] {
        new Address
        {
            City = "Kalmar",
            Street = "Storgatan 18",
            PostalCode = "39232"
        },
        new Address
        {
            City = "Kalmar",
            Street = "Kaggensgatan 12",
            PostalCode = "39234"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Falun",
                Addresses = new[] {
        new Address
        {
            City = "Falun",
            Street = "Bergslagsgatan 7",
            PostalCode = "79130"
        },
        new Address
        {
            City = "Falun",
            Street = "Gruvgatan 14",
            PostalCode = "79135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Kristianstad",
                Addresses = new[] {
        new Address
        {
            City = "Kristianstad",
            Street = "Västra Storgatan 18",
            PostalCode = "29132"
        },
        new Address
        {
            City = "Kristianstad",
            Street = "Östra Boulevarden 12",
            PostalCode = "29135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Halmstad",
                Addresses = new[] {
        new Address
        {
            City = "Halmstad",
            Street = "Storgatan 22",
            PostalCode = "30242"
        },
        new Address
        {
            City = "Halmstad",
            Street = "Tylöhusgatan 12",
            PostalCode = "30245"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Skövde",
                Addresses = new[] {
        new Address
        {
            City = "Skövde",
            Street = "Västra Boulevarden 15",
            PostalCode = "54130"
        },
        new Address
        {
            City = "Skövde",
            Street = "Österlånggatan 7",
            PostalCode = "54135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Uddevalla",
                Addresses = new[] {
        new Address
        {
            City = "Uddevalla",
            Street = "Hamngatan 15",
            PostalCode = "45150"
        },
        new Address
        {
            City = "Uddevalla",
            Street = "Bohusgatan 8",
            PostalCode = "45153"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Lidingö",
                Addresses = new[] {
        new Address
        {
            City = "Lidingö",
            Street = "Herserudsvägen 12",
            PostalCode = "18130"
        },
        new Address
        {
            City = "Lidingö",
            Street = "Stickelbärsvägen 5",
            PostalCode = "18135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Mölndal",
                Addresses = new[] {
        new Address
        {
            City = "Mölndal",
            Street = "Krokslättsvägen 22",
            PostalCode = "43130"
        },
        new Address
        {
            City = "Mölndal",
            Street = "Kvarnbergsgatan 15",
            PostalCode = "43135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Landskrona",
                Addresses = new[] {
        new Address
        {
            City = "Landskrona",
            Street = "Stortorget 5",
            PostalCode = "26135"
        },
        new Address
        {
            City = "Landskrona",
            Street = "Södra Esplanaden 12",
            PostalCode = "26140"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Trelleborg",
                Addresses = new[] {
        new Address
        {
            City = "Trelleborg",
            Street = "Hamngatan 8",
            PostalCode = "23142"
        },
        new Address
        {
            City = "Trelleborg",
            Street = "Storgatan 22",
            PostalCode = "23145"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Nyköping",
                Addresses = new[] {
        new Address
        {
            City = "Nyköping",
            Street = "Strandgatan 12",
            PostalCode = "61135"
        },
        new Address
        {
            City = "Nyköping",
            Street = "Kungsgatan 18",
            PostalCode = "61140"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Karlskrona",
                Addresses = new[] {
        new Address
        {
            City = "Karlskrona",
            Street = "Stortorget 3",
            PostalCode = "37142"
        },
        new Address
        {
            City = "Karlskrona",
            Street = "Blekingegatan 12",
            PostalCode = "37145"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Visby",
                Addresses = new[] {
        new Address
        {
            City = "Visby",
            Street = "Adelsgatan 8",
            PostalCode = "62156"
        },
        new Address
        {
            City = "Visby",
            Street = "Strandgatan 12",
            PostalCode = "62157"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Sundsvall",
                Addresses = new[] {
        new Address
        {
            City = "Sundsvall",
            Street = "Storgatan 42",
            PostalCode = "85236"
        },
        new Address
        {
            City = "Sundsvall",
            Street = "Köpmangatan 15",
            PostalCode = "85240"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Gävle",
                Addresses = new[] {
        new Address
        {
            City = "Gävle",
            Street = "Drottninggatan 22",
            PostalCode = "80250"
        },
        new Address
        {
            City = "Gävle",
            Street = "Nygatan 12",
            PostalCode = "80255"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Borlänge",
                Addresses = new[] {
        new Address
        {
            City = "Borlänge",
            Street = "Stationsgatan 15",
            PostalCode = "78170"
        },
        new Address
        {
            City = "Borlänge",
            Street = "Kopparbergsvägen 8",
            PostalCode = "78175"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Alingsås",
                Addresses = new[] {
        new Address
        {
            City = "Alingsås",
            Street = "Stora Torget 5",
            PostalCode = "44138"
        },
        new Address
        {
            City = "Alingsås",
            Street = "Nolhagavägen 12",
            PostalCode = "44140"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Varberg",
                Addresses = new[] {
        new Address
        {
            City = "Varberg",
            Street = "Hamngatan 12",
            PostalCode = "43240"
        },
        new Address
        {
            City = "Varberg",
            Street = "Kustgatan 5",
            PostalCode = "43245"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Kiruna",
                Addresses = new[] {
        new Address
        {
            City = "Kiruna",
            Street = "Lars Janssonsgatan 17",
            PostalCode = "98134"
        },
        new Address
        {
            City = "Kiruna",
            Street = "Hjalmar Lundbohmsvägen 42",
            PostalCode = "98136"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Skellefteå",
                Addresses = new[] {
        new Address
        {
            City = "Skellefteå",
            Street = "Nygatan 22",
            PostalCode = "93142"
        },
        new Address
        {
            City = "Skellefteå",
            Street = "Kanalgatan 12",
            PostalCode = "93143"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Ystad",
                Addresses = new[] {
        new Address
        {
            City = "Ystad",
            Street = "Stora Östergatan 12",
            PostalCode = "27142"
        },
        new Address
        {
            City = "Ystad",
            Street = "Hamngatan 5",
            PostalCode = "27143"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Härnösand",
                Addresses = new[] {
        new Address
        {
            City = "Härnösand",
            Street = "Storgatan 18",
            PostalCode = "87130"
        },
        new Address
        {
            City = "Härnösand",
            Street = "Köpmangatan 12",
            PostalCode = "87135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Ljungby",
                Addresses = new[] {
        new Address
        {
            City = "Ljungby",
            Street = "Storgatan 22",
            PostalCode = "34130"
        },
        new Address
        {
            City = "Ljungby",
            Street = "Kronobergsvägen 15",
            PostalCode = "34135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Höganäs",
                Addresses = new[] {
        new Address
        {
            City = "Höganäs",
            Street = "Hamngatan 8",
            PostalCode = "26330"
        },
        new Address
        {
            City = "Höganäs",
            Street = "Kullagatan 12",
            PostalCode = "26335"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Ekerö",
                Addresses = new[] {
        new Address
        {
            City = "Ekerö",
            Street = "Strandvägen 15",
            PostalCode = "17830"
        },
        new Address
        {
            City = "Ekerö",
            Street = "Kungsvägen 8",
            PostalCode = "17835"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Ängelholm",
                Addresses = new[] {
        new Address
        {
            City = "Ängelholm",
            Street = "Storgatan 22",
            PostalCode = "26242"
        },
        new Address
        {
            City = "Ängelholm",
            Street = "Hamngatan 12",
            PostalCode = "26245"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Boden",
                Addresses = new[] {
        new Address
        {
            City = "Boden",
            Street = "Storgatan 15",
            PostalCode = "96136"
        },
        new Address
        {
            City = "Boden",
            Street = "Kaserngatan 8",
            PostalCode = "96140"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Piteå",
                Addresses = new[] {
        new Address
        {
            City = "Piteå",
            Street = "Storgatan 15",
            PostalCode = "94132"
        },
        new Address
        {
            City = "Piteå",
            Street = "Havsgatan 8",
            PostalCode = "94134"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Hudiksvall",
                Addresses = new[] {
        new Address
        {
            City = "Hudiksvall",
            Street = "Storgatan 22",
            PostalCode = "82430"
        },
        new Address
        {
            City = "Hudiksvall",
            Street = "Hamngatan 12",
            PostalCode = "82435"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Söderhamn",
                Addresses = new[] {
        new Address
        {
            City = "Söderhamn",
            Street = "Storgatan 18",
            PostalCode = "82630"
        },
        new Address
        {
            City = "Söderhamn",
            Street = "Hamngatan 8",
            PostalCode = "82635"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Avesta",
                Addresses = new[] {
        new Address
        {
            City = "Avesta",
            Street = "Storgatan 12",
            PostalCode = "77430"
        },
        new Address
        {
            City = "Avesta",
            Street = "Kopparvägen 5",
            PostalCode = "77435"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Ludvika",
                Addresses = new[] {
        new Address
        {
            City = "Ludvika",
            Street = "Storgatan 22",
            PostalCode = "77130"
        },
        new Address
        {
            City = "Ludvika",
            Street = "Gruvgatan 12",
            PostalCode = "77135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Mora",
                Addresses = new[] {
        new Address
        {
            City = "Mora",
            Street = "Strandvägen 15",
            PostalCode = "79230"
        },
        new Address
        {
            City = "Mora",
            Street = "Vasaloppsgatan 8",
            PostalCode = "79235"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Leksand",
                Addresses = new[] {
        new Address
        {
            City = "Leksand",
            Street = "Strandvägen 12",
            PostalCode = "79330"
        },
        new Address
        {
            City = "Leksand",
            Street = "Insjövägen 5",
            PostalCode = "79335"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Falkenberg",
                Addresses = new[] {
        new Address
        {
            City = "Falkenberg",
            Street = "Hamngatan 12",
            PostalCode = "31130"
        },
        new Address
        {
            City = "Falkenberg",
            Street = "Ågatan 8",
            PostalCode = "31135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Laholm",
                Addresses = new[] {
        new Address
        {
            City = "Laholm",
            Street = "Storgatan 15",
            PostalCode = "31230"
        },
        new Address
        {
            City = "Laholm",
            Street = "Hamngatan 8",
            PostalCode = "31235"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Lerum",
                Addresses = new[] {
        new Address
        {
            City = "Lerum",
            Street = "Storgatan 22",
            PostalCode = "44330"
        },
        new Address
        {
            City = "Lerum",
            Street = "Ågatan 12",
            PostalCode = "44335"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Kungälv",
                Addresses = new[] {
        new Address
        {
            City = "Kungälv",
            Street = "Kungsgatan 15",
            PostalCode = "44230"
        },
        new Address
        {
            City = "Kungälv",
            Street = "Bohusvägen 8",
            PostalCode = "44235"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Strömstad",
                Addresses = new[] {
        new Address
        {
            City = "Strömstad",
            Street = "Kurpromenaden 8",
            PostalCode = "45230"
        },
        new Address
        {
            City = "Strömstad",
            Street = "Hamngatan 12",
            PostalCode = "45235"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Tidaholm",
                Addresses = new[] {
        new Address
        {
            City = "Tidaholm",
            Street = "Storgatan 22",
            PostalCode = "52230"
        },
        new Address
        {
            City = "Tidaholm",
            Street = "Industrigatan 12",
            PostalCode = "52235"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Skara",
                Addresses = new[] {
        new Address
        {
            City = "Skara",
            Street = "Storgatan 15",
            PostalCode = "53230"
        },
        new Address
        {
            City = "Skara",
            Street = "Domkyrkogatan 8",
            PostalCode = "53235"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Mariestad",
                Addresses = new[] {
        new Address
        {
            City = "Mariestad",
            Street = "Storgatan 22",
            PostalCode = "54230"
        },
        new Address
        {
            City = "Mariestad",
            Street = "Hamngatan 12",
            PostalCode = "54235"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Lidköping",
                Addresses = new[] {
        new Address
        {
            City = "Lidköping",
            Street = "Storgatan 15",
            PostalCode = "53130"
        },
        new Address
        {
            City = "Lidköping",
            Street = "Kanalgatan 8",
            PostalCode = "53135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Tranemo",
                Addresses = new[] {
        new Address
        {
            City = "Tranemo",
            Street = "Storgatan 12",
            PostalCode = "51430"
        },
        new Address
        {
            City = "Tranemo",
            Street = "Industrigatan 5",
            PostalCode = "51435"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Ulricehamn",
                Addresses = new[] {
        new Address
        {
            City = "Ulricehamn",
            Street = "Storgatan 22",
            PostalCode = "52330"
        },
        new Address
        {
            City = "Ulricehamn",
            Street = "Ågatan 12",
            PostalCode = "52335"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Värnamo",
                Addresses = new[] {
        new Address
        {
            City = "Värnamo",
            Street = "Storgatan 15",
            PostalCode = "33130"
        },
        new Address
        {
            City = "Värnamo",
            Street = "Kungsgatan 8",
            PostalCode = "33135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Gislaved",
                Addresses = new[] {
        new Address
        {
            City = "Gislaved",
            Street = "Storgatan 22",
            PostalCode = "33230"
        },
        new Address
        {
            City = "Gislaved",
            Street = "Industrigatan 12",
            PostalCode = "33235"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Vetlanda",
                Addresses = new[] {
        new Address
        {
            City = "Vetlanda",
            Street = "Storgatan 15",
            PostalCode = "57430"
        },
        new Address
        {
            City = "Vetlanda",
            Street = "Kungsgatan 8",
            PostalCode = "57435"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Nässjö",
                Addresses = new[] {
        new Address
        {
            City = "Nässjö",
            Street = "Storgatan 22",
            PostalCode = "57130"
        },
        new Address
        {
            City = "Nässjö",
            Street = "Järnvägsgatan 12",
            PostalCode = "57135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Eksjö",
                Addresses = new[] {
        new Address
        {
            City = "Eksjö",
            Street = "Stortorget 5",
            PostalCode = "57530"
        },
        new Address
        {
            City = "Eksjö",
            Street = "Kyrkogatan 8",
            PostalCode = "57535"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Tranås",
                Addresses = new[] {
        new Address
        {
            City = "Tranås",
            Street = "Storgatan 15",
            PostalCode = "57330"
        },
        new Address
        {
            City = "Tranås",
            Street = "Järnvägsgatan 8",
            PostalCode = "57335"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Sävsjö",
                Addresses = new[] {
        new Address
        {
            City = "Sävsjö",
            Street = "Storgatan 12",
            PostalCode = "57630"
        },
        new Address
        {
            City = "Sävsjö",
            Street = "Kyrkogatan 5",
            PostalCode = "57635"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Hjo",
                Addresses = new[] {
        new Address
        {
            City = "Hjo",
            Street = "Strandgatan 15",
            PostalCode = "54430"
        },
        new Address
        {
            City = "Hjo",
            Street = "Storgatan 8",
            PostalCode = "54435"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Tibro",
                Addresses = new[] {
        new Address
        {
            City = "Tibro",
            Street = "Storgatan 22",
            PostalCode = "54330"
        },
        new Address
        {
            City = "Tibro",
            Street = "Industrigatan 12",
            PostalCode = "54335"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Karlsborg",
                Addresses = new[] {
        new Address
        {
            City = "Karlsborg",
            Street = "Fästningsgatan 15",
            PostalCode = "54630"
        },
        new Address
        {
            City = "Karlsborg",
            Street = "Kanalgatan 8",
            PostalCode = "54635"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Hällefors",
                Addresses = new[] {
        new Address
        {
            City = "Hällefors",
            Street = "Storgatan 12",
            PostalCode = "71230"
        },
        new Address
        {
            City = "Hällefors",
            Street = "Gruvgatan 5",
            PostalCode = "71235"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Laxå",
                Addresses = new[] {
        new Address
        {
            City = "Laxå",
            Street = "Storgatan 15",
            PostalCode = "71530"
        },
        new Address
        {
            City = "Laxå",
            Street = "Järnvägsgatan 8",
            PostalCode = "71535"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Haparanda",
                Addresses = new[] {
        new Address
        {
            City = "Haparanda",
            Street = "Torneåvägen 12",
            PostalCode = "95330"
        },
        new Address
        {
            City = "Haparanda",
            Street = "Stationsgatan 5",
            PostalCode = "95335"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Örnsköldsvik",
                Addresses = new[] {
        new Address
        {
            City = "Örnsköldsvik",
            Street = "Storgatan 22",
            PostalCode = "89130"
        },
        new Address
        {
            City = "Örnsköldsvik",
            Street = "Hamngatan 12",
            PostalCode = "89135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Sollefteå",
                Addresses = new[] {
        new Address
        {
            City = "Sollefteå",
            Street = "Storgatan 15",
            PostalCode = "88130"
        },
        new Address
        {
            City = "Sollefteå",
            Street = "Ågatan 8",
            PostalCode = "88135"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Kramfors",
                Addresses = new[] {
        new Address
        {
            City = "Kramfors",
            Street = "Storgatan 12",
            PostalCode = "87230"
        },
        new Address
        {
            City = "Kramfors",
            Street = "Hamngatan 5",
            PostalCode = "87235"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Sölvesborg",
                Addresses = new[] {
        new Address
        {
            City = "Sölvesborg",
            Street = "Storgatan 15",
            PostalCode = "29430"
        },
        new Address
        {
            City = "Sölvesborg",
            Street = "Hamngatan 8",
            PostalCode = "29435"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Olofström",
                Addresses = new[] {
        new Address
        {
            City = "Olofström",
            Street = "Storgatan 22",
            PostalCode = "29330"
        },
        new Address
        {
            City = "Olofström",
            Street = "Industrigatan 12",
            PostalCode = "29335"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Markaryd",
                Addresses = new[] {
        new Address
        {
            City = "Markaryd",
            Street = "Storgatan 15",
            PostalCode = "28530"
        },
        new Address
        {
            City = "Markaryd",
            Street = "Järnvägsgatan 8",
            PostalCode = "28535"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Perstorp",
                Addresses = new[] {
        new Address
        {
            City = "Perstorp",
            Street = "Storgatan 12",
            PostalCode = "28430"
        },
        new Address
        {
            City = "Perstorp",
            Street = "Industrigatan 5",
            PostalCode = "28435"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Osby",
                Addresses = new[] {
        new Address
        {
            City = "Osby",
            Street = "Storgatan 22",
            PostalCode = "28330"
        },
        new Address
        {
            City = "Osby",
            Street = "Järnvägsgatan 12",
            PostalCode = "28335"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Hörby",
                Addresses = new[] {
        new Address
        {
            City = "Hörby",
            Street = "Storgatan 15",
            PostalCode = "24230"
        },
        new Address
        {
            City = "Hörby",
            Street = "Kyrkogatan 8",
            PostalCode = "24235"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Tomelilla",
                Addresses = new[] {
        new Address
        {
            City = "Tomelilla",
            Street = "Storgatan 12",
            PostalCode = "27330"
        },
        new Address
        {
            City = "Tomelilla",
            Street = "Järnvägsgatan 5",
            PostalCode = "27335"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Simrishamn",
                Addresses = new[] {
        new Address
        {
            City = "Simrishamn",
            Street = "Storgatan 22",
            PostalCode = "27230"
        },
        new Address
        {
            City = "Simrishamn",
            Street = "Hamngatan 12",
            PostalCode = "27235"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Älmhult",
                Addresses = new[] {
        new Address
        {
            City = "Älmhult",
            Street = "Storgatan 15",
            PostalCode = "34330"
        },
        new Address
        {
            City = "Älmhult",
            Street = "IKEAgatan 8",
            PostalCode = "34335"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Tingsryd",
                Addresses = new[] {
        new Address
        {
            City = "Tingsryd",
            Street = "Storgatan 12",
            PostalCode = "36230"
        },
        new Address
        {
            City = "Tingsryd",
            Street = "Sjögatan 5",
            PostalCode = "36235"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Lessebo",
                Addresses = new[] {
        new Address
        {
            City = "Lessebo",
            Street = "Storgatan 15",
            PostalCode = "36030"
        },
        new Address
        {
            City = "Lessebo",
            Street = "Pappersbruksvägen 8",
            PostalCode = "36035"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Uppvidinge",
                Addresses = new[] {
        new Address
        {
            City = "Uppvidinge",
            Street = "Storgatan 12",
            PostalCode = "36070"
        },
        new Address
        {
            City = "Uppvidinge",
            Street = "Kyrkogatan 5",
            PostalCode = "36075"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Alvesta",
                Addresses = new[] {
        new Address
        {
            City = "Alvesta",
            Street = "Storgatan 22",
            PostalCode = "34230"
        },
        new Address
        {
            City = "Alvesta",
            Street = "Järnvägsgatan 12",
            PostalCode = "34235"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Gnosjö",
                Addresses = new[] {
        new Address
        {
            City = "Gnosjö",
            Street = "Storgatan 15",
            PostalCode = "33530"
        },
        new Address
        {
            City = "Gnosjö",
            Street = "Industrigatan 8",
            PostalCode = "33535"
        },
    }
            });

            context.Communs.Add(new Commun
            {
                Name = "Vaggeryd",
                Addresses = new[] {
        new Address
        {
            City = "Vaggeryd",
            Street = "Storgatan 12",
            PostalCode = "56730"
        },
        new Address
        {
            City = "Vaggeryd",
            Street = "Fabriksgatan 5",
            PostalCode = "56735"
        },
    }
            });
            await context.SaveChangesAsync();

        }
    }
}
