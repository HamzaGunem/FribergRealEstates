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

        //Auth Robert
        public async Task<List<Advert>> GetAllActiveAdvertsAsync()
        {
            return await _context.Adverts.Where(s => s.Sold == false).Include(a => a.Residence)
                .ThenInclude(a => a.Address)
                .ThenInclude(c => c.Commun)
                .Include(r => r.Realtor).ToListAsync();
        }

        // Auth Robert
        public async Task<Advert> GetActiveAdvertByAdvertIdAsync(int advertId)
        {
            return await _context.Adverts
                .Include(a => a.Residence)
                .ThenInclude(r => r.Address)
                .ThenInclude(c => c.Commun)
                .Include(a => a.Realtor)
                .FirstOrDefaultAsync(a => a.Id == advertId);
        }

        public async Task<List<Advert>> GetFilteredAdvertsAsync(AdvertFilterDto filter)
        {
            IQueryable<Advert> query = _context.Adverts
                .Include(a => a.Residence)
                .ThenInclude(r => r.Address)
                .ThenInclude(c => c.Commun) // Change Robert
                .Include(a => a.Realtor)
                .ThenInclude(r => r.Agency);
             

            //Type filter
            if (filter.ResidenceTypes != null && filter.ResidenceTypes.Any())
            {
                query = query.Where(a => filter.ResidenceTypes.Contains(a.Residence.Type));
            }

            //Rooms 
            if (filter.MinRooms.HasValue)
                query = query.Where(a => a.Residence.Rooms >= filter.MinRooms.Value);
            if (filter.MaxRooms.HasValue)
                query = query.Where(a => a.Residence.Rooms <= filter.MaxRooms.Value);

            //Price 
            if (filter.MinPrice.HasValue)
                query = query.Where(a => a.CurrentPrice >= filter.MinPrice.Value);
            if (filter.MaxPrice.HasValue)
                query = query.Where(a => a.CurrentPrice <= filter.MaxPrice.Value);

            //Area 
            if (filter.MinArea.HasValue)
                query = query.Where(a => a.Residence.Area >= filter.MinArea.Value);
            if (filter.MaxArea.HasValue)
                query = query.Where(a => a.Residence.Area <= filter.MaxArea.Value);

            //Adress
            if (!string.IsNullOrEmpty(filter.Address))
            {
                query = query.Where(a => a.Residence.Address.City.Contains(filter.Address));
            }

            // OrderBy Added by Oscar
            if (!string.IsNullOrEmpty(filter.OrderBy))
            {
                bool descending = filter.OrderDescending ?? false;

                query = filter.OrderBy.ToLower() switch
                {
                    "price" => descending
                        ? query.OrderByDescending(a => a.CurrentPrice)
                        : query.OrderBy(a => a.CurrentPrice),
                    "rooms" => descending
                        ? query.OrderByDescending(a => a.Residence.Rooms)
                        : query.OrderBy(a => a.Residence.Rooms),
                    _ => query
                };
            }

            return await query.ToListAsync();
        }
    }
}
