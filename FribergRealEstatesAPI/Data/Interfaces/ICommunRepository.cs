using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Interfaces
{
    //Auth: Hamza
    // Editions by Samuel
    public interface ICommunRepository : IRepository<Commun>
    {
        Task<Commun> GetCommunFullAsync(int id);

        Task<ICollection<Address>> GetCommunAdressesAsync(int id);

        Task<ICollection<Residence>> GetCommunResidencesAsync(int id);
    }
}
