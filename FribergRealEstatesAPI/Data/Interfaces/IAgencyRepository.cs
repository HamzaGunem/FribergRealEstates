using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FribergRealEstatesAPI.Data.Interfaces
{
    //Auth: Oscar
    //Updated by Jonathan
    public interface IAgencyRepository : IRepository<Agency>
    {
        Task<List<Agency>> GetAgenciesByCommun(string communName);
        Task<List<Agency>> GetAgenciesWithAddressesAsync();
        Task<Agency> GetAgencyWithAddressAsync(int id);
        Task<Agency> GetAgencyWithRealtors(int id);
        Task CreateAgencyAsync(Agency agency); //Jonathan


    }
}
