using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Interfaces
{
    //Auth: Hamza
    public interface IResidenceRepository : IRepository<Residence>
    {
        // Samuel
        Task<Residence> GetResidenceByAddressAsync(int id);

        // Samuel
        Task<IEnumerable<Residence>> GetResidencesByCommunAsync(int communId);
        // Samuel
        Task<IEnumerable<Residence>> GetResidencesByCommunAsync(string communName);

        Task<IEnumerable<Residence>> GetAvailableResidences();

        Task<Residence> GetFullResidence(int id);
    }
}
