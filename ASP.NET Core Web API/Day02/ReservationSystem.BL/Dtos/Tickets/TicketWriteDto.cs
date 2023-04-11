using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.BL.Dtos.Tickets
{
   
    public record TicketWriteDto(int Id, string Title,string Description,int DepartmentId);

}
