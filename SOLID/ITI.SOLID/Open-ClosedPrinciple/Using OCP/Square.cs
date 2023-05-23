using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosedPrinciple.Using_OCP
{
    public class Square:Shape
    {
        public double SideLength { get; set; }

        public override double Area()
        {
            return SideLength * SideLength;
        }
    }
}
