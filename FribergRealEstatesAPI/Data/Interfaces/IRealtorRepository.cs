using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Interfaces
{
    // Created by Robert
    // Updated by Jonathan
    public interface IRealtorRepository : IRepository<Realtor>
    {

        Task<IEnumerable<Advert>> GetActiveAdvertsByRealtorIdAsync(int realtorId);
        Task<IEnumerable<Advert>> GetSoldAdvertsByRealtorIdAsync(int realtorId);
        Task<IEnumerable<Realtor>> GetRealtorsByAgencyCommunName(string agencyCommunName);  //Hamza
        Task<Realtor> GetProfileWithAgencyAsync(int realtorId);
        Task SaveChangesAsync();    // Jonathan
        Task<Realtor?> GetByApiUserIdAsync(string apiUserId);
    }
}
