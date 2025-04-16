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
            var realtor = await _context.Realtors
                .Include(b => b.Agency)
                .Include(r => r.ActiveAdverts)
                .ThenInclude(l => l.Residence)
                .ThenInclude(a => a.Address)
                .ThenInclude(c => c.Commun)
                .FirstOrDefaultAsync(r => r.Id == realtorId);

            if (realtor == null || realtor.ActiveAdverts == null)
                return Enumerable.Empty<Advert>();

            return realtor.ActiveAdverts.Where(a => !a.Sold).ToList();
        }
    }
}
