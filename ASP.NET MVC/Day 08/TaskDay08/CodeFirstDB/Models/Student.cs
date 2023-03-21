using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace CodeFirstDB.Models
{
    public enum Gender { Male, Female }

    [Table("StudentInfo")]
    public class Student
    {

        public Student()
        {
            Courses = new List<Course>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        [MaxLength(30, ErrorMessage = "Max length of Your Name 30 Char")]
        [Display(Name = "Student Name")]
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


        public virtual List<Course> Courses { get; set; }
    }
}
