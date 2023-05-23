using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Original_Class
{
    public class SamsungPrinter:IPrinter
    {
        public void Print()
        {
            // Print implementation
        }

        public void Scan()
        {
            // Scan implementation
        }

        public void Fax()
        {
            // Fax implementation
        }
    }
}
