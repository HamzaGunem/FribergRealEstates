using AutoMapper;
using FribergRealEstatesAPI.Constants;
using FribergRealEstatesAPI.Data;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Data.Repositories;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using FribergRealEstatesAPI.Constants;

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
        private readonly UserManager<ApiUser> manager;

        public RealtorController(IRealtorRepository realtorRepository, IMapper mapper, UserManager<ApiUser> manager)
        {
            this._realtorRepository = realtorRepository;
            this._mapper = mapper;
            this.manager = manager;
        }
        //Auth: Hamza
        [HttpGet("{realtorId}/full-profile")]
        public async Task<ActionResult<RealtorFullProfileDto>> GetFullProfile(int realtorId)
        {
            var realtor = await _realtorRepository.GetProfileWithAgencyAsync(realtorId);
            if (realtor == null)
                return NotFound();

            var activeAdverts = await _realtorRepository.GetActiveAdvertsByRealtorIdAsync(realtorId);
            var soldAdverts = await _realtorRepository.GetSoldAdvertsByRealtorIdAsync(realtorId);

            return new RealtorFullProfileDto
            {
                Realtor = _mapper.Map<RealtorSummaryDto>(realtor),
                ActiveAdverts = _mapper.Map<List<AdvertDto>>(activeAdverts),
                SoldAdverts = _mapper.Map<List<AdvertDto>>(soldAdverts)
            };
            
        }

        //Auth: Robert
        [HttpGet("admin/allrealtors")]
        [Authorize(Roles = ApiRoles.SuperAdmin)]
        public async Task<ActionResult<IEnumerable<AdminRealtorUserDto>>> GetAllRealtors()
        {
            var realtors = await _realtorRepository.GetAllRealtorsAsync();
            if(realtors == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<List<AdminRealtorUserDto>>(realtors);

            return Ok(response);
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

        //Hamza, return type changed by Samuel
        [HttpGet("{communName}/realtors/byCommun")]
        public async Task<ActionResult<List<RealtorSummaryDto>>> GetRealtorsByAgencyCommun(string communName)
        {
            var realtors = await _realtorRepository.GetRealtorsByAgencyCommunName(communName);
            if (realtors == null)
                return NotFound();
            var response = _mapper.Map<List<RealtorSummaryDto>>(realtors);
            return Ok(response);
        }

        [HttpGet("{realtorId}/sold")]
        public async Task<ActionResult<List<RealtorAdvertsDto>>> GetSoldAdverts(int realtorId)
        {
            var realtor = await _realtorRepository.GetByIdAsync(realtorId);

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

        // Auth: Robert
        [HttpPut("{realtorId}/profileapiuser")]
        public async Task<IActionResult> UpdateRealtorUserApiProfile(string id, [FromBody] AdminRealtorUserDto dto)
        {
            if(id != dto.ApiUserId)
                return BadRequest();

            var user = await manager.FindByIdAsync(id);

            if(user == null)
                return NotFound();

            user.EmailConfirmed = dto.EmailConfirmed;
            
            var result = await manager.UpdateAsync(user);

            if(!result.Succeeded)
            {
                return BadRequest();
            }

            return NoContent();
        }

        // auth Robert Testdata, Changes Hamza
        [Authorize]
        [HttpGet("realtor/me")]
        public async Task<ActionResult<RealtorFullProfileDto>> GetCurrentRealtor()
        {
            var userId = User.FindFirstValue(CustomClaimTypes.Uid);

            if (string.IsNullOrEmpty(userId))
                return Unauthorized("Ingen användare hittades i token.");

            var realtor = await _realtorRepository.GetByApiUserIdAsync(userId);

            if (realtor == null)
                return NotFound("Ingen profil kopplad till denna användare.");

            var activeAdverts = await _realtorRepository.GetActiveAdvertsByRealtorIdAsync(realtor.Id);
            var soldAdverts = await _realtorRepository.GetSoldAdvertsByRealtorIdAsync(realtor.Id);

            var response = new RealtorFullProfileDto
            {
                Realtor = _mapper.Map<RealtorSummaryDto>(realtor),
                ActiveAdverts = _mapper.Map<List<AdvertDto>>(activeAdverts),
                SoldAdverts = _mapper.Map<List<AdvertDto>>(soldAdverts)
            };
            return Ok(response);
        }

        //Auth: Jonathan
        [HttpPut("create")]    
        public async Task<ActionResult<RealtorProfileDto>> CreateRealtorProfile(RealtorCreateDto realtorCreateDto)
        {
            var newRealtor = _mapper.Map<Realtor>(realtorCreateDto);

            await _realtorRepository.AddAsync(newRealtor);

            return Ok();
        }
    }
}
