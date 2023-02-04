namespace Day_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Maged", 61, -1);
            Employee e2 = new Employee(2, "Ahmed", 65, 20);
            Employee e3 = new Employee(3, "Mohamed", 30, 2);

            SalesPerson e4 = new SalesPerson(4, "Mansour", 30,20);

            BoardMember e5 = new BoardMember(5, "Ashraf", 30,150);

            Employee[] e = new Employee[] { e1, e2, e3, e4, e5 };

            Department d1 = new Department(1, "Sales", e);
            Department d2 = new Department(1, "Markting", e);

            Club c1 = new Club(101, "Zamalek", e);

          
            //Test Object Of Employee with Remove Staff & Member Events

            e1.EmployeeLayOff += d1.RemoveStaff;
            e1.EmployeeLayOff += c1.RemoveMember;
            //e1.EmployeeLayOff += RemoveStaffList.AddToRemovedStuffList;

            e2.EmployeeLayOff += d2.RemoveStaff;
            e2.EmployeeLayOff += c1.RemoveMember;
            //e2.EmployeeLayOff += RemoveStaffList.AddToRemovedStuffList;

            e3.EmployeeLayOff += d1.RemoveStaff;
            //e3.EmployeeLayOff += RemoveStaffList.AddToRemovedStuffList;

            //Test Obj Of Sales Person with Cheak target event

            e4.FiredEmployee += e4.CheckTarget;
            //e4.EmployeeLayOff += RemoveStaffList.AddToRemovedStuffList;



            e5.FiredEmployee += e5.CheckTarget;
            c1.CreateMemberShip += e5.AddMember;


            e1.CkeakState(e1);
            e2.CkeakState(e2);
            e3.CkeakState(e3);
            e4.CheckTarget(e4);
            e5.CheckTarget(e5);
            c1.AddMember(e5);
           



            Console.WriteLine("==============================");
            //Console.WriteLine($"Names Of Our Removed Employees:- {RemoveStaffList.RemovedListNames}");






        }
    }
}