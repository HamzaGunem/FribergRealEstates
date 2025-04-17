namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Hamza
    // Additions by Samuel
    public class AddressDto
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }

        public string CommunName { get; set; }

        public ResidenceSummaryDto Residence { get; set; }
    }
}