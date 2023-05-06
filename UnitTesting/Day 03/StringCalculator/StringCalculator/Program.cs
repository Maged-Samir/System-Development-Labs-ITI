namespace StringCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            StringCalc calc= new StringCalc();
            int result = calc.Add("2,3");
            Console.WriteLine(result);
        }
    }
}