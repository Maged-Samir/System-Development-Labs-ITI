using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int  Age { get; set; }

        public int TotalGrade { get; set; }

        public string Image  { get; set; }

        public override string ToString()
        {
            return $"Name : {Name}";
        }
    }
}
