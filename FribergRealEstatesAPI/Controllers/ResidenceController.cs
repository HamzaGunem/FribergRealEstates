using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FribergRealEstatesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidenceController : ControllerBase
    {
        private readonly IResidenceRepository _residenceRepository;
        private readonly IAddressRepository addressRepository;
        private readonly ICommunRepository communRepository;
        private readonly IMapper mapper;

        public ResidenceController(IResidenceRepository residenceRepository,IAddressRepository addressRepository, ICommunRepository communRepository, IMapper mapper)
        {
            _residenceRepository = residenceRepository;
            this.addressRepository = addressRepository;
            this.communRepository = communRepository;
            this.mapper = mapper;
        }

        // added by Samuel
        [HttpGet("/commun")]
        public async Task<ActionResult<ResidenceSummaryDto>> GetResidencesInCommun(string communName)
        {
            var residences = await _residenceRepository.GetResidencesByCommunAsync(communName);

            var response = residences.Select(residence => mapper.Map<ResidenceSummaryDto>(residence)).ToList();

            if (response == null)
                return NotFound("No residences found");

            return Ok(response);
        }

        // added by Samuel
        [HttpGet("/commun/{communId}")]
        public async Task<ActionResult<ResidenceSummaryDto>> GetResidencesInCommunById(int communId)
        {
            var residences = await _residenceRepository.GetResidencesByCommunAsync(communId);

            var response = residences.Select(residence => mapper.Map<ResidenceSummaryDto>(residence)).ToList();

            if (response == null)
                return NotFound("No residences found");

            return Ok(response);
        }

        // Hamza
        [HttpGet("{residenceId}/full")]
        public async Task<ActionResult<ResidenceDto>> GetFullResidence(int residenceId)
        {
            var residence = await _residenceRepository.GetFullResidence(residenceId);
            if (residence == null) return NotFound();
            return Ok(mapper.Map<ResidenceDto>(residence));
        }

        // added by Samuel
        [HttpGet("{residenceId}")]
        public async Task<ActionResult<ResidenceSummaryDto>> GetResidenceById(int residenceId)
        {
            var residence = await _residenceRepository.GetByIdAsync(residenceId);
            if (residence == null)
                return NotFound();

            return Ok(mapper.Map<ResidenceSummaryDto>(residence));
        }
        //Auth: Oscar
        [HttpPost]
        public async Task<ActionResult<CreateResidenceDto>> CreateResidence(CreateResidenceDto dto)
        {
            var commun = await communRepository.GetByIdAsync(dto.CommunId);
            if (commun == null)
                return NotFound("Commun not found");
            var address = new Address
            {
                Street = dto.Street,
                PostalCode = dto.PostalCode,
                City = dto.City,
                CommunId = dto.CommunId
            };
            await addressRepository.AddAsync(address);

            var residence = new Residence
            {
                Description = dto.Description,
                Area = dto.Area,
                BiArea = dto.BiArea,
                Rooms = dto.Rooms,
                Floors = dto.Floors,
                FloorRows = dto.FloorRows,
                MonthlyFee = dto.MonthlyFee,
                OperatingCost = dto.OperatingCost,
                BuildYear = dto.BuildYear,
                ImageUrls = dto.ImageUrls,
                ParkingSlotNumber = dto.ParkingSlotNumber,
                Facilities = dto.Facilities,
                Address = address,
                IsAvailable = true
            };

        }
    }
}
