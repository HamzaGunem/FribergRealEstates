using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FribergRealEstatesAPI.Data.Interfaces
{
    //Auth: Oscar
    public interface IAgencyRepository : IRepository<Agency>
    {
        Task<List<Agency>> GetAgenciesByCommun(string communName);

        Task<Agency> GetAgencyWithRealtors(int id);
    }
}
