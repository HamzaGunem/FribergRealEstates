namespace FribergRealEstatesAPI.Data.Seeding
{
    public class SeedData
    {
        //Auth: Hamza
        public static async Task SeedAsync(ApiDbContext context)
        {
            if (context.Agencies != null)
            {
                //Seed Agencies
            }
            if (context.Realtors != null)
            {
                //Seed Realtors
            }
            if (context.Communs != null)
            {
                //Seed Communs
            }
            if (context.Residences != null)
            {
                //Seed Residences
            }
          
        }
    }
}
