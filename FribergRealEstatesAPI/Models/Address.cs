namespace FribergRealEstatesAPI.Models
{
    // Created by Robert
    public class Address
    {
        public int Id { get; set; }
        public string Steet { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public Commun Commun { get; set; }
    }
}
