using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FribergRealEstatesAPI.Controllers
{
    //Auth: Oscar   
    //Updated by Jonathan
    [Route("api/[controller]")]
    [ApiController]
    public class AgencyController : ControllerBase
    {
        private readonly IAgencyRepository agencyRepository;
        private readonly IMapper mapper;
        private readonly IAgencyService agencyService;

        public AgencyController(IAgencyRepository agencyRepository, IMapper mapper, IAgencyService agencyService)
        {
            this.agencyRepository = agencyRepository;
            this.mapper = mapper;
            this.agencyService = agencyService;
        }

        //Auth: Oscar
        [HttpGet("by-commun/{communName}")]
        public async Task<ActionResult<IEnumerable<AgencyWithSimpleRealtorsDto>>> GetAgenciesByCommun(string communName)
        {
            var agencies = await agencyRepository.GetAgenciesByCommun(communName);
            if (agencies == null || !agencies.Any())
            {
                return NotFound($"No agencies found in {communName}.");
            }
            var agencyDtos = mapper.Map<List<AgencyWithSimpleRealtorsDto>>(agencies);
            return Ok(agencyDtos);
        }

        //Auth: Oscar
        [HttpGet("{id}/with-realtors")]
        public async Task<ActionResult<AgencyWithSimpleRealtorsDto>> GetAgencyWithRealtors(int id)
        {
            var agency = await agencyRepository.GetAgencyWithRealtors(id);
            if (agency == null)
            {
                return NotFound($"Agency with ID {id} not found.");
            }
            var agencyDto = mapper.Map<AgencyWithRealtorsDto>(agency);
            return Ok(agencyDto);
        }

        // Behöver fixas

        //Auth: Jonathan
        /*[HttpPost("create")]
        public async Task<ActionResult<Agency>> CreateAgency([FromBody] AgencyCreateDto agencyDto)
        {
            if (agencyDto == null)
                return BadRequest("Misssing data");

            var agency = await agencyService.CreateAgencyAsync(agencyDto);
            return Ok(agency);
        }*/
    }
}
