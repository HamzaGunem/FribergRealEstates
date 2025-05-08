using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRealEstatesAPI.Data.Repositories
{
    //Auth: Hamza
    public class ResidenceRepository : GenericRepository<Residence, ApiDbContext>, IResidenceRepository
    {
        public ResidenceRepository(ApiDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Residence>> GetAvailableResidences()
        {
            return await _context.Residences.Where(r => r.IsAvailable == true)
                .Include(r => r.Address).ToListAsync();
        }

        public async Task<Residence> GetFullResidence(int id)
        {
            return await _context.Residences.Where(r => r.Id == id).Include(r => r.Address).FirstOrDefaultAsync();
        }


        // added by Samuel
        public async Task<Residence> GetResidenceByAddressAsync(int id)
        {
            return await _context.Residences.Where(a => a.AddressId == id).FirstOrDefaultAsync();
        }
            
                
        // added by Samuel
        public async Task<IEnumerable<Residence>> GetResidencesByCommunAsync(string communName) =>
         await _context.Residences.Where(r => r.Address.City.ToUpper() == communName.ToUpper()).ToListAsync();
        

        // added by Samuel
        public async Task<IEnumerable<Residence>> GetResidencesByCommunAsync(int id) =>
            await _context.Residences.Where(r => r.Address.CommunId == id).ToListAsync();

    }
}
