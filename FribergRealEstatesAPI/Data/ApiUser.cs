using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace FribergRealEstatesAPI.Data
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public virtual Realtor? Realtor { get; set; }

        public virtual Admin? Admin { get; set; }

    }
}
