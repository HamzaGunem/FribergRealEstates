using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRealEstatesAPI.Data.Repositories
{
    //Auth: Hamza
    public class AdvertRepository : GenericRepository<Advert, ApiDbContext>, IAdvertRepository
    {
        public AdvertRepository(ApiDbContext context) : base(context)
        {
        }

        public async Task<List<Advert>> GetAdvertsByPriceRangeAsync(double minPrice, double maxPrice)
        {
            return await _context.Adverts
                .Where(a => a.CurrentPrice >= minPrice && a.CurrentPrice <= maxPrice)
                .Include(a => a.Residence)
                .Include(a => a.Realtor)
                .ToListAsync();
        }

        public async Task<List<Advert>> GetActiveAdvertsByRealtorAsync(int realtorId)
        {
            return await _context.Adverts
                .Where(a => a.RealtorId == realtorId && !a.Sold)
                .Include(a => a.Residence)
                .Include(a => a.Realtor)
                .ToListAsync();
        }
    }
}
