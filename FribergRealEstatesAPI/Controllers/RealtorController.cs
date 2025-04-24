using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FribergRealEstatesAPI.Controllers
{
    // Created By Robert
    // Updated by Jonathan
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

        //Hamza
        [HttpGet("{communName}/byCommun")]
        public async Task<ActionResult<List<RealtorDto>>> GetRealtorsByAgencyCommun(string communName)
        {
            var realtors = await _realtorRepository.GetRealtorsByAgencyCommunName(communName);
            if (realtors == null)
                return NotFound();
            var response = _mapper.Map<List<RealtorDto>>(realtors);
            return Ok(response);
        }

        [HttpGet("{realtorId}/sold")]
        public async Task<ActionResult<List<RealtorAdvertsDto>>> GetSoldAdverts(int realtorId)
        {
            var realtor = _realtorRepository.GetByIdAsync(realtorId);

            if (realtor == null)
                return NotFound();

            var soldAdverts = await _realtorRepository.GetSoldAdvertsByRealtorIdAsync(realtorId);

            var response = _mapper.Map<List<RealtorAdvertsDto>>(soldAdverts);

            return Ok(response);
        }

        [HttpGet("{realtorId}/profile")]
        public async Task<ActionResult<RealtorProfileDto>> GetRealtorProfile(int realtorId)
        {
            var realtor = await _realtorRepository.GetProfileWithAgencyAsync(realtorId);

            if (realtor == null)
                return NotFound();

            var response = _mapper.Map<RealtorProfileDto>(realtor);

            return Ok(response);
        }

        [HttpPut("{realtorId}/profile")]    //Created by Jonathan
        public async Task<ActionResult<RealtorProfileDto>> UpdateRealtorProfile(int realtorId, [FromBody] UpdateRealtorProfileDto dto)
        {
            var realtor = await _realtorRepository.GetProfileWithAgencyAsync(realtorId);

            if (realtor == null)
                return NotFound();

            _mapper.Map(dto, realtor);

            await _realtorRepository.SaveChangesAsync();

            realtor = await _realtorRepository.GetProfileWithAgencyAsync(realtor.Id);

            var updatedRealtorProfile = _mapper.Map<RealtorProfileDto>(realtor);

            return Ok(updatedRealtorProfile);
        }
    }
}
