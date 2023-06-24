using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.CSharp
{
    public class Threading
    {
       public static void PrintX()
        {
            for(int i = 0; i < 500; i++)
            {
                Console.Write($"X ,{i}");
            }
        }

        public static void PrintY()
        {
            for (int i = 0; i < 500; i++)
            {
                Console.Write($"Y ,{i}");
            } 
        }
    }
}
