using System.ComponentModel.DataAnnotations;

namespace HTS.Models
{
    public class Role
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
    }
}
