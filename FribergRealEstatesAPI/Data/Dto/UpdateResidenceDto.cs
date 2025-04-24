using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Dto
{
    public class UpdateResidenceDto
    {
        public string Description { get; set; }
        public int Area { get; set; }
        public int? BiArea { get; set; }
        public int Rooms { get; set; }
        public int? Floors { get; set; }
        public int FloorRows { get; set; }
        public double? MonthlyFee { get; set; }
        public double OperatingCost { get; set; }
        public int BuildYear { get; set; }
        public string[]? ImageUrls { get; set; }
        public int? ParkingSlotNumber { get; set; }
        public bool IsAvailable { get; set; }
        public List<Facilities>? Facilities { get; set; }
    }
}
