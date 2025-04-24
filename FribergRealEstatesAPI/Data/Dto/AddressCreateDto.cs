namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Jonathan
    public class AddressCreateDto
    {
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public int CommunId { get; set; }
    }
}
