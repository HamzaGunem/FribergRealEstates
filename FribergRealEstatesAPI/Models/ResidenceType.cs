using System.Text.Json.Serialization;

namespace FribergRealEstatesAPI.Models
{
    //Auth: Hamza
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ResidenceType
    {
        Apartment = 1,
        House = 2,
        RowHouse = 3,
        VacationHouse = 5
    }
}
