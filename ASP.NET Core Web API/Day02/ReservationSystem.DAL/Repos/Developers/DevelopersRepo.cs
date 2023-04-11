using ReservationSystem.DAL.Data.Context;
using ReservationSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.DAL.Repos.Developers
{
    public class DevelopersRepo:IDevelopersRepo
    {
        private readonly ReservationContext _context;

        public DevelopersRepo(ReservationContext context)
        {
            _context = context;
        }

        public IEnumerable<Developer> GetByDevelopersIds(int[] ids)
        {
            /*
             * select * from Patients
             * where Id in (select id from ids)
             */
            return _context.Set<Developer>()
                .Where(p => ids.Contains(p.Id));
        }
    }
}
