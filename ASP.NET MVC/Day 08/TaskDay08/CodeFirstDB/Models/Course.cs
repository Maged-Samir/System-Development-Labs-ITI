using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace CodeFirstDB.Models
{
    [Table("CourseInfo")]
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Your Topic Name")]
        [MaxLength(30, ErrorMessage = "Max length of the Name 30 Char")]
        [Display(Name = "Topic Name")]
        public string Topic { get; set; }



        [Required(ErrorMessage = "Please Enter Grade ")]
        public int Grade { get; set; }


        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }


    }
}
