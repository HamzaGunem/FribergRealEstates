using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FribergRealEstatesAPI.Controllers
{
    //Auth: Oscar
    //Tested by 
    [Route("api/[controller]")]
    [ApiController]
    public class CommunController : ControllerBase
    {
        private readonly ICommunRepository communRepository;
        private readonly IMapper mapper;

        public CommunController(ICommunRepository communRepository, IMapper mapper)
        {
            this.communRepository = communRepository;
            this.mapper = mapper;
        }

        // GET: api/Commun
        [HttpGet]
        public async Task<ActionResult<List<CommunDto>>> GetAllCommuns()
        {
            var communs = await communRepository.GetAllAsync();

            if (communs == null || !communs.Any())
                return NotFound("No communs found");

            var communDtos = mapper.Map<List<CommunDto>>(communs)
                            .OrderBy(c => c.Name)
                            .ToList();
            return Ok(communDtos);
        }

    }
}
