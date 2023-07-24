using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models.MetaClasses
{
    public class StudentMetadata
    {
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Date of Enrollment")]
        public DateTime EnrollmentDate { get; set; }
    }

    [MetadataType(typeof(StudentMetadata))]
    public partial class Student { }
}