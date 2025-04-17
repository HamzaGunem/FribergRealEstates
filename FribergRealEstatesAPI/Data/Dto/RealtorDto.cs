namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Hamza
    public class RealtorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PictureUrl { get; set; }
        public List<AdvertSummaryDto> ActiveAdverts { get; set; } = new();
    }
}
