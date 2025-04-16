using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRealEstatesAPI.Data.Repositories
{
    // Created by Robert
    public class RealtorRepository : GenericRepository<Realtor, ApiDbContext>, IRealtorRepository
    {
        public RealtorRepository(ApiDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Advert>> GetActiveAdvertsByRealtorIdAsync(int realtorId)
        {
            return await _context.Adverts
                .Include(r => r.Residence)
                .Include(a => a.Realtor)
                .Where(a => a.RealtorId == realtorId && !a.Sold)
                .ToListAsync();
        }
    }
}
