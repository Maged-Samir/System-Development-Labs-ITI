using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_09
{
    public static class RemoveStaffList
    {
        static List<string> Rlist;
        public static int Size
        {
            get => Rlist?.Count ?? -1;
        }

        static RemoveStaffList() =>Rlist =new List<string>();

        public static void AddToRemovedStuffList(object sender,EmployeeLayOffEventArgs e)
        {
            if ((sender is Employee emp) && (emp != null)&&(!Rlist.Contains(emp.Name)))
            {
                Rlist.Add(emp.Name);
            }
        }

        public static string RemovedListNames
        {
            get
            {
                StringBuilder stringBuilder= new StringBuilder();
                for (int i = 0; i < Rlist.Count; i++)
                    stringBuilder.Append(Rlist[i]).Append(" , ");
                return stringBuilder.ToString();
                
            }
        }


    }
}
