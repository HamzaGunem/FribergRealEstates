using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FribergRealEstatesAPI.Controllers
{
    //Auth: Hamza
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertController : ControllerBase
    {
        private readonly IAdvertRepository advertRepository;
        private readonly IMapper mapper;

        public AdvertController(IAdvertRepository advertRepository, IMapper mapper)
        {
            this.advertRepository = advertRepository;
            this.mapper = mapper;
        }

        [HttpGet("price-range")]
        public async Task <ActionResult<List<AdvertDto>>> GetAdvertByPriceRange([FromQuery] double minPrice, [FromQuery] double maxPrice)
        {
            var adverts = await advertRepository.GetAdvertsByPriceRangeAsync(minPrice, maxPrice);
            return Ok(mapper.Map<List<AdvertDto>>(adverts));
        }

        //Auth: Hamza
        [HttpGet("{realtorId}/adverts")]
        public async Task<ActionResult<List<AdvertDto>>> GetActiveAdvertsByRealtor(int realtorId)
        {
            var adverts = await advertRepository.GetActiveAdvertsByRealtorAsync(realtorId);
            if (adverts == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<AdvertDto>>(adverts));
        }
    }
}
