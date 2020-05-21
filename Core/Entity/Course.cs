using System.ComponentModel.DataAnnotations;

namespace Core.Entity
{
    public class Course :BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}