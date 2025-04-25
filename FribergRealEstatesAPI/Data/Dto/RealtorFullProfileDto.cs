namespace FribergRealEstatesAPI.Data.Dto
{
    public class RealtorFullProfileDto
    {
        public RealtorSummaryDto Realtor { get; set; }
        public List<AdvertDto> ActiveAdverts { get; set; }
        public List<AdvertDto> SoldAdverts { get; set; }

    }
}
