using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Hamza
    public class ResidenceSummaryDto
    {
        public int Id { get; set; }
        public int Area { get; set; }
        public int? BiArea { get; set; }
        public string Description { get; set; }
        public int? Floors { get; set; } 
        public int Rooms { get; set; }
        public double OperatingCost { get; set; }
        public double? MonthlyFee { get; set; }
        public int FloorRows { get; set; }
        public string[]? ImageUrls { get; set; }
        public ResidenceType Type { get; set; }
        public List<Facilities>? Facilities { get; set; }

        public AddressSummaryDto Address { get; set; }
    }

}