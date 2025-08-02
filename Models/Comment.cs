using System.ComponentModel.DataAnnotations;

namespace HTS.Models
{
    public class Comment
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int TicketId { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
    }
}
