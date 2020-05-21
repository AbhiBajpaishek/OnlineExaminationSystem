using System.ComponentModel.DataAnnotations;

namespace Core.Entity
{
    public class User :BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }   
        [Required]
        public string ContactNumber { get; set; }   
        public Role Role { get; set; }
    }
}