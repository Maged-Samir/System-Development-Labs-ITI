namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Subject s1 = new Subject(1, "C#", 3, 100);
            //Console.WriteLine(s1.ToString());

            //Array Of Subject 
            Console.WriteLine("Plz Enter Number Of Subjects");
            int NumberOfSubjects=int.Parse(Console.ReadLine());

            Console.WriteLine("==================================");

            Subject[] arrOfSubjects=new Subject[NumberOfSubjects];
            for (int i = 0; i < arrOfSubjects.Length; i++)
            {
                arrOfSubjects[i] = new Subject();

                Console.WriteLine($"Enter Id Of Subject Number {i+1}");
                arrOfSubjects[i].Id=int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter Name Of Subject Number {i + 1}");
                arrOfSubjects[i].Name = Console.ReadLine();

                Console.WriteLine($"Enter Duration Of Subject Number {i + 1}");
                arrOfSubjects[i].Duration = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter Grade Of Subject Number {i + 1}");
                arrOfSubjects[i].Grade = int.Parse(Console.ReadLine());

                Console.WriteLine("==================================");

            }


            //foreach (Subject item in arrOfSubjects)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            Track t1 = new Track(1,".Net", arrOfSubjects);
            Console.WriteLine(t1.ToString());

        }
    }
}