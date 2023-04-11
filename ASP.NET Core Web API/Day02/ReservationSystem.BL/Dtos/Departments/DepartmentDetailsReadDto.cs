using ReservationSystem.BL.Dtos.Tickets;
using ReservationSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.BL.Dtos.Departments
{
    public record DepartmentDetailsReadDto
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public IEnumerable<TicketChildDto> Tickets { get; init; }
            = new List<TicketChildDto>();

    }
}
