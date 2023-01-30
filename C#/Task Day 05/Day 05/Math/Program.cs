namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Math m = new Math();
            //Console.WriteLine(m.Sum(10, 2));
            //Console.WriteLine(m.Sub(10, 2));
            //Console.WriteLine(m.Mul(10, 2));
            //Console.WriteLine(m.Div(10, 2));

            Console.WriteLine("Summition= {0}", Math.Sum(10, 2));
            Console.WriteLine("Subtraction= {0}", Math.Sub(10, 2));
            Console.WriteLine("Multiplication= {0}", Math.Mul(10, 2));
            Console.WriteLine("Divition= {0}", Math.Div(10, 2));

            Console.WriteLine("===============================");

            NIC n1 = NIC.GetNIC();
            NIC n2 = NIC.GetNIC();
            NIC n3 = NIC.GetNIC();

            Console.WriteLine(n1.ToString());
            Console.WriteLine(n2.ToString());
            Console.WriteLine(n3.ToString());



        }
    }
}