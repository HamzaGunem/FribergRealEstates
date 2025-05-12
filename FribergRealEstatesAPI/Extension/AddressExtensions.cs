using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Extension
{
    public static class AddressExtensions
    {
        public static bool IsSameAddress(this Address address, AddressCreateDto dto)
        {
            if (address == null || dto == null)
            {
                return false;
            }
            return address.Street == dto.Street &&
                address.PostalCode == dto.PostalCode &&
                address.City == dto.City &&
                address.CommunId == dto.CommunId;

        }
    }
}
