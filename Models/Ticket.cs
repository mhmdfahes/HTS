namespace HTS.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public string CreatedByUserId { get; set; }
        public User CreatedBy { get; set; }

        public string? AssignedToUserId { get; set; }
        public User? AssignedTo { get; set; }
    }
}
