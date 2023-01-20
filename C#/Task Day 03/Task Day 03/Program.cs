
using System.Reflection;

namespace Task_Day_03
{
    struct HireDate 
    {
        string day ;
        string month ;
        string year ;

        public string Get_day()
        {
            return day;
        }

        public void Set_day(string _day)
        {
            day= _day;
        }

        public string Get_month()
        {
            return month;
        }

        public void Set_month(string _month)
        {
           month= _month;
        }

        public string Get_year()
        {
            return year;
        }

        public void Set_year(string _year)
        {
            year = _year;
        }

        public HireDate(string _day, string _month, string _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }

        public override string ToString()
        {
            return $" {month}-{day}-{year}";
        }

       
    }


    enum Gender
    {
        male, female
    }

    [Flags]
    enum SecurityLevel
    {
        guest=2 , Developer=4 , secretary=8 , DBA=16
    }

    struct Employee
    {
         int id ;
         SecurityLevel sec ;
         int salary;
         HireDate hdate;
         Gender state;


        //Getter & Setter
        
        public int Get_id()
        {
            return id;
        }

        public void Set_id(int _Id)
        {
            id = _Id;
        }

        public SecurityLevel Get_sec()
        {
            return sec;
        }

        public void Set_sec(SecurityLevel _sec)
        {
            sec = _sec;
        }

        public int Get_salary() 
        {
            return salary;
        }

        public void Set_salary(int _salary)
        {
            salary = _salary;
        }

        public HireDate Get_hdate()
        {
            return  hdate;
        }
        public void Set_hDate(HireDate _hDate)
        {
            hdate = _hDate;
        }
        

        public Gender Get_gender() 
        {
            return state;
        }

        public void Set_gender(Gender _state)
        {
            state = _state;
        }
        
        //Ctor
        public Employee(HireDate hdate, int id = 0, SecurityLevel sec = SecurityLevel.guest, int salary = 1000,
            Gender state = Gender.male)

        {
            this.id = id;
            this.sec = sec;
            this.salary = salary;
            this.hdate = hdate;
            this.state = state;
        }

        public override string ToString()
        {
            return $"Employee ID :{Get_id()} \n" +
                   $"Security Level :{Get_sec()}\n" +
                   string.Format("Salary {0}$\n", Get_salary()) +
                   $"Hiring Date is :{Get_hdate()}\n" +
                   $"State :{Get_gender()}\n" +
                   $"----------------------------------------------";
        }

        public string printEmp()
        {
            return $"Employee ID :{Get_id()} \n" +
                   $"Security Level :{Get_sec()}\n" +
                   string.Format("Salary {0}$\n", Get_salary()) +
                   $"Hiring Date is :{Get_hdate()}\n" +
                   $"State :{Get_gender()}\n" +
                   $"----------------------------------------------";
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {


            //Employee[] emp = new Employee[2]
            //{
            //    new Employee(new HireDate("5","12","2020"),2,SecurityLevel.DBA,2000,Gender.male),
            //    new Employee(new HireDate("4","6","2018"),3,SecurityLevel.guest,8000,Gender.female)
            //};

            //foreach (Employee item in emp)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Enter Number Of Employyes");
            int NumberOfEmployee = int.Parse(Console.ReadLine());

            Employee[] NewEmp = new Employee[NumberOfEmployee];
            //Gender? gender;
            for (int i = 0; i < NewEmp.Length; i++)
            {

                Console.WriteLine("Enter Id of Employee {0}", i + 1);
                NewEmp[i].Set_id(int.Parse(Console.ReadLine()));

                Console.WriteLine("Enter Salary of Employee {0}", i + 1);
                NewEmp[i].Set_salary(int.Parse(Console.ReadLine()));

                Console.WriteLine("Enter Gender of Employee {0}", i + 1);
                //string gender = (string)Enum.Parse(typeof(Gender), Console.ReadLine());
                NewEmp[i].Set_gender((Gender)Enum.Parse(typeof(Gender), Console.ReadLine()));

                Console.WriteLine("Enter SecurityLevel of Employee {0}", i + 1);
                NewEmp[i].Set_sec((SecurityLevel)Enum.Parse(typeof(SecurityLevel), Console.ReadLine()));

                Console.WriteLine("Enter HireDate of Employee {0}", i + 1);

                //int a = 3;
                //int b = 3;
                //int c = 3;
                //NewEmp[i].Set_hDate(new HireDate(a, b, c));
                //HireDate userDateTime=new HireDate();

                String sDate = DateTime.Parse(Console.ReadLine()).ToString();
                DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

                String dy = datevalue.Day.ToString();
                String mn = datevalue.Month.ToString();
                String yy = datevalue.Year.ToString();
                NewEmp[i].Set_hDate(new HireDate(dy, mn, yy));



            }

            foreach (Employee item in NewEmp)
            {
                Console.WriteLine(item.ToString());
                //Console.WriteLine(item.printEmp());
            }


        }
    }
}