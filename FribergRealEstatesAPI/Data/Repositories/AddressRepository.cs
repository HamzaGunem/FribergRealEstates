using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRealEstatesAPI.Data.Repositories
{
    //Auth: Hamza
    // Editions by Samuel
    public class AddressRepository : GenericRepository<Address, ApiDbContext>, IAddressRepository
    {
        public AddressRepository(ApiDbContext context) : base(context)
        {
        }


        public async Task<Address> GetAddressFullAsync(int id)
        {
            var address = await _context.Address
                .Include(a => a.Commun)
                .Include(a => a.Residence)
                .FirstOrDefaultAsync(a => a.Id == id);
            return address;

        }

        
    }
}
