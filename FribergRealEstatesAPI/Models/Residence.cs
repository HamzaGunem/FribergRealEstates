using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FribergRealEstatesAPI.Models
{

    // Made by Samuel
    // Changes by Robert
    public class Residence
    {
        public int Id { get; set; }
        public double StartPrice { get; set; }
        public int Area { get; set; } // Main living area

        public int? BiArea { get; set; } // Extra Area

        [Length(250, 500)]
        public string Description { get; set; }

        public int Rooms { get; set; }
        public int? Floors { get; set; } // Floorlevel in apartment

        public int FloorRows { get; set; } // Total floors inside apartment/house

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
        public virtual Address Address { get; set; }
        public int AddressId { get; set; }
    }
}
