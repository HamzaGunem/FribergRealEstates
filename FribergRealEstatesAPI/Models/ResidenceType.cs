using System.Text.Json.Serialization;

namespace FribergRealEstatesAPI.Models
{
    //Auth: Hamza
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ResidenceType
    {
        Apartment,
        House,
        RowHouse,
        VacationHouse
    }
}
