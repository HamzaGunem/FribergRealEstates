﻿using FribergRealEstatesAPI.Data.Interfaces;
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
        public async Task<Residence> GetResidenceByAddressAsync(int id) =>
            await _context.Residences.Where(a => a.AddressId == id).FirstOrDefaultAsync();
    }
}
