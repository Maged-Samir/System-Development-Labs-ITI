using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_09
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        Employee[] Staff;

        public Department(int deptID, string deptName, Employee[] staff)
        {
            DeptID = deptID;
            DeptName = deptName;
            Staff = staff;
        }

        public override string ToString()
        {
            string txt = $"{DeptID}-{DeptName}";
            for (int i = 0; i < Staff.Length; i++)
            {
                txt += Staff[i].ToString();
            }
            return txt;
        }
        ///CallBackMethod
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if ((sender is Employee emp) && (emp != null))
            {
                if ((emp.VacationStock < 0) || (emp.Age > 60))
                    Console.WriteLine($" {emp.Name} Removed from {DeptName} Department , because of his {e.Cause = LayOffCause.age}");
            }
        }

    }
}