namespace NexEventMVC2.Models
{
    public class Registration
    {
        public int Id { get; set; }

        public int EventId { get; set; }

        public Event Event { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int TicketQuantity { get; set; }

        public decimal TotalAmount { get; set; }

        public string Status { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}