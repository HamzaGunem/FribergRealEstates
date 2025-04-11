using System.ComponentModel.DataAnnotations;
using System.Net.Cache;

namespace FribergRealEstatesAPI.Models
{
    // Made by Samuel
    public class Realtor
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string PictureUrl { get; set; }

        public virtual Agency Agency { get; set; }

        public virtual List<Residence> ActiveResidences { get; set; }

        public virtual List<Residence> SoldResidences { get; set; }
    }
}
