using ReservationSystem.BL.Dtos.Tickets;
using ReservationSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.BL.Managers.Tickets
{
    public interface ITicketsManager
    {
        void AssignDevelopersToTicket(AssignDevelopersToTicketDto assignDevelopersDto);
        IEnumerable<TicketsReadDto> GetAll();
        Ticket GetByTicketId(int Id);
        void CreateTicket(Ticket ticket);
        void DeleteTicket(int Id);
    }
}
