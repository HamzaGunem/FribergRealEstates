namespace FribergRealEstatesAPI.Data.Dto
{
    public class AdvertCreateDto
    {
        public DateTime Created { get; set; } = DateTime.Now;
        public bool Sold { get; set; }
        public double CurrentPrice { get; set; }
        public int RealtorId { get; set; }
        public int ResidenceId { get; set; }    

    }
}
