using System.ComponentModel.DataAnnotations;

namespace HTS.Models
{
    public class Department
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
    
    }
}
