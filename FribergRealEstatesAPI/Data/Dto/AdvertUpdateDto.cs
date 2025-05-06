namespace FribergRealEstatesAPI.Data.Dto
{
    public class AdvertUpdateDto
    {
        public DateTime Updated { get; set; } = DateTime.Now;
        public bool Sold { get; set; }
        public double CurrentPrice { get; set; }
    }
}
