using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_09
{
    public class BoardMember : Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> FiredEmployee;
        protected virtual void OnFiredEmployee(EmployeeLayOffEventArgs e)
        {
            FiredEmployee?.Invoke(this, e);
        }
        public int WorkHoure { get; set; }

        public BoardMember(int EmployeeID, string Name, int age, int WorkHoure) : base(EmployeeID, Name, age)
        {
            this.WorkHoure = WorkHoure;
        }
        public void CheckTarget(object sender, EmployeeLayOffEventArgs e)
        {
            if ((sender is BoardMember emp) && (emp != null))
            {
                if ((emp.WorkHoure < 100) && (emp.Age < 60))
                    Console.WriteLine($" {emp.Name} Fired ...");
            }
        }

        public void CheckTarget(Employee e)
        {
            OnFiredEmployee(new EmployeeLayOffEventArgs());
        }
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs());
        }

        public void AddMember(object sender, EmployeeLayOffEventArgs e)
        {
            Console.WriteLine($" {Name} take a membership in Club ");
        }
    }
}
