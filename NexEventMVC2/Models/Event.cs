using System.ComponentModel.DataAnnotations;

namespace NexEventMVC2.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Venue { get; set; }

        public DateTime Date { get; set; }

        public string Time { get; set; }

        public string Category { get; set; }

        public decimal TicketPrice { get; set; }

        public int Capacity { get; set; }

        public string Status { get; set; }

        public bool IsFeatured { get; set; }

        public string? ImageUrl { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public ICollection<Registration>? Registrations { get; set; }

        public ICollection<Feedback>? Feedbacks { get; set; }
    }
}