namespace FribergRealEstatesAPI.Models
{
    // Made by Samuel
    public class Agency
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string LogoUrl { get; set; }

        public virtual List<Realtor> Realtors { get; set; }

        public virtual Address Address { get; set; }
    }
}
