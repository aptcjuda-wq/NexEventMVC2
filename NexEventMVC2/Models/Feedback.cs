namespace NexEventMVC2.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        public int EventId { get; set; }

        public Event Event { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}