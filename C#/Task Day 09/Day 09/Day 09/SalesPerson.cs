using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_09
{
    class SalesPerson : Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> FiredEmployee;
        protected virtual void OnFiredEmployee(EmployeeLayOffEventArgs e)
        {
            FiredEmployee?.Invoke(this, e);
        }
        public int AchievedTarget { get; set; }
        public SalesPerson(int EmployeeID, string Name, int age, int AchievedTarget) : base(EmployeeID, Name, age)
        {
            this.AchievedTarget = AchievedTarget;
        }
        public void CheckTarget(object sender, EmployeeLayOffEventArgs e)
        {
            if ((sender is SalesPerson emp) && (emp != null))
            {
                if (emp.AchievedTarget < 100)
                Console.WriteLine($"{emp.Name} Fired ....");
            }
        }
        public void CheckTarget(Employee e)
        {
            OnFiredEmployee(new EmployeeLayOffEventArgs());
        }
    }
}
