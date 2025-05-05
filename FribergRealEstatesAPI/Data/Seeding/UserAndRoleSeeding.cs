using FribergRealEstatesAPI.Constants;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FribergRealEstatesAPI.Data.Seeding
{
    //Auth Hamza
    public static class UserAndRoleSeeding
    {
        public static async Task SeedUsersAndRealtorsAsync(UserManager<ApiUser> userManager, ApiDbContext context)
        {

            var user = new ApiUser
            {
                UserName = "realtor1@api.com",
                Email = "realtor1@api.com",
                NormalizedUserName = "REALTOR1@API.COM",
                NormalizedEmail = "REALTOR1@API.COM",
                EmailConfirmed = true,
                FirstName = "Test",
                LastName = "Realtor"
            };

            var result = await userManager.CreateAsync(user, "Realtor123!");

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, ApiRoles.Realtor);

                var realtor = new Realtor
                {
                    FirstName = "Test",
                    LastName = "Realtor",
                    Email = user.Email,
                    PhoneNumber = "0700000000",
                    ApiUserId = user.Id,
                    AgencyId = 1,
                    PictureUrl = "https://www.svtstatic.se/image-news/992/1:1/0.49/0.33/a2470c833f8e6998f3b6fbf0e0c5382dca712f40d13bd66a63f099011153e48c"
                };

                var user2 = new ApiUser
                {
                    UserName = "john.doe@api.com",
                    Email = "john.doe@api.com",
                    NormalizedUserName = "JOHN.DOE@API.COM",
                    NormalizedEmail = "JOHN.DOE@API.COM",
                    EmailConfirmed = true,
                    FirstName = "John",
                    LastName = "Doe"
                };

                var result2 = await userManager.CreateAsync(user2, "Realtor123!");
                if (result2.Succeeded)
                {
                    await userManager.AddToRoleAsync(user2, ApiRoles.Realtor);
                    var realtor2 = new Realtor
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Email = user2.Email,
                        PhoneNumber = "0701111111",
                        ApiUserId = user2.Id,
                        AgencyId = 1,
                        PictureUrl = "https://printler.com/media/photo/179657.jpg"
                    };
                    context.Realtors.Add(realtor2);
                }

                // Realtor 3
                var user3 = new ApiUser
                {
                    UserName = "jane.smith@api.com",
                    Email = "jane.smith@api.com",
                    NormalizedUserName = "JANE.SMITH@API.COM",
                    NormalizedEmail = "JANE.SMITH@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Jane",
                    LastName = "Smith"
                };

                var result3 = await userManager.CreateAsync(user3, "Realtor123!");
                if (result3.Succeeded)
                {
                    await userManager.AddToRoleAsync(user3, ApiRoles.Realtor);
                    var realtor3 = new Realtor
                    {
                        FirstName = "Jane",
                        LastName = "Smith",
                        Email = user3.Email,
                        PhoneNumber = "0702222222",
                        ApiUserId = user3.Id,
                        AgencyId = 2,
                        PictureUrl = "https://randomuser.me/api/portraits/women/2.jpg"
                    };
                    context.Realtors.Add(realtor3);
                }

                // Realtor 4
                var user4 = new ApiUser
                {
                    UserName = "michael.johnson@api.com",
                    Email = "michael.johnson@api.com",
                    NormalizedUserName = "MICHAEL.JOHNSON@API.COM",
                    NormalizedEmail = "MICHAEL.JOHNSON@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Michael",
                    LastName = "Johnson"
                };

                var result4 = await userManager.CreateAsync(user4, "Realtor123!");
                if (result4.Succeeded)
                {
                    await userManager.AddToRoleAsync(user4, ApiRoles.Realtor);
                    var realtor4 = new Realtor
                    {
                        FirstName = "Michael",
                        LastName = "Johnson",
                        Email = user4.Email,
                        PhoneNumber = "0703333333",
                        ApiUserId = user4.Id,
                        AgencyId = 1,
                        PictureUrl = "https://randomuser.me/api/portraits/men/3.jpg"
                    };
                    context.Realtors.Add(realtor4);
                }

                // Realtor 5
                var user5 = new ApiUser
                {
                    UserName = "emily.wilson@api.com",
                    Email = "emily.wilson@api.com",
                    NormalizedUserName = "EMILY.WILSON@API.COM",
                    NormalizedEmail = "EMILY.WILSON@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Emily",
                    LastName = "Wilson"
                };

                var result5 = await userManager.CreateAsync(user5, "Realtor123!");
                if (result5.Succeeded)
                {
                    await userManager.AddToRoleAsync(user5, ApiRoles.Realtor);
                    var realtor5 = new Realtor
                    {
                        FirstName = "Emily",
                        LastName = "Wilson",
                        Email = user5.Email,
                        PhoneNumber = "0704444444",
                        ApiUserId = user5.Id,
                        AgencyId = 3,
                        PictureUrl = "https://randomuser.me/api/portraits/women/4.jpg"
                    };
                    context.Realtors.Add(realtor5);
                }

                // Realtor 6
                var user6 = new ApiUser
                {
                    UserName = "david.brown@api.com",
                    Email = "david.brown@api.com",
                    NormalizedUserName = "DAVID.BROWN@API.COM",
                    NormalizedEmail = "DAVID.BROWN@API.COM",
                    EmailConfirmed = true,
                    FirstName = "David",
                    LastName = "Brown"
                };

                var result6 = await userManager.CreateAsync(user6, "Realtor123!");
                if (result6.Succeeded)
                {
                    await userManager.AddToRoleAsync(user6, ApiRoles.Realtor);
                    var realtor6 = new Realtor
                    {
                        FirstName = "David",
                        LastName = "Brown",
                        Email = user6.Email,
                        PhoneNumber = "0705555555",
                        ApiUserId = user6.Id,
                        AgencyId = 2,
                        PictureUrl = "https://randomuser.me/api/portraits/men/5.jpg"
                    };
                    context.Realtors.Add(realtor6);
                }

                // Realtor 7
                var user7 = new ApiUser
                {
                    UserName = "sarah.miller@api.com",
                    Email = "sarah.miller@api.com",
                    NormalizedUserName = "SARAH.MILLER@API.COM",
                    NormalizedEmail = "SARAH.MILLER@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Sarah",
                    LastName = "Miller"
                };

                var result7 = await userManager.CreateAsync(user7, "Realtor123!");
                if (result7.Succeeded)
                {
                    await userManager.AddToRoleAsync(user7, ApiRoles.Realtor);
                    var realtor7 = new Realtor
                    {
                        FirstName = "Sarah",
                        LastName = "Miller",
                        Email = user7.Email,
                        PhoneNumber = "0706666666",
                        ApiUserId = user7.Id,
                        AgencyId = 3,
                        PictureUrl = "https://randomuser.me/api/portraits/women/6.jpg"
                    };
                    context.Realtors.Add(realtor7);
                }

                // Realtor 8
                var user8 = new ApiUser
                {
                    UserName = "robert.taylor@api.com",
                    Email = "robert.taylor@api.com",
                    NormalizedUserName = "ROBERT.TAYLOR@API.COM",
                    NormalizedEmail = "ROBERT.TAYLOR@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Robert",
                    LastName = "Taylor"
                };

                var result8 = await userManager.CreateAsync(user8, "Realtor123!");
                if (result8.Succeeded)
                {
                    await userManager.AddToRoleAsync(user8, ApiRoles.Realtor);
                    var realtor8 = new Realtor
                    {
                        FirstName = "Robert",
                        LastName = "Taylor",
                        Email = user8.Email,
                        PhoneNumber = "0707777777",
                        ApiUserId = user8.Id,
                        AgencyId = 1,
                        PictureUrl = "https://randomuser.me/api/portraits/men/7.jpg"
                    };
                    context.Realtors.Add(realtor8);
                }

                // Realtor 9
                var user9 = new ApiUser
                {
                    UserName = "lisa.anderson@api.com",
                    Email = "lisa.anderson@api.com",
                    NormalizedUserName = "LISA.ANDERSON@API.COM",
                    NormalizedEmail = "LISA.ANDERSON@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Lisa",
                    LastName = "Anderson"
                };

                var result9 = await userManager.CreateAsync(user9, "Realtor123!");
                if (result9.Succeeded)
                {
                    await userManager.AddToRoleAsync(user9, ApiRoles.Realtor);
                    var realtor9 = new Realtor
                    {
                        FirstName = "Lisa",
                        LastName = "Anderson",
                        Email = user9.Email,
                        PhoneNumber = "0708888888",
                        ApiUserId = user9.Id,
                        AgencyId = 2,
                        PictureUrl = "https://randomuser.me/api/portraits/women/8.jpg"
                    };
                    context.Realtors.Add(realtor9);
                }

                // Realtor 10
                var user10 = new ApiUser
                {
                    UserName = "william.thomas@api.com",
                    Email = "william.thomas@api.com",
                    NormalizedUserName = "WILLIAM.THOMAS@API.COM",
                    NormalizedEmail = "WILLIAM.THOMAS@API.COM",
                    EmailConfirmed = true,
                    FirstName = "William",
                    LastName = "Thomas"
                };

                var result10 = await userManager.CreateAsync(user10, "Realtor123!");
                if (result10.Succeeded)
                {
                    await userManager.AddToRoleAsync(user10, ApiRoles.Realtor);
                    var realtor10 = new Realtor
                    {
                        FirstName = "William",
                        LastName = "Thomas",
                        Email = user10.Email,
                        PhoneNumber = "0709999999",
                        ApiUserId = user10.Id,
                        AgencyId = 3,
                        PictureUrl = "https://randomuser.me/api/portraits/men/9.jpg"
                    };
                    context.Realtors.Add(realtor10);
                }

                // Realtor 11
                var user11 = new ApiUser
                {
                    UserName = "jennifer.jackson@api.com",
                    Email = "jennifer.jackson@api.com",
                    NormalizedUserName = "JENNIFER.JACKSON@API.COM",
                    NormalizedEmail = "JENNIFER.JACKSON@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Jennifer",
                    LastName = "Jackson"
                };

                var result11 = await userManager.CreateAsync(user11, "Realtor123!");
                if (result11.Succeeded)
                {
                    await userManager.AddToRoleAsync(user11, ApiRoles.Realtor);
                    var realtor11 = new Realtor
                    {
                        FirstName = "Jennifer",
                        LastName = "Jackson",
                        Email = user11.Email,
                        PhoneNumber = "0701010101",
                        ApiUserId = user11.Id,
                        AgencyId = 1,
                        PictureUrl = "https://randomuser.me/api/portraits/women/10.jpg"
                    };
                    context.Realtors.Add(realtor11);
                }

                context.Realtors.Add(realtor);
                await context.SaveChangesAsync();
            }
        }
        public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            string[] roles = new[]
            {
                ApiRoles.User,
                ApiRoles.Admin,
                ApiRoles.SuperAdmin,
                ApiRoles.Realtor
            };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}
