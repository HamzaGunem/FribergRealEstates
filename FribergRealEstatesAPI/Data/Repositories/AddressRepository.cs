using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRealEstatesAPI.Data.Repositories
{
    //Auth: Hamza
    // Editions by Samuel
    public class AddressRepository : GenericRepository<Address, ApiDbContext>, IAddressRepository
    {
        private readonly IMapper mapper;
        public AddressRepository(ApiDbContext context, IMapper mapper) : base(context)
        {
            this.mapper = mapper;
        }


        public async Task<Address> GetAddressFullAsync(int id)
        {
            var address = await _context.Addresses
                .Include(a => a.Commun)
                .Include(a => a.Residence)
                .FirstOrDefaultAsync(a => a.Id == id);
            return address;

        }

        //Jonathan
        public async Task<Address> CreateAdressAsync(AddressCreateDto dto)
        {
            var existingAddress = await _context.Addresses.FirstOrDefaultAsync(a =>
                a.Street == dto.Street &&
                a.City == dto.City &&
                a.PostalCode == dto.PostalCode &&
                a.CommunId == dto.CommunId);

            var addressToUse = existingAddress ?? mapper.Map<Address>(dto);

            if (existingAddress == null)
            {
                await _context.AddAsync(addressToUse);
                await _context.SaveChangesAsync();
            }

            return addressToUse;

        }
    }
}
