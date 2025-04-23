using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FribergRealEstatesAPI.Data.Services
{
    //Auth: Jonathan
    public class AgencyService : IAgencyService
    {
        private readonly IAgencyRepository _agencyRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public AgencyService(IAgencyRepository agencyRepository, IAddressRepository adressRepository, IMapper mapper)
        {
            _agencyRepository = agencyRepository;
            _addressRepository = adressRepository;
            _mapper = mapper;
        }

        public async Task<Agency> CreateAgencyAsync(AgencyCreateDto dto)
        {
            var existingAddress = await _addressRepository.FirstOrDefaultAsync(a =>
                a.Street == dto.Address.Street &&
                a.City == dto.Address.City &&
                a.PostalCode == dto.Address.PostalCode &&
                a.CommunId == dto.Address.CommunId);

            var addressToUse = existingAddress ?? _mapper.Map<Address>(dto.Address);

            if (existingAddress == null)
            {
                await _addressRepository.AddAsync(addressToUse);
            }

            var agency = _mapper.Map<Agency>(dto);
            agency.Address = addressToUse;
            return agency;
        }
    }
}
