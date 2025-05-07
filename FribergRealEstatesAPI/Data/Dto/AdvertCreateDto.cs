namespace FribergRealEstatesAPI.Data.Dto
{
    public class AdvertCreateDto
    {
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; } 
        public bool Sold { get; set; }
        public double CurrentPrice { get; set; }
        public int RealtorId { get; set; }
        public int ResidenceId { get; set; }    
    }
}
