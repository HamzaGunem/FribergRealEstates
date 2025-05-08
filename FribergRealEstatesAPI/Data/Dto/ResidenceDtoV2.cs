namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth Hamza
    //Testar att fixa facilites och type
    public class ResidenceDtoV2
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public int Area { get; set; }

        public int? BiArea { get; set; }

        public string Description { get; set; }

        public int Rooms { get; set; }

        public int? Floors { get; set; }

        public int FloorRows { get; set; }

        public double? MonthlyFee { get; set; }

        public double OperatingCost { get; set; }

        public int BuildYear { get; set; }

        public ICollection<string>? ImageUrls { get; set; }

        public List<string>? Facilities { get; set; } = new();

        public bool IsAvailable { get; set; }

        public int? ParkingSlotNumber { get; set; }

        public AddressSummaryDto Address { get; set; }
    }
}
