using ReservationSystem.BL.Dtos.Departments;
using ReservationSystem.BL.Dtos.Tickets;
using ReservationSystem.DAL.Data.Models;
using ReservationSystem.DAL.Repos.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.BL.Managers.Departments
{
    public class DepartmentsManager : IDepartmentsManager
    {

        private readonly IDepartmentsRepo _departmentsRepo;
       

        public DepartmentsManager(IDepartmentsRepo departmentsRepo)
        {
            _departmentsRepo = departmentsRepo;
           
        }


        public IEnumerable<DepartmentReadDto> GetAll()
        {
            var doctorsFromDb = _departmentsRepo.GetAll();

            return doctorsFromDb.Select(d => new DepartmentReadDto(Id: d.Id,
                    Name: d.Name));
        }

        public DepartmentDetailsReadDto? GetDetailsById(int id)
        {
           
            Department? doctorFromDb = _departmentsRepo.GetWithDepartmentsWithTicketsById(id);

            if (doctorFromDb is null)
            {
                return null;
            }

            return new DepartmentDetailsReadDto
            {
                Id = doctorFromDb.Id,
                Name = doctorFromDb.Name,
                Tickets = doctorFromDb.Tickets
                    .Select(p => new TicketChildDto
                    {
                        Id = p.Id,
                        Title = p.Title,
                        Description = p.Description,
                        DevelopersCount = p.Developers.Count
                    })
            };
        }
    }
}
