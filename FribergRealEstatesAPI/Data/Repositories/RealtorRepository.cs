using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRealEstatesAPI.Data.Repositories
{
    // Created by Robert
    // Updated by Jonathan
    public class RealtorRepository : GenericRepository<Realtor, ApiDbContext>, IRealtorRepository
    {
        public RealtorRepository(ApiDbContext context) : base(context)
        {
        }

        //Hamza
        public async Task<IEnumerable<Realtor>> GetRealtorsByAgencyCommunName(string agencyCommunName)
        {
            return await _context.Realtors
                .Include(r => r.ActiveAdverts)
                .Include(r => r.Agency)
                .ThenInclude(a => a.Address)
                .ThenInclude(a => a.Commun)
                .Where(r => r.Agency.Address.Commun.Name == agencyCommunName)
                .ToListAsync();
        }

        public async Task<IEnumerable<Advert>> GetActiveAdvertsByRealtorIdAsync(int realtorId)
        {          
            return await _context.Adverts
                    .Where(a => a.RealtorId == realtorId && !a.Sold)
                    .Include(a => a.Realtor)
                    .ThenInclude(r => r.Agency)
                    .Include(a => a.Residence)
                    .ThenInclude(res => res.Address)
                    .ThenInclude(addr => addr.Commun)
                    .ToListAsync();
        }

        public async Task<IEnumerable<Advert>> GetSoldAdvertsByRealtorIdAsync(int realtorId)
        {
            return await _context.Adverts
                    .Where(a => a.RealtorId == realtorId && a.Sold)
                    .Include(a => a.Realtor)
                    .ThenInclude(r => r.Agency)
                    .Include(a => a.Residence)
                    .ThenInclude(res => res.Address)
                    .ThenInclude(addr => addr.Commun)
                    .ToListAsync();
        }

        public async Task<Realtor> GetProfileWithAgencyAsync(int realtorId)
        {
            return await _context.Realtors.Where(r => r.Id == realtorId)
                .Include(a => a.Agency).FirstOrDefaultAsync();
        }

        
        public async Task SaveChangesAsync() // Jonathan
        {
            await _context.SaveChangesAsync();
        }


        // Auth:Robert ,TestData for Identity, Working
        public async Task<Realtor?> GetByApiUserIdAsync(string apiUserId)
        {
            return await _context.Realtors
                .Include(r => r.Agency)
                .FirstOrDefaultAsync(r => r.ApiUserId == apiUserId);
        }

        // Auth: Robert
        public async Task<IEnumerable<Realtor>> GetAllRealtorsAsync()
        {
            return await _context.Realtors
                .Include(a => a.ApiUser)
                .ToListAsync();
        }

    }
}
