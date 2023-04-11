using Microsoft.EntityFrameworkCore;
using ReservationSystem.DAL.Data.Context;
using ReservationSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.DAL.Repos.Tickets
{
   

    public class TicketsRepo : ITicketsRepo
    {
        private readonly ReservationContext _context;

        public TicketsRepo(ReservationContext context)
        {
            _context = context;
        }


        public Ticket? GetWithDevelopersById(int id)
        {
            return _context.Set<Ticket>()
                    .Include(d => d.Developers)
                    .FirstOrDefault(d => d.Id == id);
        }


        public int SaveChanges()
        {
            return _context.SaveChanges();
        }


        public IEnumerable<Ticket> GetAll()
        {
            return _context.Set<Ticket>();
        }

        public Ticket GetByTicketId(int Id)
        {
            var ticket = _context.Tickets.FirstOrDefault(t => t.Id == Id);
            return ticket;
        }

        public void CreateTicket(Ticket ticket)
        {
            //ticket.Id = new Random().Next(10, 1000);
           
            var mainEntity = new Ticket
            {
                Id = new Random().Next(10, 1000),
                Title = ticket.Title,
                Description=ticket.Description,
                Department = new Department
                {
                    Id = ticket.Department.Id,
                    Name = ticket.Department.Name,
                }
            };

            _context.Tickets.Add(mainEntity);
            _context.SaveChanges();

        }

        public void DeleteTicket(int Id) 
        {
            var DeletedTicket = _context.Tickets.FirstOrDefault(c => c.Id == Id);
            _context.Tickets.Remove(DeletedTicket);
            _context.SaveChanges();
        }

    }
}
