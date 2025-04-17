using System.ComponentModel.DataAnnotations;

namespace FribergRealEstatesAPI.Data.Dto
{
    public class ResidenceDTO
    {
        public int Id { get; set; }

        public int Area { get; set; } // Main living area

        public int? BiArea { get; set; } // Extra Area

        [Length(250, 500)]
        public string Description { get; set; }

        public int Rooms { get; set; }

    }
}
