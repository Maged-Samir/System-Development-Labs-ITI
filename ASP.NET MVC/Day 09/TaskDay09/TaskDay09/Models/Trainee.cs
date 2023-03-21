using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace TaskDay09.Models
{
    public enum Gender { Male, Female }

    [Table("TraineeInfo")]
    public class Trainee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        [MaxLength(30, ErrorMessage = "Max length of Your Name 30 Char")]
        [Display(Name = "Trainee Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please Enter Your Email ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Re-Enter Your Mail")]
        [Compare("Email", ErrorMessage = "Email Not match!!!")]
        public string ConfirmEmail { get; set; }


        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }



        [ForeignKey("Track")]
        public int TrackID { get; set; }
        public virtual Track Track { get; set; }


        public virtual List<Course> Courses { get; set; }=new List<Course>();   
    }
}
