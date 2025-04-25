using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Hamza
    public class ResidenceSummaryDto
    {
        public int Id { get; set; }
        public int Area { get; set; }
        public int? BiArea { get; set; }
        public int Rooms { get; set; }
        public double OperatingCost { get; set; }
        public double? MonthlyFee { get; set; }
        public int FloorRows { get; set; }
        public string[]? ImageUrls { get; set; }
        public ResidenceType Type { get; set; }
        public List<Facilities>? Facilities { get; set; }
        public string CommuneName { get; set; } // add Robert
        public string City { get; set; } // add Robert
    }

}