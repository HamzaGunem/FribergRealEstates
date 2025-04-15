namespace FribergRealEstatesAPI.Models
{
    // Created by Robert
    public class Advert
    {
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Sold { get; set; }
        public double CurrentPrice { get; set; }
        public Realtor Realtor { get; set; }
        public int RealtorId { get; set; }
        public Residence Residence { get; set; }
        public int ResidenceId { get; set; }
    }
}
