using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Interfaces
{
    //Auth: Jonathan
    public interface IAgencyService
    {
        Task<Agency> CreateAgencyAsync(AgencyCreateDto dto);
    }
}
