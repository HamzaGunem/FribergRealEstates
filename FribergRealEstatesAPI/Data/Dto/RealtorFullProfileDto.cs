using System.Text.Json.Serialization;

namespace FribergRealEstatesAPI.Data.Dto
{
    public class RealtorFullProfileDto
    {
        public RealtorSummaryDto Realtor { get; set; }

        [JsonPropertyOrder(1)]
        [JsonPropertyName("activeAdverts")]
        public List<AdvertDto>? ActiveAdverts { get; set; }

        [JsonPropertyOrder(2)]
        [JsonPropertyName("soldAdverts")]
        public List<AdvertDto>? SoldAdverts { get; set; }

    }
}
