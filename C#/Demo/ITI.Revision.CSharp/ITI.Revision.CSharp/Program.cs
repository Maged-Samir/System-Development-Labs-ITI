using System.Diagnostics;

namespace ITI.Revision.CSharp
{

    //Default Access Modifiers For Struct And Class Internal ==> internal (default) & public

    internal struct Student //:Boy
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // we Can't Inherite Struct
    //struct Boy:Student
    //{
    //}
    
    //struct Boy { }
   
    struct Point
    {
        //int x;
        //int y;

        public int x { get; set; }
        public int y { get; set; }
        public Point (int x, int y)
        {
            //in .Net Ctor of struct must be fully assigned before C# 11
            this.x = x;
            this.y = y;
        }

        public Point (int x)
        {
            this.x = x;
        }
        public Point()
        {
            // also before C# 11 it was impossible to create parameterless constractour
            x = 0;
            y = 0;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }

    }

    enum Gender
    {
        male ,
        female
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public Person(int Id,string Name, Gender Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.Gender = Gender;
        }

        public override string ToString()
        {
            return $"{Id}-{Name}  - {Gender}";
        }
    }

    public static class Helper
    {
        public static void PrintLine()
        {
            for(int i=0;i<5;i++)
            {
                Console.Write("#");
            }
        }

        //Named parameter , Default Parameter For Functions 
        public static void PrintLine(int count=5,string pattern="*")
        {
            for(int i=0;i<count;i++)
            {
                Console.Write(pattern);
            }
        }

