using ReservationSystem.BL.Dtos.Tickets;
using ReservationSystem.DAL.Data.Models;
using ReservationSystem.DAL.Repos.Developers;
using ReservationSystem.DAL.Repos.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.BL.Managers.Tickets
{
    public class TicketsManager: ITicketsManager
    {
        private readonly ITicketsRepo _ticketsRepo;
        private readonly IDevelopersRepo _developersRepo;


        public TicketsManager(ITicketsRepo ticketsRepo, IDevelopersRepo developersRepo)
        {
            _ticketsRepo = ticketsRepo;
            _developersRepo=developersRepo;
        }

        public void AssignDevelopersToTicket(AssignDevelopersToTicketDto assignDevelopersDto)
        {
            //Get Ticket with related developers from Repo 
            Ticket? ticket = _ticketsRepo.GetWithDevelopersById(assignDevelopersDto.TicketId);
            if (ticket is null)
            {
                return;
            }
            //Clear Old Related Developers
            ticket.Developers.Clear();
            //Get New Developers 
            ICollection<Developer> newDevelopers = _developersRepo
                .GetByDevelopersIds(assignDevelopersDto.DevelopersIds)
                .ToList();
            //Assign New Developers to Ticket
            ticket.Developers = newDevelopers;
            //SaveChanges
            _ticketsRepo.SaveChanges();
        }


        IEnumerable<TicketsReadDto> ITicketsManager.GetAll()
        {
            var ticketsFromDb = _ticketsRepo.GetAll();

            return ticketsFromDb.Select(d => new TicketsReadDto(Id: d.Id,
                    Title: d.Title,
                    Description: d.Description));
        }

        public Ticket GetByTicketId(int Id)
        {
            var ticketFromDb = _ticketsRepo.GetByTicketId(Id);
           
            return ticketFromDb;

            

        }

        public void CreateTicket(Ticket ticket)
        {
            _ticketsRepo.CreateTicket(ticket);
        }

        public void DeleteTicket(int Id)
        {
            _ticketsRepo.DeleteTicket(Id);
        }

        
    }
}
