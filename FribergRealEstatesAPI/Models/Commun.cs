namespace FribergRealEstatesAPI.Models
{
    public class Commun
    {
        // Made by Samuel
        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        public virtual List<Residence> Residences { get; set; }

    }
}
