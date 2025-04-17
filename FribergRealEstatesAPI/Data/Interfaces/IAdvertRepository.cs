using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Interfaces
{
    //Auth: Hamza
    public interface IAdvertRepository : IRepository<Advert>
    {
        Task<List<Advert>> GetAdvertsByPriceRangeAsync(double minPrice, double maxPrice);
        Task<List<Advert>> GetActiveAdvertsByRealtorAsync(int realtorId);
    }
}
