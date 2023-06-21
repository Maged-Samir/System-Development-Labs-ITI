using ITI.Revision.EntityFramework.Context;
using ITI.Revision.EntityFramework.Entites;

namespace ITI.Revision.EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {

                var t1 = new Teacher()
                {
                    Name = "Mohamed Hamed",
                };
                context.teachers.Add(t1);
                context.SaveChanges();


                //var c1 = new Course()
                //{
                //    Name = "C#",
                //    Description = " Programming Language",
                //    Duration = 2,
                //    teacherId= 1,
                //};

                //context.courses.Add(c1);
                //context.SaveChanges();


                var Result = context.teachers.ToList();
                foreach (var item in Result)
                {
                    Console.WriteLine(item.ToString());
                }

                var Counter = context.teachers.Count();
                Console.WriteLine($"Number Of teachers {Counter}");


            }
        }
    }
}