namespace FribergRealEstatesAPI.Models.ChatHubModels
{
    public class Dialogue
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsClosed { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
