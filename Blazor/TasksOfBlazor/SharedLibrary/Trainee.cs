using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class Trainee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20,ErrorMessage ="Too Long Name !")]
        public string? Name { get; set; }
        public string? Gender { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public string? MobileNo { get; set; }
        public DateTime Birthdate { get; set; }
        public bool IsGraduated { get; set; }
    }
}
