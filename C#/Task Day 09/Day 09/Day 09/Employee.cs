using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_09
{
    public class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }

        public int EmployeeID { get; set; }

        public string Name { get; set; }

        int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (age < 60)
                    age = value;
            }
        }

        int vacationStock;
        public int VacationStock
        {
            get { return vacationStock; }
            set { vacationStock = value; }
        }
        public Employee(int EmployeeID, string Name, int age)
        {
            this.EmployeeID = EmployeeID;
            this.Name = Name;
            this.age = age;
        }

        public Employee(int EmployeeID, string Name, int age, int vacationstock)
        {
            this.EmployeeID = EmployeeID;
            this.Name = Name;
            this.age = age;
            this.vacationStock = vacationstock;
        }

        public override string ToString()
        {
            return $"{EmployeeID}-{Name} ";
        }

        public void CkeakState(Employee e)
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs());
        }
    }

    public enum LayOffCause
    {
        age = 0, vacationStock = 2
    }
    public class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}