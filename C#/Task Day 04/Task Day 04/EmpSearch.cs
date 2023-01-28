using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Day_04
{
    internal class EmpSearch
    {
        public Employee[] employees;

        public Employee this[int id]
        {
            set
            {
                if (id < employees.Length)
                    employees[id] = value;
            }

            get
            {
                for (int i = 0; i < employees.Length; i++)
                    if (employees[i].id == id)
                        return employees[i];

                throw new IndexOutOfRangeException();
            }
        }

        public Employee this[HireDate date]
        {
            get
            {
                for (int i = 0; i < employees.Length; i++)
                    if (employees[i].hdate.Equals(date))
                        return employees[i];

                throw new IndexOutOfRangeException();
            }
        }

        public EmpSearch(int size)
        {
            employees = new Employee[size];
        }
    }
    }

