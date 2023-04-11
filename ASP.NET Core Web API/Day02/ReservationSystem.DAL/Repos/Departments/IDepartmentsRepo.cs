using ReservationSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.DAL.Repos.Departments
{
    public interface IDepartmentsRepo
    {
        IEnumerable<Department> GetAll();
        Department? GetWithDepartmentsWithTicketsById(int id);
    }
}
