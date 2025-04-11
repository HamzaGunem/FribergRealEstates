namespace FribergRealEstatesAPI.Models
{
    // Made by Samuel
    public class Agency
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string LogoUrl { get; set; }

        public Address Address { get; set; }

        //Navigation
        public virtual ICollection<Realtor> Realtors { get; set; }

    }
}
