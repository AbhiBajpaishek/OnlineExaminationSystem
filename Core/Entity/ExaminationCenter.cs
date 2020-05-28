using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entity
{
    public class ExaminationCenter :BaseEntity
    {
        [Required]
        public string Name { get; set; }    
        [Required]
        public int TotalSeatCount { get; set; } 
        [Required]
        public int SeatsAlloted { get; set; }
        public User User { get; set; }  
        
        [Column("CenterInCharge")]
        [Required]
        public int UserId { get; set; } 
        public Address Address { get; set; }
        [Required]
        public int AddressId { get; set; }

    }
}