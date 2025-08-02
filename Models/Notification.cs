namespace HTS.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime SentAt { get; set; }
        public bool IsRead { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
