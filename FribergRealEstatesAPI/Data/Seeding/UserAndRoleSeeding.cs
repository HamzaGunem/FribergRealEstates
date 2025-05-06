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
                // Realtor 12
                var user12 = new ApiUser
                {
                    UserName = "kevin.martinez@api.com",
                    Email = "kevin.martinez@api.com",
                    NormalizedUserName = "KEVIN.MARTINEZ@API.COM",
                    NormalizedEmail = "KEVIN.MARTINEZ@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Kevin",
                    LastName = "Martinez"
                };

                var result12 = await userManager.CreateAsync(user12, "Realtor123!");
                if (result12.Succeeded)
                {
                    await userManager.AddToRoleAsync(user12, ApiRoles.Realtor);
                    var realtor12 = new Realtor
                    {
                        FirstName = "Kevin",
                        LastName = "Martinez",
                        Email = user12.Email,
                        PhoneNumber = "0701110111",
                        ApiUserId = user12.Id,
                        AgencyId = 2,
                        PictureUrl = "https://randomuser.me/api/portraits/men/11.jpg"
                    };
                    context.Realtors.Add(realtor12);
                }

                // Realtor 13
                var user13 = new ApiUser
                {
                    UserName = "laura.garcia@api.com",
                    Email = "laura.garcia@api.com",
                    NormalizedUserName = "LAURA.GARCIA@API.COM",
                    NormalizedEmail = "LAURA.GARCIA@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Laura",
                    LastName = "Garcia"
                };

                var result13 = await userManager.CreateAsync(user13, "Realtor123!");
                if (result13.Succeeded)
                {
                    await userManager.AddToRoleAsync(user13, ApiRoles.Realtor);
                    var realtor13 = new Realtor
                    {
                        FirstName = "Laura",
                        LastName = "Garcia",
                        Email = user13.Email,
                        PhoneNumber = "0701212121",
                        ApiUserId = user13.Id,
                        AgencyId = 3,
                        PictureUrl = "https://randomuser.me/api/portraits/women/12.jpg"
                    };
                    context.Realtors.Add(realtor13);
                }

                // Realtor 14
                var user14 = new ApiUser
                {
                    UserName = "brian.lee@api.com",
                    Email = "brian.lee@api.com",
                    NormalizedUserName = "BRIAN.LEE@API.COM",
                    NormalizedEmail = "BRIAN.LEE@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Brian",
                    LastName = "Lee"
                };

                var result14 = await userManager.CreateAsync(user14, "Realtor123!");
                if (result14.Succeeded)
                {
                    await userManager.AddToRoleAsync(user14, ApiRoles.Realtor);
                    var realtor14 = new Realtor
                    {
                        FirstName = "Brian",
                        LastName = "Lee",
                        Email = user14.Email,
                        PhoneNumber = "0701313131",
                        ApiUserId = user14.Id,
                        AgencyId = 1,
                        PictureUrl = "https://randomuser.me/api/portraits/men/13.jpg"
                    };
                    context.Realtors.Add(realtor14);
                }

                // Realtor 15
                var user15 = new ApiUser
                {
                    UserName = "olivia.hall@api.com",
                    Email = "olivia.hall@api.com",
                    NormalizedUserName = "OLIVIA.HALL@API.COM",
                    NormalizedEmail = "OLIVIA.HALL@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Olivia",
                    LastName = "Hall"
                };

                var result15 = await userManager.CreateAsync(user15, "Realtor123!");
                if (result15.Succeeded)
                {
                    await userManager.AddToRoleAsync(user15, ApiRoles.Realtor);
                    var realtor15 = new Realtor
                    {
                        FirstName = "Olivia",
                        LastName = "Hall",
                        Email = user15.Email,
                        PhoneNumber = "0701414141",
                        ApiUserId = user15.Id,
                        AgencyId = 2,
                        PictureUrl = "https://randomuser.me/api/portraits/women/14.jpg"
                    };
                    context.Realtors.Add(realtor15);
                }

                // Realtor 16
                var user16 = new ApiUser
                {
                    UserName = "daniel.nguyen@api.com",
                    Email = "daniel.nguyen@api.com",
                    NormalizedUserName = "DANIEL.NGUYEN@API.COM",
                    NormalizedEmail = "DANIEL.NGUYEN@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Daniel",
                    LastName = "Nguyen"
                };

                var result16 = await userManager.CreateAsync(user16, "Realtor123!");
                if (result16.Succeeded)
                {
                    await userManager.AddToRoleAsync(user16, ApiRoles.Realtor);
                    var realtor16 = new Realtor
                    {
                        FirstName = "Daniel",
                        LastName = "Nguyen",
                        Email = user16.Email,
                        PhoneNumber = "0701515151",
                        ApiUserId = user16.Id,
                        AgencyId = 3,
                        PictureUrl = "https://randomuser.me/api/portraits/men/15.jpg"
                    };
                    context.Realtors.Add(realtor16);
                }

                // Realtor 17
                var user17 = new ApiUser
                {
                    UserName = "emma.clark@api.com",
                    Email = "emma.clark@api.com",
                    NormalizedUserName = "EMMA.CLARK@API.COM",
                    NormalizedEmail = "EMMA.CLARK@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Emma",
                    LastName = "Clark"
                };

                var result17 = await userManager.CreateAsync(user17, "Realtor123!");
                if (result17.Succeeded)
                {
                    await userManager.AddToRoleAsync(user17, ApiRoles.Realtor);
                    var realtor17 = new Realtor
                    {
                        FirstName = "Emma",
                        LastName = "Clark",
                        Email = user17.Email,
                        PhoneNumber = "0701616161",
                        ApiUserId = user17.Id,
                        AgencyId = 1,
                        PictureUrl = "https://randomuser.me/api/portraits/women/16.jpg"
                    };
                    context.Realtors.Add(realtor17);
                }

                // Realtor 18
                var user18 = new ApiUser
                {
                    UserName = "james.robinson@api.com",
                    Email = "james.robinson@api.com",
                    NormalizedUserName = "JAMES.ROBINSON@API.COM",
                    NormalizedEmail = "JAMES.ROBINSON@API.COM",
                    EmailConfirmed = true,
                    FirstName = "James",
                    LastName = "Robinson"
                };

                var result18 = await userManager.CreateAsync(user18, "Realtor123!");
                if (result18.Succeeded)
                {
                    await userManager.AddToRoleAsync(user18, ApiRoles.Realtor);
                    var realtor18 = new Realtor
                    {
                        FirstName = "James",
                        LastName = "Robinson",
                        Email = user18.Email,
                        PhoneNumber = "0701717171",
                        ApiUserId = user18.Id,
                        AgencyId = 2,
                        PictureUrl = "https://randomuser.me/api/portraits/men/17.jpg"
                    };
                    context.Realtors.Add(realtor18);
                }

                // Realtor 19
                var user19 = new ApiUser
                {
                    UserName = "sophia.lopez@api.com",
                    Email = "sophia.lopez@api.com",
                    NormalizedUserName = "SOPHIA.LOPEZ@API.COM",
                    NormalizedEmail = "SOPHIA.LOPEZ@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Sophia",
                    LastName = "Lopez"
                };

                var result19 = await userManager.CreateAsync(user19, "Realtor123!");
                if (result19.Succeeded)
                {
                    await userManager.AddToRoleAsync(user19, ApiRoles.Realtor);
                    var realtor19 = new Realtor
                    {
                        FirstName = "Sophia",
                        LastName = "Lopez",
                        Email = user19.Email,
                        PhoneNumber = "0701818181",
                        ApiUserId = user19.Id,
                        AgencyId = 3,
                        PictureUrl = "https://randomuser.me/api/portraits/women/18.jpg"
                    };
                    context.Realtors.Add(realtor19);
                }

                // Realtor 20
                var user20 = new ApiUser
                {
                    UserName = "benjamin.walker@api.com",
                    Email = "benjamin.walker@api.com",
                    NormalizedUserName = "BENJAMIN.WALKER@API.COM",
                    NormalizedEmail = "BENJAMIN.WALKER@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Benjamin",
                    LastName = "Walker"
                };

                var result20 = await userManager.CreateAsync(user20, "Realtor123!");
                if (result20.Succeeded)
                {
                    await userManager.AddToRoleAsync(user20, ApiRoles.Realtor);
                    var realtor20 = new Realtor
                    {
                        FirstName = "Benjamin",
                        LastName = "Walker",
                        Email = user20.Email,
                        PhoneNumber = "0701919191",
                        ApiUserId = user20.Id,
                        AgencyId = 1,
                        PictureUrl = "https://randomuser.me/api/portraits/men/19.jpg"
                    };
                    context.Realtors.Add(realtor20);
                }
                // Realtor 21
                var user21 = new ApiUser
                {
                    UserName = "charlotte.young@api.com",
                    Email = "charlotte.young@api.com",
                    NormalizedUserName = "CHARLOTTE.YOUNG@API.COM",
                    NormalizedEmail = "CHARLOTTE.YOUNG@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Charlotte",
                    LastName = "Young"
                };

                var result21 = await userManager.CreateAsync(user21, "Realtor123!");
                if (result21.Succeeded)
                {
                    await userManager.AddToRoleAsync(user21, ApiRoles.Realtor);
                    var realtor21 = new Realtor
                    {
                        FirstName = "Charlotte",
                        LastName = "Young",
                        Email = user21.Email,
                        PhoneNumber = "0702020202",
                        ApiUserId = user21.Id,
                        AgencyId = 2,
                        PictureUrl = "https://randomuser.me/api/portraits/women/20.jpg"
                    };
                    context.Realtors.Add(realtor21);
                }

                // Realtor 22
                var user22 = new ApiUser
                {
                    UserName = "matthew.king@api.com",
                    Email = "matthew.king@api.com",
                    NormalizedUserName = "MATTHEW.KING@API.COM",
                    NormalizedEmail = "MATTHEW.KING@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Matthew",
                    LastName = "King"
                };

                var result22 = await userManager.CreateAsync(user22, "Realtor123!");
                if (result22.Succeeded)
                {
                    await userManager.AddToRoleAsync(user22, ApiRoles.Realtor);
                    var realtor22 = new Realtor
                    {
                        FirstName = "Matthew",
                        LastName = "King",
                        Email = user22.Email,
                        PhoneNumber = "0702121212",
                        ApiUserId = user22.Id,
                        AgencyId = 3,
                        PictureUrl = "https://randomuser.me/api/portraits/men/21.jpg"
                    };
                    context.Realtors.Add(realtor22);
                }

                // Realtor 23
                var user23 = new ApiUser
                {
                    UserName = "isabella.scott@api.com",
                    Email = "isabella.scott@api.com",
                    NormalizedUserName = "ISABELLA.SCOTT@API.COM",
                    NormalizedEmail = "ISABELLA.SCOTT@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Isabella",
                    LastName = "Scott"
                };

                var result23 = await userManager.CreateAsync(user23, "Realtor123!");
                if (result23.Succeeded)
                {
                    await userManager.AddToRoleAsync(user23, ApiRoles.Realtor);
                    var realtor23 = new Realtor
                    {
                        FirstName = "Isabella",
                        LastName = "Scott",
                        Email = user23.Email,
                        PhoneNumber = "0702222222",
                        ApiUserId = user23.Id,
                        AgencyId = 1,
                        PictureUrl = "https://randomuser.me/api/portraits/women/22.jpg"
                    };
                    context.Realtors.Add(realtor23);
                }

                // Realtor 24
                var user24 = new ApiUser
                {
                    UserName = "ethan.adams@api.com",
                    Email = "ethan.adams@api.com",
                    NormalizedUserName = "ETHAN.ADAMS@API.COM",
                    NormalizedEmail = "ETHAN.ADAMS@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Ethan",
                    LastName = "Adams"
                };

                var result24 = await userManager.CreateAsync(user24, "Realtor123!");
                if (result24.Succeeded)
                {
                    await userManager.AddToRoleAsync(user24, ApiRoles.Realtor);
                    var realtor24 = new Realtor
                    {
                        FirstName = "Ethan",
                        LastName = "Adams",
                        Email = user24.Email,
                        PhoneNumber = "0702323232",
                        ApiUserId = user24.Id,
                        AgencyId = 2,
                        PictureUrl = "https://randomuser.me/api/portraits/men/23.jpg"
                    };
                    context.Realtors.Add(realtor24);
                }

                // Realtor 25
                var user25 = new ApiUser
                {
                    UserName = "ava.lee@api.com",
                    Email = "ava.lee@api.com",
                    NormalizedUserName = "AVA.LEE@API.COM",
                    NormalizedEmail = "AVA.LEE@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Ava",
                    LastName = "Lee"
                };

                var result25 = await userManager.CreateAsync(user25, "Realtor123!");
                if (result25.Succeeded)
                {
                    await userManager.AddToRoleAsync(user25, ApiRoles.Realtor);
                    var realtor25 = new Realtor
                    {
                        FirstName = "Ava",
                        LastName = "Lee",
                        Email = user25.Email,
                        PhoneNumber = "0702424242",
                        ApiUserId = user25.Id,
                        AgencyId = 3,
                        PictureUrl = "https://randomuser.me/api/portraits/women/24.jpg"
                    };
                    context.Realtors.Add(realtor25);
                }

                // Realtor 26
                var user26 = new ApiUser
                {
                    UserName = "alexander.hill@api.com",
                    Email = "alexander.hill@api.com",
                    NormalizedUserName = "ALEXANDER.HILL@API.COM",
                    NormalizedEmail = "ALEXANDER.HILL@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Alexander",
                    LastName = "Hill"
                };

                var result26 = await userManager.CreateAsync(user26, "Realtor123!");
                if (result26.Succeeded)
                {
                    await userManager.AddToRoleAsync(user26, ApiRoles.Realtor);
                    var realtor26 = new Realtor
                    {
                        FirstName = "Alexander",
                        LastName = "Hill",
                        Email = user26.Email,
                        PhoneNumber = "0702525252",
                        ApiUserId = user26.Id,
                        AgencyId = 1,
                        PictureUrl = "https://randomuser.me/api/portraits/men/25.jpg"
                    };
                    context.Realtors.Add(realtor26);
                }

                // Realtor 27
                var user27 = new ApiUser
                {
                    UserName = "mia.turner@api.com",
                    Email = "mia.turner@api.com",
                    NormalizedUserName = "MIA.TURNER@API.COM",
                    NormalizedEmail = "MIA.TURNER@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Mia",
                    LastName = "Turner"
                };

                var result27 = await userManager.CreateAsync(user27, "Realtor123!");
                if (result27.Succeeded)
                {
                    await userManager.AddToRoleAsync(user27, ApiRoles.Realtor);
                    var realtor27 = new Realtor
                    {
                        FirstName = "Mia",
                        LastName = "Turner",
                        Email = user27.Email,
                        PhoneNumber = "0702626262",
                        ApiUserId = user27.Id,
                        AgencyId = 2,
                        PictureUrl = "https://randomuser.me/api/portraits/women/26.jpg"
                    };
                    context.Realtors.Add(realtor27);
                }

                // Realtor 28
                var user28 = new ApiUser
                {
                    UserName = "samuel.green@api.com",
                    Email = "samuel.green@api.com",
                    NormalizedUserName = "SAMUEL.GREEN@API.COM",
                    NormalizedEmail = "SAMUEL.GREEN@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Samuel",
                    LastName = "Green"
                };

                var result28 = await userManager.CreateAsync(user28, "Realtor123!");
                if (result28.Succeeded)
                {
                    await userManager.AddToRoleAsync(user28, ApiRoles.Realtor);
                    var realtor28 = new Realtor
                    {
                        FirstName = "Samuel",
                        LastName = "Green",
                        Email = user28.Email,
                        PhoneNumber = "0702727272",
                        ApiUserId = user28.Id,
                        AgencyId = 3,
                        PictureUrl = "https://randomuser.me/api/portraits/men/27.jpg"
                    };
                    context.Realtors.Add(realtor28);
                }

                // Realtor 29
                var user29 = new ApiUser
                {
                    UserName = "grace.evans@api.com",
                    Email = "grace.evans@api.com",
                    NormalizedUserName = "GRACE.EVANS@API.COM",
                    NormalizedEmail = "GRACE.EVANS@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Grace",
                    LastName = "Evans"
                };

                var result29 = await userManager.CreateAsync(user29, "Realtor123!");
                if (result29.Succeeded)
                {
                    await userManager.AddToRoleAsync(user29, ApiRoles.Realtor);
                    var realtor29 = new Realtor
                    {
                        FirstName = "Grace",
                        LastName = "Evans",
                        Email = user29.Email,
                        PhoneNumber = "0702828282",
                        ApiUserId = user29.Id,
                        AgencyId = 1,
                        PictureUrl = "https://randomuser.me/api/portraits/women/28.jpg"
                    };
                    context.Realtors.Add(realtor29);
                }

                // Realtor 30
                var user30 = new ApiUser
                {
                    UserName = "noah.wright@api.com",
                    Email = "noah.wright@api.com",
                    NormalizedUserName = "NOAH.WRIGHT@API.COM",
                    NormalizedEmail = "NOAH.WRIGHT@API.COM",
                    EmailConfirmed = true,
                    FirstName = "Noah",
                    LastName = "Wright"
                };

                var result30 = await userManager.CreateAsync(user30, "Realtor123!");
                if (result30.Succeeded)
                {
                    await userManager.AddToRoleAsync(user30, ApiRoles.Realtor);
                    var realtor30 = new Realtor
                    {
                        FirstName = "Noah",
                        LastName = "Wright",
                        Email = user30.Email,
                        PhoneNumber = "0702929292",
                        ApiUserId = user30.Id,
                        AgencyId = 2,
                        PictureUrl = "https://randomuser.me/api/portraits/men/29.jpg"
                    };
                    context.Realtors.Add(realtor30);
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
