using ReservationSystem.BL.Dtos.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.BL.Managers.Departments
{
    public interface IDepartmentsManager
    {
        IEnumerable<DepartmentReadDto> GetAll();
        DepartmentDetailsReadDto? GetDetailsById(int id);
    }
}
