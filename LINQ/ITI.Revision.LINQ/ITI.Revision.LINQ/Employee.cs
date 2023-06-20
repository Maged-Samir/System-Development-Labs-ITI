using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.LINQ
{
    internal class Employee:IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            
        }

        public Employee(int Id,string Name,int Age,int Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
        }

        public override string ToString()
        {
            return $"{Id}-{Name}  , {Age} Years Old - {Salary}$";
        }

        public int CompareTo(Employee? other)
        => Salary.CompareTo(other.Salary);

        public static List<Employee> empList { get; set; } = new List<Employee>()
        {
            new Employee(1,"Ahmed",20,1500),
            new Employee(3,"Mohamed",22,2000),
            new Employee(5,"Amany",21,1800),
            new Employee(2,"Sara",23,1900),
            new Employee(4,"Omnia",24,1800)
        };
    }
}
