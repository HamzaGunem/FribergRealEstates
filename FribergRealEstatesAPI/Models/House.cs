namespace FribergRealEstatesAPI.Models
{
    // Made by Samuel
    public class House : Residence
    {
        public int LotSize { get; set; }

        public bool Garage { get; set; }

        public int? GarageArea { get; set; }
    }
}
