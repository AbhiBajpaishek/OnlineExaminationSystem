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

        [Required]
        public ExaminationCenter ExaminationCenter { get; set; }
        [Column("CenterPreference_1")]
        [Required]
        public int ExaminationCenterId1 { get; set; }
        [Column("CenterPreference_2")]
        [Required]
        public int ExaminationCenterId2 { get; set; }
       
        [Column("CenterPreference_3")]
        [Required]
        public int ExaminationCenterId3 { get; set; }


        
    }
}