using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Interfaces
{
    //Auth: Hamza
    // Editions by Samuel
    public interface IAddressRepository : IRepository<Address>
    {
        Task<Address> GetAddressFullAsync(int id);
    }
}
