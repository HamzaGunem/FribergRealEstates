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
        private readonly IMapper mapper;
        private readonly IAddressRepository addressRepository;
        public AgencyRepository(ApiDbContext context, IMapper mapper, IAddressRepository addressRepository) : base(context)
        {
            this.mapper = mapper;
            this.addressRepository = addressRepository;
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



        public async Task<Agency> GetAgencyWithRealtors(int id)
        {
            return await _context.Agencies
                .Include(a => a.Address)
                .ThenInclude(addr => addr.Commun)
                .Include(a => a.Realtors)
                .ThenInclude(a => a.ActiveAdverts)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        //Jonathan
        public async Task CreateAgencyAsync(Agency agency)
        {
            await AddAsync(agency);
        }

        public async Task<Agency> GetAgencyWithAddressAsync(int id)
        {
            return await _context.Agencies
                .Include(a => a.Address)
                .ThenInclude(addr => addr.Commun)
                .FirstOrDefaultAsync(a => a.Id == id);
        }
        //Oscar
        public async Task<List<Agency>> GetAgenciesWithAddressesAsync()
        {
            return await _context.Agencies
                .Include(a => a.Address)
                .ThenInclude(addr => addr.Commun)
                .ToListAsync();
        }
    }
}
