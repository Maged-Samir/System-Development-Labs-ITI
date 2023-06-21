using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.EntityFramework.Entites
{
    internal class Teacher
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(20)]
        public string Name { get; set; }


        public List<Course> Courses { get; set; } = new();

        public override string ToString()
        {
            return $"{Id}-{Name}";
        }
    }
}
