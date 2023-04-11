using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.DAL.Data.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; } =string.Empty;
        public string Description { get; set; } = string.Empty;

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<Developer>? Developers { get; set; } = new HashSet<Developer>();

    }
}
