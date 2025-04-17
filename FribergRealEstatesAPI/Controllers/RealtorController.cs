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
        private readonly IMapper _mapper;

        public RealtorController(IRealtorRepository realtorRepository, IMapper mapper)
        {
            this._realtorRepository = realtorRepository;
            this._mapper = mapper;
        }

        [HttpGet("{realtorId}/active")]
        public async Task<ActionResult<List<RealtorAdvertsDto>>> GetActiveAdverts(int realtorId)
        {
            var realtor = await _realtorRepository.GetByIdAsync(realtorId);

            if (realtor == null)
                return NotFound("Realtor not found.");

            var adverts = await _realtorRepository.GetActiveAdvertsByRealtorIdAsync(realtorId);

            var response = _mapper.Map<List<RealtorAdvertsDto>>(adverts);
            
            return Ok(response);
        }
    }
}
