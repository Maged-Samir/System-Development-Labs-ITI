namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("enter a  string");
                string s = Console.ReadLine();
                string[] arr = s.Split(' ');
                Array.Reverse(arr);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}