        //Passing value type By Value -->Not Change
        //Passing value type By Ref -->  Do Change
        public static void Swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y=temp;
        }
        //Passing Reference Type By Value --> Change
        //Passing Reference Type By Ref --> Change
        public static int SumArray(ref int[] arr)
        {
            int sum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                sum += arr[i];
            }
            return sum;
        }


    }


    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Employee()
        {

        }
        //Copy Ctor
        public Employee(Employee old)
        {
            Id = old.Id;
            Name = old.Name;
        }

        public override string ToString()
        {
            return $"{Id}- {Name}";
        }

        public override bool Equals(object? obj)
        {
            if(obj is Employee)
            {
                Employee e= (Employee)obj;
                return e.Id == Id ;
            }
            return false;
        }
    }

    //Static Keywords
    internal  class Test
    {
        public int x { get; set; }
        public static int y { get; set; }

        public static void getNames()
        {
            Console.WriteLine($"{y}");
        }

    }

    //public interface IType
    //{
    //    public void SetTypeName();
    //    public string PrintTypeName();
    //}
    interface IWorker
    {
        void Run();

    }

    class Worker:IWorker
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public void Run()
        { 
            Console.WriteLine( $"{Id}-{Name} is working!");
        }
    }



    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region DataTypes

            //CTS common Type System
            //Value Types & Referance Types 

            //DataType
            // Storage
            // Validation
            // Operation 


            //Console.WriteLine("Hello, World!");
            //Console.ReadLine();

            //int x = 5;
            //string text = "text";

            //object o = new object();
            //o = 2;
            //o = "ss";

            //// System.Object -> Base Type Of All DataTypes
            //object[] objects = new object[3];
            //objects[0] = 1;
            //objects[1] = "Ahmed";
            //objects[2] = new int[] { 1, 2 };

            //object o1=new();
            //object o2=new();

            //Console.WriteLine(o1.GetHashCode());
            //Console.WriteLine(o2.GetHashCode());

            //Console.WriteLine("/////////");
            //o1 = o2;
            //Console.WriteLine(o1.GetHashCode());
            //Console.WriteLine(o2.GetHashCode());


            #endregion

            #region Control Statment
            //string shape = "Circle";

            //if(shape=="Square")
            //{
            //    Console.WriteLine("this is a Square");
            //}
            //else if (shape=="Rectangle")
            //{
            //    Console.WriteLine("this is a Rectangle");
            //}
            //else if (shape=="Circle")
            //{
            //    Console.WriteLine("this is a Circle");
            //}
            //else
            //{
            //    Console.WriteLine("Please check your shap name");
            //}


            //string ShapeName = "Circle";
            //switch (ShapeName)
            //{
            //    case "Rect":
            //        {
            //            Console.WriteLine("sssss");
            //            break;
            //        }
            //    case "Circle":
            //        {
            //            Console.WriteLine("sssssssss");
            //            break;
            //        }
            //    default:
            //        break;
            //}

            #endregion

            #region Struct&Enum
            //Point p = new Point(1, 5);
            //Point p1 = new Point(2);
            //Point P2 = new Point();

            //Console.WriteLine(p.ToString());
            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(P2.ToString());

            //Gender g= Gender.male;
            //Console.WriteLine(g.ToString());


            //Person p = new Person(1, "Ahmed", Gender.male);
            //Console.WriteLine(p.ToString()); 
            #endregion


            #region NamedParameter&DefaultParameter
            //Console.WriteLine("Enter Your Value");
            //int x = int.Parse(Console.ReadLine());
            //x++;
            //Helper.PrintLine();
            //Console.WriteLine($"\n Your New Value is {x}");

            //Named Parameter & Default Parameters for Functions in C# 
            //Helper.PrintLine(10, "_-_");
            //Console.WriteLine();

            //Helper.PrintLine();
            //Console.WriteLine();

            //Helper.PrintLine(pattern: "&&", count: 10);
            //Console.WriteLine();


            //StackTrace stack = new StackTrace();
            //foreach (StackFrame item in stack.GetFrames())
            //{
            //    Console.WriteLine(item.GetMethod().Name);
            //} 
            #endregion

            #region Exceptions

            // try
            // {
            //     Console.WriteLine("Enter First Number ");
            //     int Number1 = int.Parse(Console.ReadLine());

            //     Console.WriteLine("Enter Secoond Number ");
            //     int Number2 = int.Parse(Console.ReadLine());

            //     int Result = Number1 / Number2;
            //     Console.WriteLine($" {Number1} / {Number2} = {Result}");

            // }
            // catch(DivideByZeroException e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            // catch(FormatException e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            // catch (Exception e) 
            // {
            //     Console.WriteLine($"{e.Message}");
            // }
            //finally  // will executed in any cases after our code 
            // {
            //     Console.WriteLine("Thank You for using Our Application !");
            // }

            #endregion

            #region PassByValue&Ref
            //int A = 2;
            //int B = 3;
            ////Helper.Swap(A,B);         //Passing By Value
            //Helper.Swap(ref A,ref B);   //Passing By Referance
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //int[] Arr = { 1, 2, 3, 4 };
            //Console.WriteLine(Helper.SumArray(ref Arr)); 
            #endregion

            #region CopyCtor
            //Employee e = new Employee() { Id = 1, Name = "Ahmed" };

            //Employee employee = new Employee(e);

            //Console.WriteLine(e.ToString());
            //Console.WriteLine(employee.ToString()); 
            #endregion

            #region Equality
            //Employee e1 = new Employee() { Id = 1, Name = "Ali" };
            //Employee e2 = new Employee() { Id = 1, Name = "Ali" };

            //if(e1.Equals(e2))
            //{ Console.WriteLine("equals true"); } 
            #endregion


            #region Inheritance
            //Parent p = new Parent(2);
            //p.show();

            //Parent p1 = new Child(3, 3);
            //p1.show();

            //Parent p2 = new SubChild(4, 5, 6);
            //p2.show(); 
            #endregion

            #region Dictionary
            //Dictionary<int, string> PhoneBook = new();
            //PhoneBook.Add(1, "Ahmed Mansour");
            //PhoneBook.Add(2, "Samy Ibrahem");
            //PhoneBook.Add(3, "Mohamed Ali");
            ////PhoneBook.Add(3, "Mohamed Ali");      //Key Is a Unique in Dictionary


            //foreach (KeyValuePair<int, string> item in PhoneBook)
            //{
            //    Console.WriteLine($"{item.Key}-{item.Value}");
            //} 
            #endregion


        }
    }
}