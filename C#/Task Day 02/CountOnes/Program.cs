using System.Diagnostics;

namespace CountOnes
{
    internal class Program
    {
        static int countDigitOne(int n)
        {
            int countr = 0;
            for (int i = 1; i <= n; i++)
            {
                string str = i.ToString();
                countr += str.Split('1').Length - 1;
            }
            return countr;
        }

        static void Main(string[] args)
        {

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //int n = 99999999;
            //Console.WriteLine(countDigitOne(n));

            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed.ToString());





            //System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            //sw.Start();
            //int counter = 0;
            //sw.Reset();
            //sw.Start();

            //counter = (int)(8 * Math.Pow(10, 8 - 1));
            //sw.Stop();
            //Console.WriteLine("1 is counted {0} times and prog time is {1}", counter, sw.Elapsed.ToString());
            //Console.ReadLine();



        }
    }
}