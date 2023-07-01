using ITI.Revision.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITI.Revision.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            List<Employee> employees = Employee.employees.ToList();
            if(!employees.Any())
            {
                return NotFound();
            }
            return Ok(employees);
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult GetById(int id) 
        {
            Employee employee = Employee.employees.FirstOrDefault(e => e.Id == id);
            if(employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        [Route("v1")]
        public ActionResult AddNewEmployee(Employee employee)
        {
            if(employee == null) 
            {
                return BadRequest("Please Check your Entered Data");
            }
            employee.Location = Location.EG; 
            Employee.employees.Add(employee);
            return Ok("Your Data Added Successfully !");
        }

        [HttpPost]
        [Route("v2")]
        public ActionResult AddNewEmployeeV2(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Please Check your Entered Data");
            }
            Employee.employees.Add(employee);
            return Ok("Your Data Added Successfully !");
        }



        [Route("{id}")]
        [HttpPut]
        public ActionResult UpdateEmployee(int id,Employee employee)
        {
            if(id !=employee.Id)
            {
                return BadRequest();
            }
            Employee UpdatedEmployee = Employee.employees.FirstOrDefault(e => e.Id == id);

            if (UpdatedEmployee is null)
            {
                return NotFound();
            }
            UpdatedEmployee.Name=employee.Name;
            UpdatedEmployee.Age=employee.Age;
            UpdatedEmployee.Salary=employee.Salary;
            UpdatedEmployee.HiringDate = employee.HiringDate;

            return Ok("Your Employee has been Updated !");
        }


        [Route("{id}")]
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            
            Employee Employee = Employee.employees.FirstOrDefault(e => e.Id == id);
            if (Employee == null)
            {
                return NotFound();
            }
            Employee.employees.Remove(Employee);
            return Ok("Your Employee has been Deleted !");
        }
    }

}
