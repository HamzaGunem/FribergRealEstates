using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Repositories
{
    // Created by Robert
    public class RealtorRepository : GenericRepository<Realtor, ApiDbContext>, IRealtorRepository
    {
        public RealtorRepository(ApiDbContext context) : base(context)
        {
        }
    }
}
