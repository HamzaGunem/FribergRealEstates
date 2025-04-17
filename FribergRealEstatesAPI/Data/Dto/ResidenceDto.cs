namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Hamza
    public class ResidenceDto
    {
        public int Id { get; set; }
        public int Area { get; set; }
        public int? BiArea { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }
        public double OperatingCost { get; set; }
        public int FloorRows { get; set; } // Total floors inside apartment/house
        public double? MonthlyFee { get; set; }
        public int BuildYear { get; set; }

        public string[]? ImageUrls { get; set; }

        public int? ParkingSlotNumber { get; set; }

        public AddressDto Address { get; set; }
    }
}
