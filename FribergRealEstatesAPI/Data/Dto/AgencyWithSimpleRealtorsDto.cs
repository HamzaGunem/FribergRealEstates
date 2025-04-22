namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Oscar
    public class AgencyWithSimpleRealtorsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? PictureUrl { get; set; }
        public List<SimpleRealtorDto> Realtors { get; set; } = new();
    }
}
