using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Original_Class
{
    public class HPPrinter : IPrinter
    {
        public void Print()
        {
            // Print implementation
        }

        public void Scan()
        {
            throw new NotSupportedException("This printer does not support scanning.");
        }

        public void Fax()
        {
            throw new NotSupportedException("This printer does not support faxing.");
        }


    }
}
