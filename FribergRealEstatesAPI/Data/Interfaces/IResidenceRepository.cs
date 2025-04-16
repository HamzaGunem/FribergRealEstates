using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Interfaces
{
    //Auth: Hamza
    public interface IResidenceRepository : IRepository<Residence>
    {

        Task<Residence> GetResidenceByAddressAsync(int id);
    }
}
