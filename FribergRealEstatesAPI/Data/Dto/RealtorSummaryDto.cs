namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Hamza
    public class RealtorSummaryDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PictureUrl { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? AgencyName { get; set; }
    }
}