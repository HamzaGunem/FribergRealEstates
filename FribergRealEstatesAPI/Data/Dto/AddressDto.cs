namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Hamza
    public class AddressDto
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }

        public string CommunName { get; set; }

        public ResidenceDTO Residence { get; set; }
    }
}