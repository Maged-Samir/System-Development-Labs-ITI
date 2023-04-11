using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.BL.Dtos.Tickets
{
    public record AssignDevelopersToTicketDto(int TicketId, int[] DevelopersIds);
}
