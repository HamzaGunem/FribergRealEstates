using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FribergRealEstatesAPI.Data.Repositories
{
    //Auth: Oscar
    //Updated by Jonathan
    public class AgencyRepository : GenericRepository<Agency, ApiDbContext>, IAgencyRepository
    {
        public AgencyRepository(ApiDbContext context) : base(context)
        {
        }

        public async Task<List<Agency>> GetAgenciesByCommun(string communName)
        {
            return await _context.Agencies
               .Include(a => a.Address)
               .ThenInclude(addr => addr.Commun)
               .Include(a => a.Realtors)
               .ThenInclude(r => r.ActiveAdverts)
               .Where(a => a.Address.Commun.Name.ToUpper() == communName.ToUpper())
               .ToListAsync();
        }

        //Jonathan
        public async Task<Agency> GetAgencyWithAddressAndCommunAsync(int id)
        {
            return await _context.Agencies
                .Include(a => a.Address)
                .ThenInclude(addr => addr.Commun)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<Agency> GetAgencyWithRealtors(int id)
        {
            return await _context.Agencies
                .Include(a => a.Address)
                .ThenInclude(addr => addr.Commun)
                .Include(a => a.Realtors)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

    }
}
