using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models.MetaClasses
{
    public class CoursesMetaData
    {
        [StringLength(50)]
        public string Title { get; set; }
        [Range(1, 8)]
        public int Credits { get; set; }
    }
    [MetadataType(typeof(CoursesMetaData))]
    public partial class Course
    {

    }
}