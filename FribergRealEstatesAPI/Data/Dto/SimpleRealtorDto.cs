namespace FribergRealEstatesAPI.Data.Dto
{
    public class SimpleRealtorDto
    {   

        //Auth: Oscar - För navigering på Search Agency
        public int Id { get; set; }  
        public string FirstName { get; set; }
        public string? PictureUrl { get; set; }

        public List<AdvertSummaryDto> ActiveAdverts { get; set; } = new();

    }
}
