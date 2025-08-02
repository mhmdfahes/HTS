namespace HTS.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }

        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        public string AuthorId { get; set; }
        public User Author { get; set; }
    }
}
