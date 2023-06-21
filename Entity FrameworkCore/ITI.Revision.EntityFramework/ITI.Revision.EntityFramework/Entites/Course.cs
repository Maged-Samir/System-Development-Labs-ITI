using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.EntityFramework.Entites
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }

        public int Duration { get; set; }

        public int teacherId { get; set; }
        public Teacher? teacher { get; set; }

        //public List<Student> Students { get; set; }

    }
}
