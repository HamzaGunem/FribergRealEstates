namespace FribergRealEstatesAPI.Data.Dto
{
    //Created by Jonathan
    public class UpdateRealtorProfileDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string? PictureUrl { get; set; }
        public string Email { get; set; }
        public int AgencyId { get; set; }
    }
}

