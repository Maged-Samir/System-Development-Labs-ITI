namespace MaxDistance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length of array");
            int l = int.Parse(Console.ReadLine());
            int[] array = new int[l];
            for (int i = 0; i < l; i++)
            {
                Console.Write($"enter element {i + 1} =");
                array[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            for (int i = 0; i < l; i++)
            {
                Console.Write($"{array[i]}   ");
            }
            Console.WriteLine();
            int max = 0;
            int elem = 0;
            int fi = 0;
            int la = 0;
            for (int i = 0; i < l; i++)
            {
                for (int j = l - 1; j > 0; j--)
                {
                    if (array[i] == array[j] && max < (j - i - 1))
                    {
                        max = j - i - 1;
                        elem = array[i];
                        fi = i + 1;
                        la = j + 1;
                        break;
                    }
                    else if (i == j)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"max distance is {max} between elem {fi} and elem {la} and the number is {elem}");
            Console.ReadLine();
        }
    }
}