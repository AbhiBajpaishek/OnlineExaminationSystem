namespace Core.Entity
{
    public class ExaminationCenter :BaseEntity
    {
        public string Name { get; set; }    
        public int TotalSeatCount { get; set; } 
        public int SeatsAlloted { get; set; }
        public User User { get; set; }  
        public string UserName { get; set; }
        public Address Address { get; set; }    
        public int AddressId { get; set; }

    }
}