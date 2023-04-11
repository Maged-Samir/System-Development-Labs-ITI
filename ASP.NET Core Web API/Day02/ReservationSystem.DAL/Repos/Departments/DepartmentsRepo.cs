using Microsoft.EntityFrameworkCore;
using ReservationSystem.DAL.Data.Context;
using ReservationSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.DAL.Repos.Departments
{
    public class DepartmentsRepo:IDepartmentsRepo
    {
        private readonly ReservationContext _context;

        public DepartmentsRepo(ReservationContext context)
        {
            _context = context;
        }
        public IEnumerable<Department> GetAll()
        {
            return _context.Set<Department>();
        }

        public Department GetWithDepartmentsWithTicketsById(int id)
        {
            return _context.Set<Department>()
                .Include(d => d.Tickets)
                .ThenInclude(p=>p.Developers)
                .FirstOrDefault(d => d.Id == id);
        }
    }
}
