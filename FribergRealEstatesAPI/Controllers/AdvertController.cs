using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Data.Repositories;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FribergRealEstatesAPI.Controllers
{
    //Auth: Hamza
    //Edit: Viktor
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertController : ControllerBase
    {
        private readonly IAdvertRepository advertRepository;
        private readonly IRealtorRepository realtorRepository;
        private readonly IResidenceRepository residenceRepository;
        private readonly IMapper mapper;

        public AdvertController(IAdvertRepository advertRepository, IRealtorRepository realtorRepository, IResidenceRepository residenceRepository, IMapper mapper)
        {
            this.advertRepository = advertRepository;
            this.realtorRepository = realtorRepository;
            this.residenceRepository = residenceRepository;
            this.mapper = mapper;
        }

        [HttpPost("filter")]
        public async Task<ActionResult<List<AdvertDto>>> GetFilteredAdverts([FromBody] AdvertFilterDto filter)
        {
            var adverts = await advertRepository.GetFilteredAdvertsAsync(filter);
            if (filter == null)
                return NotFound();
            return Ok(mapper.Map<List<AdvertDto>>(adverts));
        }

        [HttpGet("{realtorId}/adverts")]
        public async Task<ActionResult<List<AdvertDto>>> GetActiveAdvertsByRealtor(int realtorId)
        {
            var adverts = await advertRepository.GetActiveAdvertsByRealtorAsync(realtorId);
            if (adverts == null)
                return NotFound();
            return Ok(mapper.Map<List<AdvertDto>>(adverts));
        }

        //Auth: Viktor
        [HttpGet("{advertId}/advert")] 
        public async Task<ActionResult<AdvertSummaryDto>> GetAdvertById(int advertId)
        {
            var advert = await advertRepository.GetByIdAsync(advertId);
            if (advert == null)
                return NotFound();

            return Ok(mapper.Map<AdvertSummaryDto>(advert));
        }

        //Auth: Viktor
        [HttpPost("create")]
        public async Task<ActionResult<AdvertCreateDto>> CreateAdvert(AdvertCreateDto dto)
        {
            var realtor = await realtorRepository.GetByIdAsync(dto.RealtorId);
            if (realtor == null)
                return NotFound("Mäklare hittades inte.");

            var residence = await residenceRepository.GetByIdAsync(dto.ResidenceId);
            if (residence == null)
                return NotFound("Bostad hittades inte.");

            if (!residence.IsAvailable)
                return BadRequest("Bostad är inte tillgänglig.");

            var advert = new Advert
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Sold = dto.Sold,
                CurrentPrice = dto.CurrentPrice,
                RealtorId = dto.RealtorId,
                ResidenceId = dto.ResidenceId,
            };

            await advertRepository.AddAsync(advert);
            var advertDto = mapper.Map<AdvertDto>(advert);
            return CreatedAtAction(nameof(GetAdvertById), new { advertId = advert.Id }, advertDto);
        }

        //Auth: Viktor
        [HttpPut("{advertId}/edit")]
        public async Task<ActionResult<AdvertUpdateDto>> UpdateAdvert(int advertId, AdvertUpdateDto dto)
        {
            var advert = await advertRepository.GetByIdAsync(advertId);
            if(advert == null)
                return NotFound("Annonsen hittades inte.");
            
            mapper.Map(dto, advert);
            await advertRepository.UpdateAsync(advert);
            var updatedAdvertDto = mapper.Map<AdvertDto>(advert);

            return Ok(updatedAdvertDto);
        }
    }
}
