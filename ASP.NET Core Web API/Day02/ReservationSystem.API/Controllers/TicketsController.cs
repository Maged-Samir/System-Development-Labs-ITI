using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationSystem.BL.Dtos.Tickets;
using ReservationSystem.BL.Managers.Tickets;
using ReservationSystem.DAL.Data.Models;

namespace ReservationSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketsManager _TicketsManager;

        public TicketsController(ITicketsManager TicketsManager)
        {
            _TicketsManager = TicketsManager;
        }


        [HttpGet]
        public ActionResult<List<TicketsReadDto>> GetAll()
        {
            return _TicketsManager.GetAll().ToList();
        }


        [HttpGet]
        [Route("{Id}")]
        public ActionResult<Ticket> GetById(int Id)
        {
            return _TicketsManager.GetByTicketId(Id);
        }

        [HttpPost]
        public ActionResult Add(Ticket ticket)
        {
            _TicketsManager.CreateTicket(ticket);
            //return NoContent();
            return CreatedAtAction(
               actionName: nameof(GetById),
               routeValues: new { id = ticket.Id },
               value: new { Message = "your Ticket has been Added Successfully !" });
        }

        [HttpDelete]
        [Route("{Id}")]
        public ActionResult DeleteById(int Id)
        {
            _TicketsManager.DeleteTicket(Id);
            return NoContent();
        }




        


    }
}
