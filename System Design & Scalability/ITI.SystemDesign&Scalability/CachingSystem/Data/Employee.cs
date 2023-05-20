using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingSystem.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public decimal? Salary { get; set; }

        public static List<Employee> Employees { get; set; } = new List<Employee>();

    }
}
