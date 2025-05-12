using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Extension;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

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

        // Samuel
        [HttpGet("/agencies/all")]
        public async Task<ActionResult<IEnumerable<AgencySummaryDto>>> GetAllAgencies()
        {
            var agencies = await agencyRepository.GetAllAsync();

            if (agencies == null || !agencies.Any())
            {
                return NotFound("No agencies found");
            }
            var result = mapper.Map<List<AgencySummaryDto>>(agencies);
            return Ok(result);
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

        //Auth: Oscar
        [HttpPut("{id}")]
        public async Task<ActionResult<AgencyDto>> EditAgency(int id, AgencyEditDto agencyEditDto)
        {
            var agency = await agencyRepository.GetAgencyWithAddressAsync(id);
            if (agency == null)
            {
                return NotFound($"Agency with ID {id} not found.");
            }
            var existingAddress = await addressRepository.GetAddressFullAsync(agency.Address.Id);
            if (existingAddress == null)
            {
                return NotFound($"Address with ID {agency.Address.Id} not found.");
            }

            if (!existingAddress.IsSameAddress(agencyEditDto.Address))
            {
                var newAddress = new AddressCreateDto
                {
                    Street = agencyEditDto.Address.Street,
                    PostalCode = agencyEditDto.Address.PostalCode,
                    City = agencyEditDto.Address.City,
                    CommunId = agencyEditDto.Address.CommunId

                };
                var createdAddress = await addressRepository.CreateAdressAsync(newAddress);
                agency.Address = mapper.Map<Address>(createdAddress);
            }
            mapper.Map(agencyEditDto, agency);
            await agencyRepository.UpdateAsync(agency);
            var result = mapper.Map<AgencyDto>(agency);
            return Ok(mapper.Map<AgencyDto>(agency));
        }
        [HttpGet("edit/all")]
        public async Task<ActionResult<List<AgencyEditDto>>> GetAllForEdit()
        {
            var agencies = await agencyRepository.GetAgenciesWithAddressesAsync();
            var dtos = mapper.Map<List<AgencyEditDto>>(agencies);
            return Ok(dtos);
        }

    }
}
