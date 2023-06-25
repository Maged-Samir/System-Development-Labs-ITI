using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.DesignPatterns.Observer_DP
{
    internal class Ball
    {
        ArrayList observers=new ArrayList();

        public void AttachObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void DeAttachObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void DisplayObservers() 
        {
            foreach (IObserver item in observers)
            {
                item.Notify(this);
            }
        }

        public void Kick()
        {
            Console.WriteLine("Ball is Kicked ...");
            DisplayObservers();
        }


    }

}
