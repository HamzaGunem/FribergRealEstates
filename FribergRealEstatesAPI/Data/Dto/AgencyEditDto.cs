namespace FribergRealEstatesAPI.Data.Dto
{
    public class AgencyEditDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? LogoUrl { get; set; }
        public AddressCreateDto? Address { get; set; }
    }
}
