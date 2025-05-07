namespace FribergRealEstatesAPI.Data.Dto
{
    // Auth Robert
    public class AdminRealtorUserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ApiUserId { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
