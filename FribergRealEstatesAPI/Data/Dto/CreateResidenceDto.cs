using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.Dto
{
    //Auth: Oscar
    public class CreateResidenceDto
    {
        public ResidenceType Type { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public int CommunId { get; set; }
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
        public List<Facilities>? Facilities { get; set; }

        //public int RealtorId { get; set; }
        //public double CurrentPrice { get; set; }

    }
}
