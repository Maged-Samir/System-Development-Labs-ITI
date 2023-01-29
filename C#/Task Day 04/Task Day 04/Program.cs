
using System;
using System.Reflection;

namespace Task_Day_04
{
    struct HireDate
    {
        public string day { get; set; }
        public string month { get; set; }
        public string year { get; set; }

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
        guest = 2, Developer = 4, secretary = 8, DBA = 16
    }

    struct Employee
    {
        public int id { get; set; }

        public int salary { get; set; }

        public SecurityLevel sec { get; set; }

        public HireDate hdate { get; set; }

        public Gender state { get; set; }


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
            return $"Employee ID :{id} \n" +
                   $"Security Level :{sec}\n" +
                   string.Format("Salary {0}$\n", salary) +
                   $"Hiring Date is :{hdate}\n" +
                   $"State :{state}\n" +
                   $"----------------------------------------------";
        }

        public string printEmp()
        {
            return $"Employee ID :{id} \n" +
                   $"Security Level :{sec}\n" +
                   string.Format("Salary {0}$\n", salary) +
                   $"Hiring Date is :{hdate}\n" +
                   $"State :{state}\n" +
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

            //EmpSearch employees = new EmpSearch(2);


            //for (int i = 0; i < 2; i++)
            //{
            //    employees[i] = emp[i];

            //}



            //Console.WriteLine(employees[3]);
            ////Console.WriteLine(employees[new HireDate("5", "12", "2020")]);









            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Enter Number Of Employyes");
            int NumberOfEmployee = int.Parse(Console.ReadLine());

            Employee[] NewEmp = new Employee[NumberOfEmployee];
            //Gender? gender;
            int i;
            for (i = 0; i < NewEmp.Length; i++)
            {
                int x = 0;
                string CheackGender;
                string CheackSecLevel;

                do
                {
                    Console.WriteLine("Enter Id of Employee {0}", i + 1);
                } while (!int.TryParse(Console.ReadLine(), out x));
                NewEmp[i].id = x;


                do
                {
                    Console.WriteLine("Enter Salary of Employee {0}", i + 1);
                } while (!int.TryParse(Console.ReadLine(), out x));
                NewEmp[i].salary = x;



                do
                {
                    Console.WriteLine("Enter Gender of Employee {0}", i + 1);
                    CheackGender = Console.ReadLine();
                } while (CheackGender != "male" && CheackGender != "female");
                NewEmp[i].state = (Gender)Enum.Parse(typeof(Gender), CheackGender);



                do
                {
                    Console.WriteLine("Enter SecurityLevel of Employee {0}", i + 1);
                    CheackSecLevel = Console.ReadLine();
                } while (CheackSecLevel != "guest" && CheackSecLevel != "DBA");
                NewEmp[i].sec = (SecurityLevel)Enum.Parse(typeof(SecurityLevel), CheackSecLevel);


              


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
                NewEmp[i].hdate = new HireDate(dy, mn, yy);


            }

            foreach (Employee item in NewEmp)
            {
                Console.WriteLine(item.ToString());
                //Console.WriteLine(item.printEmp());
            }


        }
    }
}