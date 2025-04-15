using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FribergRealEstatesAPI.Models
{

    // Made by Samuel
    public class Residence
    {
        public int Id { get; set; }
        public double StartPrice { get; set; }
        public int Area { get; set; }

        public int? BiArea { get; set; }

        [Length(250, 500)]
        public string Description { get; set; }

        public int Rooms { get; set; }

        public int FloorRows { get; set; }

        public double? MonthlyFee { get; set; }

        public double OperatingCost { get; set; }

        public int BuildYear { get; set; }

        public string[]? ImageUrls { get; set; }

        public int? ParkingSlotNumber { get; set; }

        public virtual List<Facilities>? Facilities { get; set; }

        public bool Sold { get; set; }

        public bool IsAvailable { get; set; }

        public int? SoldPrice { get; set; }

        //Navigation
        public virtual Realtor Realtor { get; set; }
        public int RealtorId { get; set; }

        //Navigation
        public virtual Address Address { get; set; }
        public int AddressId { get; set; }
    }
}
