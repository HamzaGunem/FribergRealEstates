using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace FribergRealEstatesAPI.Controllers
{
    // created by Samuel
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _addressRepository;

        public AddressController(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        // GET: api/Address/ id
        [HttpGet("{addressId}")]
        public async Task<IActionResult> GetFullAddress(int addressId)
        {
            if (addressId <= 0)
                return NotFound(ModelState);

            // TO-DO! create and add mapping to DTO
            var address = await _addressRepository.GetAddressFullAsync(addressId);

            ResidenceDTO? residenceDto = null;

            if (address.Residence != null)
            {
                residenceDto = new ResidenceDTO
                {
                    Id = address.Residence.Id,
                    Area = address.Residence.Area,
                    BiArea = address.Residence.BiArea,
                    Description = address.Residence.Description,
                    Rooms = address.Residence.Rooms
                };
            }

            var addressDto = new AddressDto()
            {
                Id = address.Id,
                Street = address.Street,
                PostalCode = address.PostalCode,
                City = address.City,
                CommunName = address.Commun.Name,
                Residence = residenceDto
            };


            if (!ModelState.IsValid)
                return NotFound(ModelState);

            // TO-DO! return as DTO
            return Ok(addressDto);
        }

    }
}
