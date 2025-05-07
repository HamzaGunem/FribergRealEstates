using Microsoft.AspNetCore.Identity;

namespace FribergRealEstatesAPI.Data.Seeding
{
    //Auth: Hamza
    public class SeedData
    {
        public static async Task SeedAsync(ApiDbContext context, UserManager<ApiUser> userManager, RoleManager<IdentityRole> identityRole)
        {
            await UserAndRoleSeeding.SeedRolesAsync(identityRole);
            if (!context.Communs.Any())
            {
                //Seed Communs and addresses
                await CommunSeeding.SeedCommun(context);
            }
            if (!context.Agencies.Any())
            {
                //Seed Agencies and startup realtors
                await AgencySeeding.SeedAgency(context);
            }
            if (!context.Realtors.Any())
            {
                await UserAndRoleSeeding.SeedUsersAndRealtorsAsync(userManager, context);
            }
            if (!context.Residences.Any())
            {
                //Seed Residences
                await ResidenceSeeding.SeedResidences(context);
            }
            if (!context.Adverts.Any())
            {
                await AdvertSeeding.SeedAdvert(context);
            }
          
        }
    }
}
