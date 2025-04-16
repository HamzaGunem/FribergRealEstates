using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRealEstatesAPI.Data.Repositories
{
    //Auth: Hamza
    // Editions by Samuel
    public class CommunRepository : GenericRepository<Commun, ApiDbContext>, ICommunRepository
    {
        public CommunRepository(ApiDbContext context) : base(context)
        {
        }     

        public async Task<Commun> GetCommunFullAsync(int id)
        {
            var commun = await _context.Communs.Include(c => c.Addresses)
                .Include(c => c.Residences)
                .FirstOrDefaultAsync(c => c.Id == id);
            return commun;
        }

        public async Task<ICollection<Address>> GetCommunAdressesAsync(int id)
        {
            return await _context.Communs.Where(c => c.Id == id)
                .SelectMany(c => c.Addresses)
                .ToListAsync();
        }

        public async Task<ICollection<Residence>> GetCommunResidencesAsync(int id)
        {
            return await _context.Communs.Where(c => c.Id == id)
                .SelectMany(c => c.Residences)
                .ToListAsync();
        }
    }
}
