using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Interfaces
{
    // Created by Robert
    // Updated by Jonathan
    public interface IRealtorRepository : IRepository<Realtor>
    {

        Task<IEnumerable<Advert>> GetActiveAdvertsByRealtorIdAsync(int realtorId);
        Task<IEnumerable<Advert>> GetSoldAdvertsByRealtorIdAsync(int realtorId);
        Task<Realtor> GetProfileWithAgencyAsync(int realtorId);
        // Jonathan
        Task SaveChangesAsync();
    }
}
