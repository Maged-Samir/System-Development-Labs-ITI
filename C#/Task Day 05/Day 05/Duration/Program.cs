namespace Duration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Duration d=new Duration();
            //Duration d1 = new Duration(1,50,3);
            //Console.WriteLine(d1.ToString());


            Duration d = new Duration(3600);
            Console.WriteLine(d.ToString());

            Duration d1 = new Duration(7800);
            Console.WriteLine(d1.ToString());

            Duration d2 = new Duration(666);
            Console.WriteLine(d2.ToString());




            Console.WriteLine("Cheak Operator Overloading");
            Duration d100 = new Duration(1, 20, 3);
            Duration d200 = new Duration(1, 10, 2);
            Duration d300 = d100 + d200;
            Console.WriteLine(d300.Print());


            if(d100 >= d200)
            {
                Console.WriteLine("d100 >= d200");
            }


            Duration d400 = d100 + 5;
            Console.WriteLine(d400.ToString());


            Duration d500=new Duration(1, 20, 0);
            ++d500;
            Console.WriteLine(d500.Print());


            //Duration d500 = new Duration(1, 20, 0);
            --d500;
            Console.WriteLine(d500.Print());



            DateTime date = DateTime.Now;
            date = d500;
            Console.WriteLine(date.ToString());


            Duration d700 = new Duration(1, 10, 0);
            if(d700)
            {
                Console.WriteLine("Duration have values ");
            }
            else
            {
                Console.WriteLine("Duration:Zero");
            }


        }
    }
}