namespace FribergRealEstatesAPI.Data.Dto
{
    public class RealtorFullProfileDto
    {
        public RealtorSummaryDto Realtor { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("activeAdverts")]
        public List<AdvertDto> ActiveAdverts { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("soldAdverts")]
        public List<AdvertDto> SoldAdverts { get; set; }

    }
}
