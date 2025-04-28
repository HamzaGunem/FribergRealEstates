namespace FribergRealEstatesAPI.Data.Dto
{
    public class AgencyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
        public AddressDto Address { get; set; }
        public List<RealtorSummaryDto> Realtors { get; set; }
    }
}
