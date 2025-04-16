namespace FribergRealEstatesAPI.Data.Dto
{
    // Created by Robert
    public class RealtorAdvertsDto
    {
        public int Id { get; set; }
        // Advertinfo
        public DateTime Created { get; set; }
        public string Street { get; set; }
        public string Commune { get; set; }
        public string City { get; set; }
        public int Area { get; set; }
        public int Rooms { get; set; }
        public double CurrentPrice { get; set; }
        public bool Sold { get; set; }
        // Realtor
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Agency { get; set; }
    }
}
