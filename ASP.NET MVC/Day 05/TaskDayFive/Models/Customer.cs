using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Web;

namespace TaskDayFive.Models
{
    public enum Gender { Male, Female }


    [Table("CustomerInfo")]
    public class Customer
    {

        public Customer()
        {
            Orders = new List<Order>();
        }

        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        [MaxLength(30, ErrorMessage = "Max length of Your Name 30 Char")]
        [Display(Name = "CustomerName")]
        public string Name { get; set; }



        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }


        [Required(ErrorMessage = "Please Enter Your Email ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Re-Enter Your Mail")]
        [Compare("Email", ErrorMessage = "Email Not match!!!")]
        public string ConfirmEmail { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        
        public virtual List<Order> Orders { get; set; }
    }
}