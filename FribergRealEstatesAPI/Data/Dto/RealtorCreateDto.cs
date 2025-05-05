namespace FribergRealEstatesAPI.Data.Dto
{

    //Auth: Jonathan
    public class RealtorCreateDto
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public string? PictureUrl { get; set; }
        public int AgencyId { get; set; }
    }
}
