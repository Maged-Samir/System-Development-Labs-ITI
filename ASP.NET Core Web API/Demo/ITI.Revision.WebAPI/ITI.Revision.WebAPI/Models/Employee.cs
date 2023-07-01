using ITI.Revision.WebAPI.Validators;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ITI.Revision.WebAPI.Models
{
    public enum Location
    {
        EG,USA,KSA,UAE
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal  Salary { get; set; }

        [DateInPast(ErrorMessage = "Hiring Date Must be in Past")]
        public DateOnly HiringDate { get; set; }

        //we need to Add New Properity after we finished our work
        public Location Location { get; set; }

      
        //Static List
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee() { Id = 1, Name = "Ahmed", Age = 22, Salary = 1000, HiringDate = new DateOnly(2021, 1, 1) },
            new Employee() { Id = 2, Name = "Mohamed", Age = 22, Salary = 2000, HiringDate = new DateOnly(2021, 2, 1) },
            new Employee() { Id = 3, Name = "Ibrahem", Age = 20, Salary = 1800, HiringDate = new DateOnly(2021, 3, 1) },
            new Employee() { Id = 4, Name = "Samy", Age = 21, Salary = 3500, HiringDate = new DateOnly(2021, 4, 1) },
            new Employee() { Id = 5, Name = "Noura", Age = 20, Salary = 2600, HiringDate = new DateOnly(2021, 5, 1) }
        };


    }
}
