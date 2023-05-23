using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Using_ISP
{
    public class SamsungPrinter : IPrinter, IScanner, IFax
    {
        
        public void Print()
        {
            // Print implementation
        }

        public void Scanner()
        {
            // Scanner implementation
        }

        public void Fax()
        {
            // Fax implementation
        }

    }
}
