using ReservationSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.DAL.Repos.Developers
{
    public interface IDevelopersRepo
    {
        IEnumerable<Developer> GetByDevelopersIds(int[] ids);
    }
}
