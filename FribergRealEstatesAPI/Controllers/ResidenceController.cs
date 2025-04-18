using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FribergRealEstatesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidenceController : ControllerBase
    {
        private readonly IResidenceRepository _residenceRepository;
        private readonly IMapper mapper;

        public ResidenceController(IResidenceRepository residenceRepository, IMapper mapper)
        {
            _residenceRepository = residenceRepository;
            this.mapper = mapper;
        }


        [HttpGet("/city")]
        public async Task<ActionResult<ResidenceSummaryDto>> GetResidencesInCity(string cityName)
        {
            var residences = await _residenceRepository.GetResidencesByCityAsync(cityName);
                       
            var response = residences.Select(residence => mapper.Map<ResidenceSummaryDto>(residence)).ToList();

            if (response == null)
                return NotFound("No residences found");

            return Ok(response);
        }

        [HttpGet("/commun")]
        public async Task<ActionResult<ResidenceSummaryDto>> GetResidencesInCommun(string communName)
        {
            var residences = await _residenceRepository.GetResidencesByCommunAsync(communName);

            var response = residences.Select(residence => mapper.Map<ResidenceSummaryDto>(residence)).ToList();

            if (response == null)
                return NotFound("No residences found");

            return Ok(response);
        }

        [HttpGet("/commun/{communId}")]
        public async Task<ActionResult<ResidenceSummaryDto>> GetResidencesInCommunById(int communId)
        {
            var residences = await _residenceRepository.GetResidencesByCommunAsync(communId);

            var response = residences.Select(residence => mapper.Map<ResidenceSummaryDto>(residence)).ToList();

            if (response == null)
                return NotFound("No residences found");

            return Ok(response);
        }
    }
}
