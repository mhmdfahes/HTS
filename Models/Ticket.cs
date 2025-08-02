using System.ComponentModel.DataAnnotations;

namespace HTS.Models
{
    public class Ticket
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        [Required]
        public int AssigneeId { get; set; }
        [Required]
        public int StatusId { get; set; }
    }
}
