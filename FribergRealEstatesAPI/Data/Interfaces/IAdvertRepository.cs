using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Interfaces
{
    //Auth: Hamza
    public interface IAdvertRepository : IRepository<Advert>
    {
        Task<List<Advert>> GetActiveAdvertsByRealtorAsync(int realtorId);
        Task<List<Advert>> GetFilteredAdvertsAsync(AdvertFilterDto filter);
    }
}
