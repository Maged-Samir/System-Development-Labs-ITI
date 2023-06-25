using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.DesignPatterns.Observer_DP
{
    internal class Player : IObserver
    {
        public void Notify(Ball ball)
        {
            Console.WriteLine("the player start to follow the ball ...");
        }
    }
}
