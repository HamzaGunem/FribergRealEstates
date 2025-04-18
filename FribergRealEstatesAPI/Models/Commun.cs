﻿namespace FribergRealEstatesAPI.Models
{
    // Made by Samuel
    public class Commun
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Residence>? Residences { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
