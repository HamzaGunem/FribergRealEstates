using System.ComponentModel.DataAnnotations;

namespace FribergRealEstatesAPI.Models
{

    // Made by Samuel
    public abstract class Residence
    {
        public int Id { get; set; }

        public Address Adress { get; set; }

        public double StartPrice { get; set; }

        public int beArea { get; set; }

        public int? BiArea { get; set; }

        [Length(250, 500)]
        public string Description { get; set; }

        public int Rooms { get; set; }

        public int FloorRows { get; set; }

        public double? MonthlyFee { get; set; }

        public double OperatingCost { get; set; }

        public int BuildYear { get; set; }

        public string[] ImageUrls { get; set; }

        public int? ParkingSlotNumber { get; set; }

        public virtual List<Facilities> Facilities { get; set; }

        public virtual Realtor Realtor { get; set; }

        // Navigation
        public virtual int RealtorId { get; set; }

        public bool Sold { get; set; }

        public bool IsAvailable { get; set; }

        public int? SoldPrice { get; set; }
    }
}
