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

        
        // added by Samuel
        public async Task<Residence> GetResidenceByAddressAsync(int id)
        {
            return await _context.Residences.Where(a => a.AddressId == id).FirstOrDefaultAsync();
        }
            

        
        // added by Samuel
        public async Task<IEnumerable<Residence>> GetResidencesByCityAsync(string cityName)
        {
            return await _context.Communs.Where(c => c.Name.ToUpper() == cityName.ToUpper())
                .SelectMany(c => c.Residences).ToListAsync();
        }

        // added by Samuel
        public async Task<IEnumerable<Residence>> GetResidencesByCommunAsync(string communName)
        {
            return await _context.Communs.Where(c => c.Name.ToUpper() == communName.ToUpper())
                .SelectMany(c => c.Residences).ToListAsync();
        }

        // added by Samuel
        public async Task<IEnumerable<Residence>> GetResidencesByCommunAsync(int id)
        {
            return await _context.Communs.Where(c => c.Id == id)
                .SelectMany(c => c.Residences).ToListAsync();
        }
    }
}
