namespace FribergRealEstatesAPI.Models.ChatHubModels
{
    public class Message
    {
        public int Id { get; set; }
        public int ThreadId { get; set; }
        public string Content { get; set; }
        public string SenderName { get; set; }
        public string SenderRole { get; set; }
        public DateTime SentAt { get; set; }
    }
}
