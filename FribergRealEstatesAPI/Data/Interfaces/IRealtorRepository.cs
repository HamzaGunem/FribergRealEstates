using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Interfaces
{
    // Created by Robert
    public interface IRealtorRepository : IRepository<Realtor>
    {

        Task<IEnumerable<Advert>> GetActiveAdvertsByRealtorIdAsync(int realtorId);
    }
}
