using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationSystem.BL.Dtos.Departments;
using ReservationSystem.BL.Dtos.Tickets;
using ReservationSystem.BL.Managers.Departments;
using ReservationSystem.BL.Managers.Tickets;
using ReservationSystem.DAL.Data.Models;

namespace ReservationSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentsManager _DepartmentsManager;
        private readonly ITicketsManager _TicketsManager;

        public DepartmentsController(IDepartmentsManager DepartmentsManager, ITicketsManager ticketsManager)
        {
            _DepartmentsManager = DepartmentsManager;
            _TicketsManager = ticketsManager;
        }


        [HttpGet]
        [Route("{Id}")]
        public ActionResult<DepartmentDetailsReadDto> GetById(int Id)
        {
            //I need a method to take ID and return possible doctorReadDto
            DepartmentDetailsReadDto? department = _DepartmentsManager.GetDetailsById(Id);

            if (department is null)
            {
                return NotFound();
            }
            return department;
        }


        [HttpPost]
        public ActionResult AssignDevelopersToTicket(AssignDevelopersToTicketDto assignDevelopersToTicketDto)
        {
            _TicketsManager.AssignDevelopersToTicket(assignDevelopersToTicketDto);
            return NoContent();
        }
    }
}
