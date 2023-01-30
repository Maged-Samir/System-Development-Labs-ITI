using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    enum Types
    {
        Ethernet=2 ,Token=4
    }
    internal class NIC
    {
        public string manfacture { get; set; }
        public string macAddress { get; set; }

        public Types type { get; set; }

        static NIC F;

        private NIC(string manfacture,string mackAddress, Types type)
        {
            this.manfacture = manfacture;
            this.macAddress = mackAddress;
            this.type = type;
        }

        public static NIC GetNIC()
        {
            if(F== null)
            F= new NIC("EGY", "1",0);
            return F;
        }




        public override string ToString()
        {
            return $"NIC Information :({manfacture},{macAddress},{Types.Ethernet})";
        }
    }
}
