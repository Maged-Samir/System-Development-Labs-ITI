using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaskDayFour.Models
{
    public enum Gender { Male, Female }

    [Table("EmployeeInfo")]
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        [MaxLength(30, ErrorMessage = "Max length of Your Name 30 Char")]
        [Display(Name = "EmployeeName")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please Enter Your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime JoinDate { get; set; }


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
        public string Mobile { get; set; }


        public int Salary { get; set; }



    }
}