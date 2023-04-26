using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class Trainee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? MobileNo { get; set; }
        public DateTime Birthdate { get; set; }
        public bool IsGraduated { get; set; }
    }
}
