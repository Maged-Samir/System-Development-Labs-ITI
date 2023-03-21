using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace TaskDay09.Models
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


        [ForeignKey("Trainee")]
        public int TraineeID { get; set; }
        public virtual Trainee Trainee { get; set; }


    }
}
