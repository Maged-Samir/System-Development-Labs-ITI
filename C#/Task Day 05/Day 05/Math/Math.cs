using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    internal class Math
    {
        public static int Sum (int x,int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Mul(int x, int y)
        {
            return x * y;
        }


        public static int Div(int x, int y)
        {
            if (y != 0)
                return x / y;
            else
                return 0;
        }
    }
}
