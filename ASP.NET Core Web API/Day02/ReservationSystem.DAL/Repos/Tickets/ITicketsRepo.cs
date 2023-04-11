
using ReservationSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.DAL.Repos.Tickets
{
    public interface ITicketsRepo
    {
        Ticket? GetWithDevelopersById(int id);
        IEnumerable<Ticket> GetAll();
        Ticket GetByTicketId(int Id);
        void CreateTicket(Ticket ticket);
        public void DeleteTicket(int Id);
        int SaveChanges();

    }
}
