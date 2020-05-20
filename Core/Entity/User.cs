namespace Core.Entity
{
    public class User :BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }   
        public string ContactNumber { get; set; }   
        public Role Role { get; set; }
    }
}