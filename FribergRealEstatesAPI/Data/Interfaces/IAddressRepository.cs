using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Interfaces
{
    //Auth: Hamza
    // Editions by Samuel
    // Updated by Jonathan
    public interface IAddressRepository : IRepository<Address>
    {
        Task<Address> GetAddressFullAsync(int id);
        Task<Address> CreateAdressAsync(AddressCreateDto dto); //Jonathan
    }
}
