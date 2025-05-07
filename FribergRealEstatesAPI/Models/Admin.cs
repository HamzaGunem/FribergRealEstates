using FribergRealEstatesAPI.Data;

namespace FribergRealEstatesAPI.Models
{
    // Auth Robert
    public class Admin
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? ApiUserId { get; set; }
        public ApiUser? ApiUser { get; set; }
    }
}
