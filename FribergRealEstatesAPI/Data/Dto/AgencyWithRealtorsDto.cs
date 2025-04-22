namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Oscar
    public class AgencyWithRealtorsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? PictureUrl { get; set; }
        public List<RealtorDto> Realtors { get; set; }
    }
}
