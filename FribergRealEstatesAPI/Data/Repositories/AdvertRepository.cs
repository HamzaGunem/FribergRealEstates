using FribergRealEstatesAPI.Data.Dto;
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

        public async Task<List<Advert>> GetActiveAdvertsByRealtorAsync(int realtorId)
        {
            return await _context.Adverts
                .Where(a => a.RealtorId == realtorId && !a.Sold)
                .Include(a => a.Residence)
                .ThenInclude(r => r.Address) // change Robert
                .ThenInclude(c => c.Commun) // change Robert
                .Include(a => a.Realtor)
                .ToListAsync();
        }

        public async Task<List<Advert>> GetFilteredAdvertsAsync(AdvertFilterDto filter)
        {
            IQueryable<Advert> query = _context.Adverts
                .Include(a => a.Residence)
                .ThenInclude(r => r.Address)
                .ThenInclude(c => c.Commun) // Change Robert
                .Include(a => a.Realtor);

            //Type filter
            if (filter.ResidenceTypes != null && filter.ResidenceTypes.Any())
            {
                query = query.Where(a => filter.ResidenceTypes.Contains(a.Residence.Type));
            }

            //Rooms 
            if(filter.MinRooms.HasValue)
                query = query.Where(a => a.Residence.Rooms >= filter.MinRooms.Value);
            if(filter.MaxRooms.HasValue)
                query = query.Where(a => a.Residence.Rooms <= filter.MaxRooms.Value);

            //Price 
            if(filter.MinPrice.HasValue)
                query = query.Where(a => a.CurrentPrice >= filter.MinPrice.Value);
            if(filter.MaxPrice.HasValue)
                query = query.Where(a => a.CurrentPrice <= filter.MaxPrice.Value);

            //Area 
            if(filter.MinArea.HasValue)
                query = query.Where(a => a.Residence.Area >= filter.MinArea.Value);
            if(filter.MaxArea.HasValue)
                query = query.Where(a => a.Residence.Area <= filter.MaxArea.Value);

            //Adress
            if (!string.IsNullOrEmpty(filter.Address))
            {
                query = query.Where(a => a.Residence.Address.City.Contains(filter.Address));
            }

            return await query.ToListAsync();
        }
    }
}
