using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.DesignPatterns.Observer_DP
{
    internal class Refree : IObserver
    {
        public void Notify(Ball ball)
        {
            Console.WriteLine("the refree start to follow the ball ...");
        }
    }
}
