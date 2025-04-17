using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FribergRealEstatesAPI.Controllers
{
    // created by Samuel
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper mapper;

        public AddressController(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            this.mapper = mapper;
        }

        // GET: api/ Address/
        [HttpGet]
        public async Task<ActionResult<List<AddressSummaryDto>>>GetAllAddresses()
        {
            var addresses = await _addressRepository.GetAllAsync();

            var response = addresses.Select(address => mapper.Map<AddressSummaryDto>(address)).ToList();

            if (response == null)
                return NotFound("No addresses found");

            return Ok(response);
        }


        // GET: api/Address (eager)/full/ id
        [HttpGet("full/{addressId}")]
        public async Task<ActionResult<AddressDto>> GetFullAddress(int addressId)
        {
            if (addressId <= 0)
                return NotFound(ModelState);

            var address = await _addressRepository.GetAddressFullAsync(addressId);

            var response = mapper.Map<AddressDto>(address);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(response);
        }


        // GET: api/ Address (lazy)/ id
        [HttpGet("{addressId}")]
        public async Task<ActionResult<AddressSummaryDto>> GetAddressSummary(int addressId)
        {
            if (addressId <= 0)
                return NotFound(ModelState);

            var address = await _addressRepository.GetByIdAsync(addressId);

            var response = mapper.Map<AddressSummaryDto>(address);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(response);
        }

    }
}
