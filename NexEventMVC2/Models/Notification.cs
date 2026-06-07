namespace NexEventMVC2.Models
{
    public class Notification
    {
        public int Id { get; set; }

        public int EventId { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public string Type { get; set; }

        public int RecipientCount { get; set; }

        public string Status { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}