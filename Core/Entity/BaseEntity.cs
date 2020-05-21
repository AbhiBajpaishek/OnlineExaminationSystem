using System.ComponentModel.DataAnnotations;

namespace Core.Entity
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}