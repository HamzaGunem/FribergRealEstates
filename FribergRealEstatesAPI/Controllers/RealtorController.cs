using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FribergRealEstatesAPI.Controllers
{
    // Created By Robert

    [Route("api/[controller]")]
    [ApiController]
    public class RealtorController : ControllerBase
    {
        private readonly IRealtorRepository _realtorRepository;
        private readonly IMapper mapper;

        public RealtorController(IRealtorRepository realtorRepository, IMapper mapper)
        {
            this._realtorRepository = realtorRepository;
            this.mapper = mapper;
        }

        [HttpGet("{realtorId}/active")]
        public async Task<ActionResult<List<RealtorAdvertsDto>>> GetActiveAdverts(int realtorId)
        {
            var realtor = await _realtorRepository.GetByIdAsync(realtorId);

            if (realtor == null)
                return NotFound("Realtor not found.");

            var adverts = await _realtorRepository.GetActiveAdvertsByRealtorIdAsync(realtorId);

            List<RealtorAdvertsDto> test = new List<RealtorAdvertsDto>();

            foreach (var item in adverts)
            {
                var advert = new RealtorAdvertsDto
                {
                    Id = realtorId,
                    Created = item.Created,
                    Street = item.Residence.Address.Street,
                    Commune = item.Residence.Address.Commun.Name,
                    City = item.Residence.Address.City,
                    Area = item.Residence.Area,
                    Rooms = item.Residence.Rooms,
                    CurrentPrice = item.CurrentPrice,
                    Sold = item.Sold,
                    FirstName = item.Realtor.FirstName,
                    LastName = item.Realtor.LastName,
                    Agency = item.Realtor.Agency.Name
                };

                test.Add(advert);
            }

            return Ok(test);
        }


    }
}
