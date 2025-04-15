namespace FribergRealEstatesAPI.Data.Seeding
{
    //Auth: Hamza
    public class SeedData
    {
        public static async Task SeedAsync(ApiDbContext context)
        {
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
                //Seed Realtors
            }
            if (!context.Residences.Any())
            {
                //Seed Residences
                await ResidenceSeeding.SeedResidences(context);
            }
          
        }
    }
}
