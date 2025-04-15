using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Repositories
{
    //Auth: Hamza
    public class AddressRepository : GenericRepository<Address, ApiDbContext>, IAddressRepository
    {
        public AddressRepository(ApiDbContext context) : base(context)
        {
        }
    }
}
