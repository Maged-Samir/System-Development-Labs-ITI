using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.DesignPatterns.Observer_DP
{
    internal interface IObserver
    {
        void Notify(Ball ball);
    }
}
