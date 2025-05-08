using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Hamza
    //Additions: Oscar
    public class ResidenceDto
    {
        public int Id { get; set; }
        public int Area { get; set; }
        public int? BiArea { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }
        public double OperatingCost { get; set; }
        public int? Floors { get; set; } // Floorlevel in apartment
        public int FloorRows { get; set; } // Total floors inside apartment/house
        public double? MonthlyFee { get; set; }
        public int BuildYear { get; set; }
        public ICollection<string> ImageUrls { get; set; } // Samuel

        public List<Facilities>? Facilities { get; set; }
        public ResidenceType Type { get; set; }
        public bool IsAvailable { get; set; }

        public int? ParkingSlotNumber { get; set; }

        public AddressSummaryDto Address { get; set; }
    }
}
