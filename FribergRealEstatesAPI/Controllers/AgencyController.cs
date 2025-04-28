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
        private readonly IAddressRepository addressRepository;

        public AgencyController(IAgencyRepository agencyRepository, IMapper mapper, IAddressRepository addressRepository)
        {
            this.agencyRepository = agencyRepository;
            this.addressRepository = addressRepository;
            this.mapper = mapper;
        }

        //Auth: Oscar
        [HttpGet("{communName}/agencies/byCommun")]
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

        //Auth: Jonathan
        [HttpPost("create")]
        public async Task<ActionResult<AgencyDto>> CreateAgency([FromBody] AgencyCreateDto agencyCreateDto)
        {
            var agencyToCreate = mapper.Map<Agency>(agencyCreateDto);

            if (agencyCreateDto == null)
                return BadRequest("Misssing data");

            var address = await addressRepository.CreateAdressAsync(agencyCreateDto.Address);

            mapper.Map<Address>(address);

            agencyToCreate.Address = address;

            await agencyRepository.CreateAgencyAsync(agencyToCreate);

            return Created();
        }

    }
}
