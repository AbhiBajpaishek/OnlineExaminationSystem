using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entity
{
    public class Applicant:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }   
        public Course Course { get; set; }

        [Column("CourseAppliedFor")]
        public int CourseId { get; set; }
        public Address Address { get; set; }

        public ExaminationCenter ExaminationCenter { get; set; }
        
        [ForeignKey("ExaminationCenter_Pref1")]
         public ExaminationCenter ExaminationCenter_Pref_1 { get; set; }
         [ForeignKey("ExaminationCenter_Pref2")]
         public ExaminationCenter ExaminationCenter_Pref_2 { get; set; }
         [ForeignKey("ExaminationCenter_Pref3")]
         public ExaminationCenter ExaminationCenter_Pref_3 { get; set; }
        


        
    }
}