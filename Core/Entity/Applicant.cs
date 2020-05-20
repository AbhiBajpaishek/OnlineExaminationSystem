namespace Core.Entity
{
    public class Applicant:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }   
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public ExaminationCenter ExaminationCenter { get; set; }
        public int CenterCode_1 { get; set; }
        public int CenterCode_2 { get; set; }
        public int CenterCode_3 { get; set; }
    }
}