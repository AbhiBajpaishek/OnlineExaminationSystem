using System.ComponentModel.DataAnnotations;

namespace Core.Entity
{
    public class Address: BaseEntity
    {
        public int PinCode { get; set; }   
        [Required]
        public string AddressLine1 { get; set; } 
        public string AddressLine2 { get; set; }
        [Required]
        public string Landmark { get; set; } 
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string  Country { get; set; }
        

    }
}