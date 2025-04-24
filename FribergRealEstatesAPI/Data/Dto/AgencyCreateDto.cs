namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Jonathan
    public class AgencyCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
        public AddressCreateDto Address { get; set; }
    }
}
