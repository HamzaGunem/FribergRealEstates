﻿using System.ComponentModel.DataAnnotations;
using System.Net.Cache;

namespace FribergRealEstatesAPI.Models
{
    // Made by Samuel
    // minor change Robert
    public class Realtor
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string? PictureUrl { get; set; }

        //Navigation
        public virtual Agency Agency { get; set; }
        public int AgencyId { get; set; }
        public virtual ICollection<Advert>? ActiveAdverts { get; set; }
    }
}
