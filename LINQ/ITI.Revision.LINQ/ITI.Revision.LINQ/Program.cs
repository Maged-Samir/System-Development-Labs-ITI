using System.Security.Cryptography;
using System.Threading.Channels;

namespace ITI.Revision.LINQ
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly Typed Local Variable
            //int x = 5;
            //x = "ahmed";

            //double y = 10.5;
            //y = "ahmed";

            //var x = 5;
            //var y = null;

            #endregion

            #region Extention Method
            //Extension methods allow you to inject additional methods without modifying,
            //deriving or recompiling the original class

            //int i = 10;
            //bool result = i.IsGreaterThan(100);
            //Console.WriteLine(result);

            #endregion

            #region Anonymous Type
            //var emp1 = new { id = 2, name = "ahmed", age = 20 };
            //Console.WriteLine(emp1.GetHashCode());
            //Console.WriteLine(emp1.ToString());

            //var emp2 = new { id = 2, name = "ahmed", age = 20 };
            //Console.WriteLine(emp2.GetHashCode());


            #endregion

            #region Shapes Of Writing Linq Quries

            //List<int> list = new(){ 1,2,3,5,4,6,2};

            //1-Static method , static class
            //var Result=Enumerable.Where(list, i => i > 4);

            //2-Extention Method - Flunent Syntax
            //var Result = list.Where(x => x > 3);

            //3-Query Synatax
            //var Result = from i in list
            //             where i > 3
            //             select i;

            //foreach(var item in Result) 
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Linq 
            //var Result = Employee.empList.Where(x => x.Age>22);
            //var Result = Employee.empList.Where(x => x.Salary > 1500).Select(x => x.Name);
            //var Result = Employee.empList.Select(x => x.ToString());
            //var Result = Employee.empList.Select(x => new { x.Name, x.Age });
            //var Result = Employee.empList.Where(x => x.Age>20).OrderBy(x=>x.Salary);



            //foreach(var item  in Result) 
            //{
            //    Console.WriteLine(item);
            //}

            //Single /Last 
            //var Result = Employee.empList.First();
            //var Result = Employee.empList.Last();

            //var Result = Employee.empList.Where(x => x.Age > 50).FirstOrDefault();
            //var Result = Employee.empList.FirstOrDefault(e => e.Age > 20);

            //var Result = Employee.empList.Single();
            //var Result = Employee.empList.Single(x=>x.Age==22);

            //var Result = Employee.empList.Count();
            //var Result = Employee.empList.Max();  //need  IComparable
            //var Result = Employee.empList.Min();

            //Console.WriteLine(Result);

            //var Result = Employee.empList.Take(2);
            //var Result = Employee.empList.Skip(2);
            //var Result = Employee.empList.TakeLast(2);
            //var Result = Employee.empList.SkipLast(2);  

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


        }
    }
}