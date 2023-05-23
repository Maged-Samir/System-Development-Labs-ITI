using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosedPrinciple.Original_Class
{
    public class Shape
    {
        public string Type { get; set; }

        public double CalculateArea()
        {
            double area = 0;

            if (Type == "Circle")
            {
                // Circle area calculation
            }
            else if (Type == "Square")
            {
                // Square area calculation
            }
            else if (Type == "Rectangle")
            {
                // Rectangle area calculation
            }
            // Additional shapes and their calculations...

            return area;
        }
    }
}
