using FribergRealEstatesAPI.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Hamza
    [SwaggerSchema(Title = "AdvertFilterDto", Description = "Filter for adverts")]
    public class AdvertFilterDto
    {
        public List<ResidenceType>? ResidenceTypes { get; set; }
        public int? MinRooms { get; set; }
        public int? MaxRooms { get; set; }
        public double? MinPrice { get; set; }
        public double? MaxPrice { get; set; }
        public double? MinArea { get; set; }
        public double? MaxArea { get; set; }
        public string? Address { get; set; }
    }
}
