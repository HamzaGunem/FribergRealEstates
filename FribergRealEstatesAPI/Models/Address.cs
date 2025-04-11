namespace FribergRealEstatesAPI.Models
{
    // Created by Robert
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }

        //Navigation
        public virtual Commun Commun { get; set; } 
        public int CommunId { get; set; }

        public virtual Residence? Residence { get; set; }
    }
}
