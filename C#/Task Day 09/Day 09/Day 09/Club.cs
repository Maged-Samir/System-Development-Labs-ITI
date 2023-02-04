using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_09
{
    class Club
    {
        public event EventHandler<EmployeeLayOffEventArgs> CreateMemberShip;
        protected virtual void OnCreateMemberShip(EmployeeLayOffEventArgs e)
        {
            CreateMemberShip?.Invoke(this, e);
        }
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        Employee[] Members;
        public Club(int clubID, string clubName, Employee[] members)
        {
            ClubID = clubID;
            ClubName = clubName;
            Members = members;
        }
        public Club()
        {

        }
        public void AddMember(Employee E)
        {
            OnCreateMemberShip(new EmployeeLayOffEventArgs());
        }

        ///CallBackMethod
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            if ((sender is Employee emp) && (emp != null))
            {
                if ((emp.VacationStock < 0))
                    Console.WriteLine($" {emp.Name} Removed from {ClubName} Club , Because of his {e.Cause=LayOffCause.vacationStock}");
            }
        }
    }
}
