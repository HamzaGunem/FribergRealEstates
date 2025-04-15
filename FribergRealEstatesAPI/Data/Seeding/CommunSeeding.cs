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
            await context.SaveChangesAsync();

        }
    }
}
