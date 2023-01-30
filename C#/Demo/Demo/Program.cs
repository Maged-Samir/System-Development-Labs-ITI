namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Subject s1 = new Subject(1, "C#", 3, 100);
            //Console.WriteLine(s1.ToString());

            //Array Of Subject 
            /*
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
            */

            //foreach (Subject item in arrOfSubjects)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Track t1 = new Track(1,".Net", arrOfSubjects);

            //t1[101] = "OOP";

            //Console.WriteLine(t1.ToString());

            //Console.WriteLine(t1[101]);


            //Student s = new UnderGratuatedStudent(1, "Ahmed Samy", State.UnderGratuated);
            //Console.WriteLine(s.ToString());


            List<Student> ListStud1 = new List<Student>()
            {
                new UnderGratuatedStudent(1,"Maged Samir",State.UnderGratuated),
                new UnderGratuatedStudent(2,"Ahmed Samy",State.UnderGratuated),
                new UnderGratuatedStudent(3,"Mohamed Mahmoud",State.UnderGratuated),
            };

            List<Subject> ListSubject1 = new List<Subject>()
            {
                new Subject(1,"C#",2,200,ListStud1.ToArray()),
                new Subject(1,"SQL",2,200,ListStud1.ToArray()),
            };


            Track t1 = new Track(1, ".NET Development", ListSubject1.ToArray());
            //Console.WriteLine(t1.ToString());

            Dictionary<Track,List<Subject>>TrackSubjects= new Dictionary<Track,List<Subject>>();
            TrackSubjects.Add(t1, ListSubject1);

            foreach (KeyValuePair<Track, List<Subject>> kvp in TrackSubjects)
                Console.WriteLine("Key: {0}", kvp.Key);

        }
    }
}