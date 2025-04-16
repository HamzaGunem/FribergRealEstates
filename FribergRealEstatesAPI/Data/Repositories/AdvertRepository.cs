using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Repositories
{
    public class AdvertRepository : GenericRepository<Advert, ApiDbContext>, IAdvertRepository
    {
        public AdvertRepository(ApiDbContext context) : base(context)
        {
        }
    }
}
