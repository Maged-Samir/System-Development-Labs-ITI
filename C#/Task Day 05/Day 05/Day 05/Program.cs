using System.Drawing;

namespace Day_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Point");

            Point3D p = new Point3D(10, 10, 10);
            Console.WriteLine(p.ToString());

            //string txt;
            //txt = p.ToString();
            //Console.WriteLine(txt);

            Point3D[] points = new Point3D[2];

            int i;
            int a = 0;
            for (i = 0; i < points.Length; i++)
            {
                points[i] = new Point3D();
                do
                {
                    Console.WriteLine("Enter X of point {0}", i + 1);
                } while (!int.TryParse(Console.ReadLine(), out a));
                points[i].x = a;

                do
                {
                    Console.WriteLine("Enter Y of point {0}", i + 1);
                } while (!int.TryParse(Console.ReadLine(), out a));
                points[i].y = a;

                do
                {
                    Console.WriteLine("Enter Z of point {0}", i + 1);
                } while (!int.TryParse(Console.ReadLine(), out a));
                points[i].z = a;
            }

            foreach (Point3D item in points)
            {
                Console.WriteLine(item.ToString());
            }

            


            Console.WriteLine("========================================");
            Console.WriteLine("Cheak Equals");

            Point3D p1 = new Point3D(10, 10, 10);
            Point3D p2 = new Point3D(10, 2, 10);

            if (p1.Equals(p2))
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }



           
        }
    }
}